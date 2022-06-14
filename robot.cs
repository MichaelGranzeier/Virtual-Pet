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
        public int Battery = 100;
        public int Oil = 100;

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

