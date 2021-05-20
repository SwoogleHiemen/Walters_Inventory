using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Inventory
{
    class Shipper 
    {
        int _counter = 0;
        int _BicycleCounter = 0;
        int _LawnMowerCounter = 0;
        int _BaseballGloveCounter = 0;
        int _CrackersCounter = 0;
        public void Add(string ProductType, int counter, int BicycleCounter, int LawnMowerCounter, int CrackersCounter, int BaseballGloveCounter)
         {
            IShippable[] Products = new IShippable[4];
            Products[0] = new Bicycles();
            Products[1] = new Lawn_Mowers();
            Products[2] = new Baseball_Gloves();
            Products[3] = new Crackers();
            if (ProductType == Products[0].Product)
            {
                _counter =0;
                _BicycleCounter =0;
                counter++;
                BicycleCounter++;
                _counter += counter;
                _BicycleCounter += BicycleCounter;

            }
            if (ProductType == Products[1].Product)
            {
                _counter =0;
                _LawnMowerCounter =0;
                counter++;
                LawnMowerCounter++;
                _counter += counter;
                _LawnMowerCounter += LawnMowerCounter;
            }
            if (ProductType == Products[2].Product)
            {
                _counter =0;
                _BaseballGloveCounter =0;
                counter++;
                BaseballGloveCounter++;
                _counter += counter;
                _BaseballGloveCounter += BaseballGloveCounter;
            }
           if(ProductType == Products[3].Product)
            {
                _counter =0;
                _CrackersCounter =0;
                counter++;
                CrackersCounter++;
                _counter += counter;
                _CrackersCounter += CrackersCounter;
            }
            
        }
        public int CounterMethod()
        {
            return _counter;
        }
        public int BicycleCounterMethod()
        {
            return _BicycleCounter;
        }
        public int LawnMowerCounterMethod()
        {
            return _LawnMowerCounter;
        }
        public int BaseballGloveCounterMethod()
        {
            return _BaseballGloveCounter;
        }
        public int CrackersCounterMethod()
        {
            return _CrackersCounter;
        }
        
    }
   
}
