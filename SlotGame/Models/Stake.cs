using SlotGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("GetWinnings: " + output);
            return output;
        }

        public void Payout()
        {
            var output = (wager * -1) + GetWinnings();
            Console.WriteLine("Payout: " + output);
            _wallet.Transact(output);

            Console.WriteLine($"\nYou have won: {GetWinnings()}");
            Console.WriteLine($"Current balance is: {_wallet.Amount}");
        }
    }
}
