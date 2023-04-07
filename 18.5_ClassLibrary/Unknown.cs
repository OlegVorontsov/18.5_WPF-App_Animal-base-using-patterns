﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    class Unknown : IAnimal
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Weight { get; set; }

        public Unknown ()
        {
            this.Name = "undefined";
            this.Region = "undefined";
            this.Weight = "undefined";
        }
    }
}
