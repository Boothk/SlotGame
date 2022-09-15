using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Interfaces
{
    // Responsible for symbol definition
    public interface ISymbol
    {
        char Char { get; set; }
        decimal Coefficient { get; set; }
        decimal Probability { get; set; }
    }
}
