using SlotGame.Interfaces;

namespace SlotGame.Models
{
    public class Symbol : ISymbol
    {
        public char Char { get; set; }
        public decimal Coefficient { get; set; }
        public decimal Probability { get; set; }
    }
}
