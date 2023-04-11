using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;

namespace FilesClassLibrary
{
    public class Repository
    {
        public List<IAnimal> Animals;
        protected static string baseName;
        public FileOperator fileOper;

        public Repository(string Name)
        {
            baseName = Name;
            fileOper = new FileOperator(Name);
            Animals = fileOper.GetBaseFromFile();
        }

        public static Repository CreateRepository(string Name)
        {
            return new Repository(Name);
        }

        public void AddAnimal(IAnimal Animal)
        {
            Animals.Add(Animal);
        }
    }
}
