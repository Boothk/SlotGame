using SlotGame.Interfaces;
using SlotGame.Constants;

namespace SlotGame.Models
{
    class Row : IRow
    {
        public ISymbol A { get; set; }
        public ISymbol B { get; set; }
        public ISymbol C { get; set; }

        public List<ISymbol> symbols
        {
            get => new List<ISymbol>()
            {
                Symbols.Wildcard,
                Symbols.Apple,
                Symbols.Banana,
                Symbols.Pineapple
            };
        }

        public decimal TotalCoefficient { get; set; }

        public bool IsWin()
        {
            try
            {
                ISymbol[] ary = new ISymbol[3] { A, B, C };
                return (ary.Distinct().Where(x => !x.Equals(Symbols.Wildcard)).Count() == 1);
            }
            catch (Exception e)
            {
                // Ideally a logger would be here instead of a thrown exception
                throw new NullReferenceException(e.ToString());
            }
        }

        public void PrintResult()
        {
                Console.WriteLine($"{A.Char}{B.Char}{C.Char}");
        }

        public void SpinRow()
        {
            A = RandomSymbol();
            B = RandomSymbol();
            C = RandomSymbol();
            TotalCoefficient = A.Coefficient + B.Coefficient + C.Coefficient; 
        }

        public ISymbol RandomSymbol()
        {
            Random rand = new Random();
            var probabilityWeight = symbols.Sum(x => x.Probability) * 100;
            decimal randValue = (decimal)rand.Next(0, (int)probabilityWeight) / 100;

            decimal min = 0;
            decimal max = 0;
            ISymbol symbolResult = symbols.First();

            foreach(var sym in symbols)
            {
                max = min + sym.Probability;
                if(randValue >= min && randValue < max)
                {
                    symbolResult = sym;
                    break;
                }
                min = max;
            }
            return symbolResult;
        }
    }
}
