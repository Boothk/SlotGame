using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Interfaces
{
    // Responsible for setting stakes and applying wins to the wallet
    public interface IStake
    {
        float wager { get; set; }
        IWallet _wallet { get; set; }
        public void MakeWager();
    }
}
