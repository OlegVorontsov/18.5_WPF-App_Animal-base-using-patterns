using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;

namespace FilesClassLibrary
{
    public class SaverDOC : ISaveBase
    {
        private string nameOfFile;
        private string path;
        public SaverDOC(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
            this.path = $"{NameOfFile}.doc";
        }

        public void SaveBase(List<SomeAnimal> Base)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                for (int i = 0; i < Base.Count; i++)
                {
                    string line = string.Empty;
                    line = $"{Base[i].ID}#" +
                           $"{Base[i].Name}#" +
                           $"{Base[i].Region}#" +
                           $"{Base[i].Weight}";
                    sw.WriteLine(line);
                }
            }
        }
    }
}
