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
using System.Data.Entity;

namespace _18._5_WPF_App_Animal_base_using_patterns
{
    public partial class MainWindow : Window
    {
        static string fileName = "AnimalBase";
        
        static BaseSaver bs = new BaseSaver();
        static Repository data;
        static AnimalContext db = new AnimalContext();

        public MainWindow()
        {
            InitializeComponent();
            data = Repository.CreateRepository(fileName);
            animalList.ItemsSource = data.Animals;
        }
        //добавление животного через контекстное меню
        private void MenuItemAddAnimalClick(object sender, RoutedEventArgs e)
        {
            SomeAnimal add = AnimalFactory.GetAnimal(0, "Bird", "Name", "Region", "Weight");
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
            SomeAnimal animalSelected = (SomeAnimal)animalList.SelectedItem;
            data.Animals.Remove(animalSelected);
            data.fileOper.PutBaseIntoFile(data.Animals);
            animalList.Items.Refresh();
        }
        //сохранение в файле формата .txt
        private void txtSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var saveToTXT = new SaverTXT("BaseInTXT");
            bs.Save(data.Animals, saveToTXT);
        }
        //сохранение в файле формата .doc
        private void docSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var saveToDOC = new SaverDOC("BaseInDOC");
            bs.Save(data.Animals, saveToDOC);
        }
        //сохранение в файле формата .pdf
        private void pdfSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var saveToPDF = new SaverPDF("BaseInPDF");
            bs.Save(data.Animals, saveToPDF);
        }
        //сохранение в файле базы данных sql
        private void sqlSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in data.Animals)
            {
                db.AnimalsBaseSql.Add(item);
            }
            db.SaveChanges();
        }
    }
}
