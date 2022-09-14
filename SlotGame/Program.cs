using SlotGame.Interfaces;
using SlotGame.Models;

namespace SlotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWallet Wallet = new Wallet();
            Wallet.Set();
            Slots Slots = new Slots(Wallet);
            Slots.PlayGame();
        }
    }
}