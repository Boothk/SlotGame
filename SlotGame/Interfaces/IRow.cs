using SlotGame.Models;
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
        decimal TotalCoefficient { get; set; }
        bool IsWin();
        void PrintResult();
        void SpinRow();
        Symbol RandomSymbol();
    }
}
