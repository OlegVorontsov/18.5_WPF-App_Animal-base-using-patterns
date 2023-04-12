using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18._5_ClassLibrary;

namespace FilesClassLibrary
{
    public class BaseSaver
    {
        public ISaveBase Mode { get; set; }
        public List<IAnimal> Base { get; set; }
        public BaseSaver()
        {
            //this.Mode = FileFormat;
        }
        public void Save(List<IAnimal> BaseToSave, ISaveBase FileFormat)
        {
            this.Mode = FileFormat;
            this.Base = BaseToSave;
            Mode.SaveBase(BaseToSave);
        }
    }
}
