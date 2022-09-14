using SlotGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotGame.Constants;

namespace SlotGame.Models
{
    class Row : IRow
    {
        public ISymbol A { get; set; }
        public ISymbol B { get; set; }
        public ISymbol C { get; set; }

        public float TotalCoefficient { get; set; }

        public void CalculateResult()
        {
            throw new NotImplementedException();
        }

        public bool CalculateWin()
        {
            throw new NotImplementedException();
        }

        public string PrintResult()
        {
            throw new NotImplementedException();
        }

        public void SpinRow()
        {
            A = RandomSymbol();
            B = RandomSymbol();
            C = RandomSymbol();
            TotalCoefficient = A.Coefficient + B.Coefficient + C.Coefficient;
        }

        public Symbol RandomSymbol()
        {
            float rand = 0;

            switch (rand)
            {
                case 1:
                    return Symbols.Apple;
                case 2:
                    return Symbols.Banana;
                case 3:
                    return Symbols.Pineapple;
                case 0:
                default:
                    return Symbols.Wildcard;
            }
        }
    }
}
