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

        public class WhenTheRowWins: RowTest
        {
            IRow _testRow;

            public WhenTheRowWins()
            {
                _testRow = new Row();
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
                _testRow = new Row();
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
    }
}
