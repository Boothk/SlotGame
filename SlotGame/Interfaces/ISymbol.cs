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
        float Coefficient { get; set; }
        float Probability { get; set; }
    }
}
