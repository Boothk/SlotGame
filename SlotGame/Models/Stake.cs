using SlotGame.Interfaces;

namespace SlotGame.Models
{
    public class Stake : IStake
    {
        public decimal wager { get; set; }
        public IWallet _wallet { get; set; }
        public decimal winnings { get; set; }

        public Stake(IWallet wallet)
        {
            _wallet = wallet;
        }

        public void MakeWager()
        {
            winnings = 0;
            bool awaitingValidInput = true;

            while (awaitingValidInput)
            {
                Console.WriteLine("Enter stake amount:");
                var amount = Console.ReadLine();

                decimal parseOut;
                if (decimal.TryParse(amount, out parseOut))
                {
                    if(parseOut > 0)
                    {
                        wager = parseOut;
                        awaitingValidInput = false;
                    }
                }
            }
        }

        public decimal GetWinnings()
        {
            var output = winnings * wager;
            return output;
        }

        public void Payout()
        {
            var output = (wager * -1) + GetWinnings();
            _wallet.Transact(output);

            Console.WriteLine($"\nYou have won: {GetWinnings()}");
            _wallet.PrintBalance();
        }
    }
}
