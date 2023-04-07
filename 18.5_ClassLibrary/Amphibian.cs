﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    class Amphibian : IAnimal
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Weight { get; set; }

        public Amphibian (string Name, string Region, string Weight)
        {
            this.Name = Name;
            this.Region = Region;
            this.Weight = Weight;
        }
    }
}
