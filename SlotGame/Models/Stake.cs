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
        public float wager { get; set; }
        public IWallet _wallet { get; set; }


        public Stake(IWallet wallet)
        {
            _wallet = wallet;
        }

        public void MakeWager()
        {
            bool awaitingValidInput = true;

            while (awaitingValidInput)
            {
                Console.WriteLine("Enter stake amount:");
                var amount = Console.ReadLine();

                float parseOut;
                if (float.TryParse(amount, out parseOut))
                {
                    if(parseOut > 0)
                    {
                        wager = parseOut;
                        awaitingValidInput = false;
                    }
                }
            }
        }
    }
}
