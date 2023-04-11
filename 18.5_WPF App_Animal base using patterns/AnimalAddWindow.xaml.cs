using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using _18._5_ClassLibrary;

namespace _18._5_WPF_App_Animal_base_using_patterns
{
    public partial class AnimalAddWindow : Window
    {
        public AnimalAddWindow()
        { InitializeComponent(); }

        public AnimalAddWindow(IAnimal addNew) : this()
        {
            cancelBtn.Click += delegate { this.DialogResult = false; };
            okBtn.Click += delegate
            {
                addNew.Class = txtClass.Text;
                addNew.Name = txtName.Text;
                addNew.Region = txtRegion.Text;
                addNew.Weight = txtWeight.Text;
                this.DialogResult = !false;
            };
        }
    }
}
