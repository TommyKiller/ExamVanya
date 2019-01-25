using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Carnivorous : FeedType
    {
        public Carnivorous()
            : base(new List<Product>
            {
                new Product("Meat"),
                new Product("Fish")
            })
        { }
    }
}
