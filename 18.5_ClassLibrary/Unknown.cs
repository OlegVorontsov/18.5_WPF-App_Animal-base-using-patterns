using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public class Unknown : IAnimal
    {
        public int ID { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Weight { get; set; }

        public Unknown ()
        {
            this.ID = 00;
            this.Class = "undefined";
            this.Name = "undefined";
            this.Region = "undefined";
            this.Weight = "undefined";
        }
    }
}
