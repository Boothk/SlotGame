using SlotGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Models
{
    public class Wallet: IWallet
    {
        public float Amount { get; private set; }

        public void Set()
        {
            bool awaitingValidInput = true;

            while (awaitingValidInput)
            {
                Console.WriteLine("Please deposit money you would like to play with:");
                var amount = Console.ReadLine();

                float parseOut;
                if(float.TryParse(amount, out parseOut))
                {
                    if (parseOut > 0)
                    {
                        Amount = parseOut;
                        awaitingValidInput = false;
                    }
                }
            }
        }

        public void Transact(float value)
        {
            Amount += value;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Current Balance is: {Amount}");
        }
    }
}
