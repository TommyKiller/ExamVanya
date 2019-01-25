using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public FeedType FeedType { get; private set; }

        public Animal(string name, DateTime dateOfBirth, FeedType feedType)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            FeedType = feedType;
        }

        public override string ToString()
        {
            return Name + " [" + DateOfBirth.ToShortDateString().ToString() + "]";
        }
    }
}
