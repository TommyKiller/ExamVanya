using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Omnivorous : FeedType
    {
        public Omnivorous()
            : base(new List<Product>
            {
                new Product("Vegetables"),
                new Product("Hay"),
                new Product("Meat"),
                new Product("Fish")
            })
        { }
    }
}
