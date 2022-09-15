namespace SlotGame.Interfaces
{
    public interface IRow
    {
        ISymbol A { get; set; }
        ISymbol B { get; set; }
        ISymbol C { get; set; }
        List<ISymbol> symbols { get; }
        decimal TotalCoefficient { get; set; }
        bool IsWin();
        void PrintResult();
        void SpinRow();
        ISymbol RandomSymbol();
    }
}
