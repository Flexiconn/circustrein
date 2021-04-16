using circustreinui.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustreinui
{
    class Logic
    {
        public Dictionary<Animal, Wagon> addToWagon = new Dictionary<Animal, Wagon>();
        public bool added = true;

        public Trein Operation()
        {
            CircusManager manager = new CircusManager();
            
            Trein train = new Trein() { Naampie = "choo choo" };
            manager.Sort();
            foreach (var Animal in manager.AnimalList.ToList())
            {
                if (Animal.carnivore == true)
                {
                    train.Wagons.Add(new Wagon());
                    train.Wagons[train.Wagons.Count - 1].addAnimal(Animal);
                    manager.AnimalList.Remove(Animal);
                }
            }


            foreach (var Animal in manager.AnimalList.ToList())
            {
                foreach (var wagon in train.Wagons)
                {
                    if (wagon.getcarnivore().grote >= Animal.grote)
                    {
                        continue;

                    }
                    if (wagon.addAnimal(Animal))
                    {
                        addToWagon.Add(Animal, wagon);
                        break;
                    }
                }
            }

            foreach (var t in addToWagon)
            {
                manager.AnimalList.Remove(t.Key);
            }

            addToWagon.Clear();

            manager.Sort(); 
            List<Wagon> newWagons = new List<Wagon>();
            newWagons.Add(new Wagon());
            foreach (Animal animal in manager.AnimalList)
            {
                foreach (Wagon wagon in newWagons)
                {
                    if (10 - wagon.plaats >= (int)animal.grote)
                    {
                        wagon.addAnimal(animal);
                        addToWagon.Add(animal, wagon);
                        added = true;
                    }
                    else
                    {
                        added = false;
                    }
                }

                if (!added)
                {
                    newWagons.Add(new Wagon());
                    newWagons[newWagons.Count - 1].addAnimal(animal);
                    addToWagon.Add(animal, null);
                }


            }

            train.Wagons.AddRange(newWagons);

            foreach (var t in addToWagon)
            {
                //t.Value.addAnimal(t.Key);
                manager.AnimalList.Remove(t.Key);
            }

            return train;

        }
    }
}
