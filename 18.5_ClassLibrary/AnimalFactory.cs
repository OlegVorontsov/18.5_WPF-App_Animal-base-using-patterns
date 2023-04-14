using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public class AnimalFactory
    {
        public static SomeAnimal GetAnimal(int ID,
                                        string Class,
                                        string Name,
                                        string Region,
                                        string Weight)
        {
            switch (Class)
            {
                case "Bird": return new Bird(ID, Class, Name, Region, Weight);
                case "Amphibian": return new Amphibian(ID, Class, Name, Region, Weight);
                case "Mammal": return new Mammal(ID, Class, Name, Region, Weight);
                default: return new Unknown(ID, Class, Name, Region, Weight);
            }
        }
    }
}
