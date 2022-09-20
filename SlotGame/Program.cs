using SlotGame.Interfaces;
using SlotGame.Models;

namespace SlotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWallet wallet = new Wallet();
            wallet.Set();

            IStake stake = new Stake(wallet);
            List<IRow> rows = new List<IRow>() {
                new Row(),
                new Row(),
                new Row(),
                new Row()
            };

            ISlots Slots = new Slots(wallet, stake, rows);
            Slots.PlayGame();
        }
    }
}