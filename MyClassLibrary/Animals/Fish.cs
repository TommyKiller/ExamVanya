using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Fish : Animal
    {
        public Fish(string name, DateTime dateOfBirth, FeedType feedType) : base(name, dateOfBirth, feedType) { }
    }
}
