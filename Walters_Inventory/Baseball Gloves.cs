using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Inventory
{
    class Baseball_Gloves : IShippable
    {
        public decimal ShipCost => 3.23M;




        public string Product => "BaseBall Glove";

    }
}
