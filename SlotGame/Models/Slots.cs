using SlotGame.Interfaces;

namespace SlotGame.Models
{
    class Slots : ISlots
    {
        private IStake _stake { get; set; }
        private IWallet _wallet { get; set; }
        private List<IRow> _rows { get; set; }

        public Slots(IWallet wallet, IStake stake, List<IRow> rows)
        {
            _wallet = wallet;
            _stake = stake;
            _rows = rows;
        }

        public void PlayGame()
        {
            while (_wallet.Amount > 0)
            {
                _stake.MakeWager();
                Spin();
                _stake.Payout();
            }
        }

        public void Spin()
        {
            foreach (var row in _rows)
            {
                row.SpinRow();
                row.PrintResult();

                if (row.IsWin())
                {
                    _stake.AddToWinnings(row.TotalCoefficient);
                }
            }
        }
    }
}
