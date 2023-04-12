using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_ClassLibrary
{
    public interface IAnimal
    {
        [Key]
        int ID { get; set; }
        string Class { get; set; }
        string Name { get; set; }
        string Region { get; set; }
        string Weight { get; set; }
    }
}
