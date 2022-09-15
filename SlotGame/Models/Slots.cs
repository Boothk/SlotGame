using SlotGame.Interfaces;

namespace SlotGame.Models
{
    class Slots
    {
        public IStake Stake { get; set; }
        public IWallet _wallet { get; set; } 
        public List<Row> Rows { get; set; }

        public Slots(IWallet wallet)
        {
            _wallet = wallet;
            Stake = new Stake(_wallet);
            Rows = new List<Row>() {
                new Row(),
                new Row(),
                new Row(),
                new Row()
            };
        }

        public void PlayGame()
        {
            while (_wallet.Amount > 0)
            {
                Stake.MakeWager();
                Spin();
                Stake.Payout();
            }
        }

        public void Spin()
        {
            foreach (var Row in Rows)
            {
                Row.SpinRow();
                Row.PrintResult();

                if (Row.IsWin())
                {
                    Stake.winnings += Row.TotalCoefficient;
                }
            }
        }
    }
}
