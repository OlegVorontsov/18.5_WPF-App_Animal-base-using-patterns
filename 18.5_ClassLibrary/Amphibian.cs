﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public class Amphibian : Bird
    {
        public Amphibian(int ID, string Class, string Name, string Region, string Weight) : base(ID, Class, Name, Region, Weight)
        {
        }
    }
}
