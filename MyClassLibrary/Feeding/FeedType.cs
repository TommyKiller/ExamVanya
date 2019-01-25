using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public abstract class FeedType
    {
        public List<Product> Products { get; private set; }

        public FeedType(List<Product> products)
        {
            Products = products;
        }
    }
}
