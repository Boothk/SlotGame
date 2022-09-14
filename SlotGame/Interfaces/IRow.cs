using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Interfaces
{
    // Responsible for results
    public interface IRow
    {
        ISymbol A { get; set; }
        ISymbol B { get; set; }
        ISymbol C { get; set; }
        float TotalCoefficient { get; set; }
        bool CalculateWin();
        string PrintResult();
        void CalculateResult();
        void SpinRow();
    }
}
