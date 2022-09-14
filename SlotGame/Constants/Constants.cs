using SlotGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotGame.Constants
{
    public static class Symbols
    {
        public static Symbol Wildcard = new Symbol() { Char = '*', Coefficient = 0, Probability = 0.05f };
        public static Symbol Apple = new Symbol() { Char = 'A', Coefficient = 0.4f, Probability = 0.45f };
        public static Symbol Banana = new Symbol() { Char = 'B', Coefficient = 0.6f, Probability = 0.35f };
        public static Symbol Pineapple = new Symbol() { Char = 'P', Coefficient = 0.8f, Probability = 0.15f };
    }
}
