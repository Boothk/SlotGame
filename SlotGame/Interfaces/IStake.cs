namespace SlotGame.Interfaces
{
    public interface IStake
    {
        public decimal wager { get; set; }
        public decimal GetWinnings();
        public void MakeWager();
        public void Payout();
        public void AddToWinnings(decimal value);
    }
}
