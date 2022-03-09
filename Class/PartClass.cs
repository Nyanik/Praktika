using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    public partial class Product
    {
        public string Header
        {
            get
            {
                return ProductType.Title + " | " + Title ;
            }
        }
        public int Cost
        {
            get
            {
                return (int)MinCostForAgent;
            }
        }
    }
}
