using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Inventory
{
    class Crackers : IShippable
    {
        public decimal ShipCost => .57M;


        public string Product => "Crackers";

    }
}
