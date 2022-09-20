using SlotGame.Interfaces;

namespace SlotGame.Models
{
    public class Stake : IStake
    {
        public decimal wager { get; set; }
        private IWallet _wallet { get; set; }
        private decimal _winnings { get; set; }

        public Stake(IWallet wallet)
        {
            _wallet = wallet;
        }

        public void MakeWager()
        {
            _winnings = 0;
            bool awaitingValidInput = true;

            while (awaitingValidInput)
            {
                Console.WriteLine("Enter stake amount:");
                var amount = Console.ReadLine();

                decimal parseOut;
                if (decimal.TryParse(amount, out parseOut))
                {
                    if(parseOut > 0 && parseOut <= _wallet.Amount)
                    {
                        wager = parseOut;
                        awaitingValidInput = false;
                    }
                }
            }
        }

        public decimal GetWinnings()
        {
            var output = _winnings * wager;
            return output;
        }

        public void Payout()
        {
            var output = (wager * -1) + GetWinnings();
            _wallet.Transact(output);

            Console.WriteLine($"\nYou have won: {GetWinnings()}");
            _wallet.PrintBalance();
        }

        public void AddToWinnings(decimal value)
        {
            _winnings += value;
        }
    }
}
