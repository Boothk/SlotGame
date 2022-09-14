using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Interfaces
{
    // Responsible for tracking wallet and transaction methods
    public interface IWallet
    {
        public void Set();
        public void Transact(float value);
        public void PrintBalance();
        public float Amount { get; }
    }
}
