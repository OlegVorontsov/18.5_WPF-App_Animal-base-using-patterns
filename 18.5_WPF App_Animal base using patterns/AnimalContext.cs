using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;

namespace _18._5_WPF_App_Animal_base_using_patterns
{
    class AnimalContext : DbContext
    {
        public AnimalContext() : base("DbConnection") { }

        public DbSet<SomeAnimal> AnimalsBaseSql { get; set; }
    }
}
