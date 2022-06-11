using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_pet;

namespace template_csharp_virtual_organic
{
    public class Organic
    {
        public int Hunger;
        public int Boredom;
        public int Health;

        public Organic()
        {
            Hunger = 60;
            Boredom = 60;
            Health = 60;
        }

        public void Feed()
        {
            Hunger += 50;
            Health += 50;
        }
        public void Play()
        {
            Boredom += 50;
        }
        public void Tick()
        {
            Health -= 5;
            Hunger -= 5;
            Boredom -= 5;
        }
    }
}
