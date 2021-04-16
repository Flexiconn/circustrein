using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustreinui.models
{
    class CircusManager
    {
        public List<Animal> AnimalList { get; set; }

        public CircusManager() {
            AnimalList = new List<Animal>();

            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = true, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.large });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.medium });
            AnimalList.Add(new Animal() { carnivore = false, grote = grotes.small });

        }

        public void Sort() {
            AnimalList = AnimalList.OrderByDescending(o => o.grote).ToList();
        }

    }
}
