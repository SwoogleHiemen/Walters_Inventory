using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Inventory
{
    class Lawn_Mowers : IShippable
    {
        public decimal ShipCost => 24.00M;


        public string Product => "Lawn Mower";

    }
}
