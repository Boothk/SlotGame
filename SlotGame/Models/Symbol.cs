using SlotGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Models
{
    public class Symbol : ISymbol
    {
        public char Char { get; set; }
        public float Coefficient { get; set; }
        public float Probability { get; set; }
    }
}
