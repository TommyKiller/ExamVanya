using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Aviary
    {
        public ID ID { get; private set; }
        public Type AnimalsType { get; private set; }
        public List<Animal> Animals { get; private set; } = new List<Animal>();
        public static List<Aviary> Aviaries { get; set; } = new List<Aviary>();

        public Aviary (ID id)
        {
            ID = id;
        }

        public void AddAnimal(Animal animal)
        {
            if (AnimalsType == null)
            {
                AnimalsType = animal.GetType();
                Animals.Add(animal);
            }
            else
            {
                if (AnimalsType == animal.GetType())
                {
                    Animals.Add(animal);
                }
            }
        }

        public override string ToString()
        {
            return "Aviary " + ID.ToString();
        }
    }
}
