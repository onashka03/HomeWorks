using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restraunt
{
    class EggOrder
    {
        public int QuantityRequested { get; private set; }
        public int? Quality { get; private set; }
        Random random = new Random();
        private static int instanceCount = 0;       
        public EggOrder(int quantityRequested)
        {
            QuantityRequested = quantityRequested;
            instanceCount++;
            if (ShouldForgetQuality())
            {
                Quality = null;
            }
            else
            {
                Quality = GenerateRandomQuality();
            }
        }
        public EggOrder(int QuantityRequested, int? Quality)       
        {
            this.QuantityRequested = QuantityRequested;
            this.Quality = Quality;
        }

        public int GetQuantity()
        {
            return QuantityRequested;
        }
        public int? GetQuality()
        {
            if (instanceCount % 2 == 1)
                Quality = random.Next(2, 120);
            instanceCount++;
            return Quality;
        }
        public void Crack()
        {
            if (Quality.HasValue && Quality < 25)
            {
                throw new Exception("Cracked a rotten egg!");
            }         
        }
        public void DiscardShell() 
           {}  
        public void Cook()
        {}
        private int GenerateRandomQuality()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
        private bool ShouldForgetQuality()
        {
            return instanceCount % 2 == 0;
        }
    }
}
