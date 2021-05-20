using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Inventory
{
    class Bicycles : IShippable
    {
        public decimal ShipCost => 9.50M;


        public string Product => "Bicycle";

    }
}
