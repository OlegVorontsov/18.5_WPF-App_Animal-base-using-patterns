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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _18._5_ClassLibrary;
using FilesClassLibrary;

namespace _18._5_WPF_App_Animal_base_using_patterns
{
    public partial class MainWindow : Window
    {
        static string fileName = "AnimalBase";
        static Repository data;

        public MainWindow()
        {
            InitializeComponent();
            data = Repository.CreateRepository(fileName);
            animalList.ItemsSource = data.Animals;
        }
        //добавление животного через контекстное меню
        private void MenuItemAddAnimalClick(object sender, RoutedEventArgs e)
        {
            IAnimal add = AnimalFactory.GetAnimal(0, "Bird", "Name", "Region", "Weight");
            AnimalAddWindow addWind = new AnimalAddWindow(add);
            addWind.ShowDialog();
            if (addWind.DialogResult.Value)
            {
                data.Animals.Add(add);
                data.fileOper.PutBaseIntoFile(data.Animals);
                data.Animals = data.fileOper.GetBaseFromFile();
                animalList.Items.Refresh();
            }
        }
        //удаление животного через контекстное меню
        private void MenuItemDeleteAnimalClick(object sender, RoutedEventArgs e)
        {
            IAnimal animalSelected = (IAnimal)animalList.SelectedItem;
            data.Animals.Remove(animalSelected);
            data.fileOper.PutBaseIntoFile(data.Animals);
            animalList.Items.Refresh();
        }
    }
}
