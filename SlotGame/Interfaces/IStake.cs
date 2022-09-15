namespace SlotGame.Interfaces
{
    public interface IStake
    {
        decimal wager { get; set; }
        IWallet _wallet { get; set; }
        decimal winnings { get; set; }
        decimal GetWinnings();
        public void MakeWager();
        public void Payout();
    }
}
