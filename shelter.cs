using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_pet;

namespace template_csharp_virtual_shelter
{
    public class Shelter
    {
        public int Capacity;
        public List<Pet> Pets;

        public Shelter(int capacity)
        {
            Capacity = capacity;
            Pets = new List<Pet>();
        }
        public Shelter(List<Pet> pets)
        {
            Capacity =pets.Count;
            Pets = pets;
           
        }
    }
}
