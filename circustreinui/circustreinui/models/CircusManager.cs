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

            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.small));
            AnimalList.Add(new Animal(true, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.large));
            AnimalList.Add(new Animal(false, grotes.large));
            AnimalList.Add(new Animal(false, grotes.small));
            AnimalList.Add(new Animal(false, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.small));
            AnimalList.Add(new Animal(false, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.small));
            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.large));
            AnimalList.Add(new Animal(true, grotes.small));
            AnimalList.Add(new Animal(true, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.large));
            AnimalList.Add(new Animal(false, grotes.large));
            AnimalList.Add(new Animal(false, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.small));
            AnimalList.Add(new Animal(false, grotes.medium));
            AnimalList.Add(new Animal(false, grotes.small));

        }

        public void Sort() {
            AnimalList = AnimalList.OrderByDescending(o => o.grote).ToList();
        }

    }
}
