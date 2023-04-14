using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public class Mammal : SomeAnimal
    {
        public Mammal(int ID, string Class, string Name, string Region, string Weight) : base(ID, Class, Name, Region, Weight)
        {
        }
    }
}
