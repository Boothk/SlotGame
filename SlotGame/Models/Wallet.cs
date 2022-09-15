using SlotGame.Interfaces;

namespace SlotGame.Models
{
    public class Wallet : IWallet
    {
        public decimal Amount { get; private set; }

        public void Set()
        {
            bool awaitingValidInput = true;

            while (awaitingValidInput)
            {
                Console.WriteLine("Please deposit money you would like to play with:");
                var amount = Console.ReadLine();

                decimal parseOut;
                if(decimal.TryParse(amount, out parseOut))
                {
                    if (parseOut > 0)
                    {
                        Amount = parseOut;
                        awaitingValidInput = false;
                    }
                }
            }
        }

        public void Transact(decimal value)
        {
            Amount += value;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Current Balance is: {Amount}");
        }
    }
}
