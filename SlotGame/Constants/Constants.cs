using SlotGame.Models;

namespace SlotGame.Constants
{
    // Using a constants class here as a means of consistency
    // This could be made more configurable through the use of a .json file
    public static class Symbols
    {
        public static Symbol Wildcard = new Symbol() { Char = '*', Coefficient = 0, Probability = 0.05m };
        public static Symbol Apple = new Symbol() { Char = 'A', Coefficient = 0.4m, Probability = 0.45m };
        public static Symbol Banana = new Symbol() { Char = 'B', Coefficient = 0.6m, Probability = 0.35m };
        public static Symbol Pineapple = new Symbol() { Char = 'P', Coefficient = 0.8m, Probability = 0.15m };
    }
}
