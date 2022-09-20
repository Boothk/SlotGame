using SlotGame.Interfaces;
using SlotGame.Constants;
using Moq;
using NUnit.Framework;
using SlotGame.Models;
using NUnit.Framework.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace SlotGame.Tests
{
    [TestFixture]
    public class RowTest
    {
        public ISymbol A = Symbols.Apple;
        ISymbol B = Symbols.Banana;
        ISymbol P = Symbols.Pineapple;
        ISymbol W = Symbols.Wildcard;
        ISymbol[,]? testData;
        private Mock<IRow> rowMock;

        public class WhenTheRowWins: RowTest
        {
            IRow _testRow;

            public WhenTheRowWins()
            {
                testData = new ISymbol[,] {
                    { W, P, W },
                    { A, A, A },
                    { B, B, B },
                    { P, P, P },
                    { W, W, P },
                    { P, W, W },
                    { A, A, W },
                    { W, B, B },
                    { P, W, P }
                };
            }

            [Test]
            public void ThenIsWinReturnsTrue()
            {
                _testRow = new Row();
                for (var i = 0; i < testData.GetLength(0); i++)
                {
                    _testRow.A = testData[i, 0];
                    _testRow.B = testData[i, 1];
                    _testRow.C = testData[i, 2];
                    var result = _testRow.IsWin();

                    Assert.IsTrue(result);
                }
            }
        }

        public class WhenTheRowLoses : RowTest
        {
            private IRow _testRow;

            public WhenTheRowLoses()
            {
                testData = new ISymbol[,] {
                    { A, B, P },
                    { W, A, B },
                    { W, W, W },
                    { A, B, W },
                    { A, W, B },
                    { P, P, B },
                    { B, A, B }
                };
            }

            [Test]
            public void ThenIsWinReturnsFalse()
            {
                _testRow = new Row();
                for (var i = 0; i < testData.GetLength(0); i++)
                {
                    _testRow.A = testData[i, 0];
                    _testRow.B = testData[i, 1];
                    _testRow.C = testData[i, 2];

                    var result = _testRow.IsWin();

                    Assert.IsFalse(result);
                }
            }
        }

        public class WhenTheRowSpins : RowTest
        {
            private IRow _testRow;
            private double[] testTotalCoefficient;

            public WhenTheRowSpins()
            {
                rowMock = new Mock<IRow>();
                testData = new ISymbol[,] { { A, B, P } };

                testTotalCoefficient = new double[] { 1.2, 1.8, 2.4 };
            }

            //[Test]
            //public void ThenEachSymbolIsRandomised()
            //{
            //    //_testRow = new Row();
            //    //_testRow.SpinRow();
            //    //rowMock.Verify(x => x.RandomSymbol(), Times.Exactly(3));
            //}

            //[Test]
            //public void ThenTotalCoefficientIsCorrect()
            //{
            //    for (var i = 0; i < testData.GetLength(1); i++)
            //    {
            //        rowMock.Setup(x => x.RandomSymbol()).Returns(testData[0, i]);
            //        rowMock.Object.PrintResult();
            //        rowMock.Verify(x => x.RandomSymbol(), Times.Exactly(3));

            //        Assert.AreEqual(testTotalCoefficient[i], rowMock.Object.TotalCoefficient);
            //    }
            //    rowMock.Verify(x => x.RandomSymbol(), Times.Exactly(3));
            //}
        }
    }
}
