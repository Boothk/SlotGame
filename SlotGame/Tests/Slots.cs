using SlotGame.Interfaces;
using SlotGame.Constants;
using Moq;
using NUnit.Framework;
using SlotGame.Models;

namespace SlotGame.Tests
{
    [TestFixture]
    public class SlotTest
    {
        ISlots slotTest;
        Mock<IWallet> walletMock;
        Mock<IStake> stakeMock;
        Mock<List<IRow>> rowMock;

        public SlotTest()
        {
            walletMock = new Mock<IWallet>();
            stakeMock = new Mock<IStake>();
            rowMock = new Mock<List<IRow>>();

            slotTest = new Slots(walletMock.Object, stakeMock.Object, rowMock.Object);
        }

        public class WhenWalletIsEmpty : SlotTest 
        {
            [Test]
            public void ThenTheGameWillEnd()
            {
                int moneyCount = 0;
                walletMock.Setup(x => x.Amount).Returns(moneyCount);
                slotTest.PlayGame();
                stakeMock.Verify(x => x.Payout(), Times.Never());
            }
        }

        public class WhenWalletIsNotEmpty : SlotTest
        {
            [Test]
            public void ThenGameContinuesUntilWalletIsEmpty()
            {
                int moneyCount = 3;
                walletMock.Setup(x => x.Amount).Returns(moneyCount);
                stakeMock.Setup(x => x.Payout()).Callback(() => {
                    moneyCount--;
                    walletMock.Setup(x => x.Amount).Returns(moneyCount);
                });
                slotTest.PlayGame();
                stakeMock.Verify(x => x.Payout(), Times.Exactly(3));
            }

        }
    }
}
