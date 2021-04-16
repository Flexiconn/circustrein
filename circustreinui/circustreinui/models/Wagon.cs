using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustreinui.models
{
    class Wagon
    {
        public int plaats { get; set; }
        public List<Animal> Animals { get; set; }

        public Wagon()
        {
            Animals = new List<Animal>();
        }
        public Animal getcarnivore()
        {
            foreach (var t in Animals)
            {
                if (t.carnivore == true)
                    return t;
                else
                    return t;
            }
            return null;
        }

        public bool addAnimal(Animal animal)
        {
            if (10 - this.plaats >= (int)animal.grote) 
            {
                plaats += (int)animal.grote;
                Animals.Add(animal);
                return true;
            }
            return false;
        }
    }
}
