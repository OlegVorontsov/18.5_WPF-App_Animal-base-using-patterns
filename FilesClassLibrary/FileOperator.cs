using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;

namespace FilesClassLibrary
{
    public class FileOperator
    {
        protected static string fileName;
        protected List<IAnimal> animalBase = new List<IAnimal>();

        public FileOperator(string FileName)
        {
            fileName = FileName;
        }

        public List<IAnimal> GetBaseFromFile()
        {
            animalBase.Clear();

            using(StreamReader sr = new StreamReader($"{fileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    switch (args[1])
                    {
                        case "Bird": animalBase.Add(new Bird(int.Parse(args[0]), args[1], args[2], args[3], args[4])); break;
                        case "Amphibian": animalBase.Add(new Amphibian(int.Parse(args[0]), args[1], args[2], args[3], args[4])); break;
                        case "Mammal": animalBase.Add(new Mammal(int.Parse(args[0]), args[1], args[2], args[3], args[4])); break;
                        default: animalBase.Add(new Unknown()); break;
                    }
                }
            }
            return animalBase;
        }

        public void PutBaseIntoFile(List<IAnimal> Base)
        {
            File.Delete($"{fileName}.txt");
            File.Create($"{fileName}.txt").Close();
            using(StreamWriter sw = new StreamWriter($"{fileName}.txt", true, Encoding.UTF8))
            {
                for (int i = 0; i < Base.Count; i++)
                {
                    string line = string.Empty;
                    line = $"{Base[i].ID}#" +
                           $"{Base[i].Class}#" +
                           $"{Base[i].Name}#" +
                           $"{Base[i].Region}#" +
                           $"{Base[i].Weight}";
                    sw.WriteLine(line);
                }
            }
        }
    }
}
