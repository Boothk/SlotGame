using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Interfaces
{
    // Responsible for running the game
    public interface ISlots
    {
        IWallet _wallet { get; set; }
        IStake Stake { get; set; }
        List<IRow> Rows { get; set; }

        //void Spin();
        //void RandomSymbol();
        //IStake Stake { get; set; }
        //void CalculateResults();
        //void Initiate();

    }
}
