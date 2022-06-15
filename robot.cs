using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_Pet;

namespace template_csharp_virtual_Robot
{
    public class Robot : Pet
    {
        public string Name;
        public string Species;
        public int Battery = 100;
        public int Oil = 100;

        public Robot(string name,string species, int battery, int oil)
        {
            Name = name;
            Species = species;
            Battery = battery;
            Oil = oil;
        }

        public void Charge()
        {
            Battery = 100;
        }
        public void oil()
        {
            Oil = 100;
        }
        public void Tick()
        {
            Battery -= 10;
            Oil -= 10;
        }
    }
}

