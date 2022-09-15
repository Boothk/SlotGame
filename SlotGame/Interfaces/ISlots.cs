namespace SlotGame.Interfaces
{
    public interface ISlots
    {
        IWallet _wallet { get; set; }
        IStake Stake { get; set; }
        List<IRow> Rows { get; set; }
        void PlayGame();
        void Spin();
    }
}
