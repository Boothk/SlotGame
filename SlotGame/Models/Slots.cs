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
        }

        public void PlayGame()
        {
            while (_wallet.Amount > 0)
            {
                Stake.MakeWager();

            }
        }

        public void Spin()
        {
            foreach (var Row in Rows)
            {

            }
        }
    }
}
