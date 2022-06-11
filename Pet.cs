﻿using System;
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
        public PetType petType;

        public Pet(string name, string species, PetType pettype)
        {
            Name = name;
            Species = species;
            Hunger = 60;
            Boredom = 60;
            Health = 60;
            petType = pettype;
            switch (petType)
            {
                case PetType.Robot:
                    break;
            }
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

        public enum PetType
        {
            Robot,
            Dog,
            Cat,
            Bird,
        }
    }
}
