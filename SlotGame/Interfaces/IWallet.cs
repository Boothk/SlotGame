namespace SlotGame.Interfaces
{
    public interface IWallet
    {
        public decimal Amount { get; }
        public void Set();
        public void Transact(decimal value);
        public void PrintBalance();
    }
}
