namespace SlotGame.Interfaces
{    
    public interface ISymbol
    {
        char Char { get; set; }
        decimal Coefficient { get; set; }
        decimal Probability { get; set; }
    }
}
