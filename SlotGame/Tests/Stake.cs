using SlotGame.Interfaces;
using SlotGame.Constants;
using Moq;
using NUnit.Framework;
using SlotGame.Models;

namespace SlotGame.Tests
{
    [TestFixture]
    public class StakeTest
    {
        private Mock<IWallet> walletMock;

        public StakeTest()
        {
            walletMock = new Mock<IWallet>();
        }

        public class WhenPayingOutAPrize : StakeTest
        {
            [TestCase(100, 0.4, -60)]
            [TestCase(100, 0.6, -40)]
            [TestCase(100, 0.8, -20)]
            [TestCase(100, 1, 0)]
            [TestCase(100, 1.4, 40)]
            [TestCase(100, 1.6, 60)]
            [TestCase(100, 1.8, 80)]
            public void ThenWalletIsUpdatedWithCorrectAmount(decimal wager, decimal totalWinnings, decimal expectedWinnings)
            {
                IStake testStake = new Stake(walletMock.Object);
                testStake.wager = wager;
                testStake.AddToWinnings(totalWinnings);

                testStake.Payout();

                walletMock.Verify(x => x.Transact(expectedWinnings), Times.Once());
            }
        }

        public class WhenNotPayingOutAPrize : StakeTest
        {
            [TestCase(100, 0, -100)]
            [TestCase(50, 0, -50)]
            [TestCase(30, 0, -30)]
            public void ThenWalletIsUpdatedWithCorrectAmount(decimal wager, decimal totalWinnings, decimal expectedWinnings)
            {
                IStake testStake = new Stake(walletMock.Object);
                testStake.wager = wager;
                testStake.AddToWinnings(totalWinnings);

                testStake.Payout();

                walletMock.Verify(x => x.Transact(expectedWinnings), Times.Once());
            }
        }
    }
}
