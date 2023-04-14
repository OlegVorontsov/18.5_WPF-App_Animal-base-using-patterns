using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;
using Aspose.Pdf;

namespace FilesClassLibrary
{
    public class SaverPDF : ISaveBase
    {
        private string nameOfFile;
        private string path;
        public SaverPDF(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
            this.path = $"{NameOfFile}.pdf";
        }

        public void SaveBase(List<SomeAnimal> Base)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Document docPDF = new Document();

            Page page = docPDF.Pages.Add();

            for (int i = 0; i < Base.Count; i++)
            {
                string line = string.Empty;
                line = $"{Base[i].ID}#" +
                       $"{Base[i].Name}#" +
                       $"{Base[i].Region}#" +
                       $"{Base[i].Weight}";
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(line));
            }
            var outputFileName = System.IO.Path.Combine(path);

            docPDF.Save(outputFileName);
        }
    }
}
