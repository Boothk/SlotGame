namespace SlotGame.Interfaces
{
    public interface IRow
    {
        ISymbol A { get; set; }
        ISymbol B { get; set; }
        ISymbol C { get; set; }
        decimal TotalCoefficient { get; set; }
        bool IsWin();
        void PrintResult();
        void SpinRow();
        ISymbol RandomSymbol();
    }
}
