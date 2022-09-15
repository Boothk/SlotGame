namespace SlotGame.Interfaces
{
    public interface IWallet
    {
        public void Set();
        public void Transact(decimal value);
        public void PrintBalance();
        public decimal Amount { get; }
    }
}
