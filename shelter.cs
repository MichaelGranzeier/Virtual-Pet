using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_Pet;

namespace template_csharp_virtual_Shelter
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
