using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public class SomeAnimal : IAnimal
    {
        public int ID { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Weight { get; set; }

        private static Random rand;
        private static int randomID()
        {
            return rand.Next(99);
        }

        public SomeAnimal(int ID, string Class, string Name, string Region, string Weight)
        {
            rand = new Random();
            if (ID == 0)
            {
                this.ID = randomID();
            }
            else
            {
                this.ID = ID;
            }
            this.Class = Class;
            this.Name = Name;
            this.Region = Region;
            this.Weight = Weight;
        }
    }
}
