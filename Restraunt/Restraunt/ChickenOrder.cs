using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restraunt
{
    public class ChickenOrder
    {
        public int QuantityRequested { get; private set; }
        private int cutUpCount;
        private bool isCooked;

        public ChickenOrder(int quantityRequested)
        {
            QuantityRequested = quantityRequested;
            cutUpCount = 0;
            isCooked = false;
        }
        public int GetQuantity()
        {
            return QuantityRequested;
        }
        public void CutUp()
        {
            for (int i = 0; i < QuantityRequested; i++)
            {
                cutUpCount++;
            }
        }
        public void Cook()
        {
            if (!isCooked)
            {
                isCooked = true;
            }
        }
    }
}

