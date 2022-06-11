using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger;
        public int Boredom;
        public int Health;
        

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 60;
            Boredom = 60;
            Health = 60;
          
        }

        public void Feed()
        {
            Hunger += 30;
        }
        public void Play()
        {
            Boredom += 30;
        }
        public void Vet()
        {
            Health += 30;
        }
        public void Tick()
        {
            Health -= 5;
            Hunger -= 5;
            Boredom -= 5;
        }
    }
}
