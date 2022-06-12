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
        public List<Pet> Pets;

        public void shelter()
        {
            Pets = new List<Pet>();
        }
    }
}
