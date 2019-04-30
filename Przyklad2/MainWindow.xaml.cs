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

namespace Przyklad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Models.PjatkDb conn;

        public MainWindow()
        {
            InitializeComponent();
            InitializeDb();
        }

        public void InitializeDb()
        {
            try
            {
                conn = new Models.PjatkDb();
                dg.ItemsSource = conn.Animals.Join(conn.AnimalTypes, animal => animal.IdAnimalType, animalType => animalType.IdAnimalType, (animal, animalType) => new
                {
                    OwnerId = animal.IdOwner,
                    AnimalName = animal.Name,
                    AnimalType = animalType.Name
                }).Join(conn.Owners, s => s.OwnerId, owner => owner.IdOwner, (s, owner) => new
                {
                    AnimalName = s.AnimalName,
                    AnimalType = s.AnimalType,
                    FirstName = owner.FirstName,
                    LastName = owner.LastName
                });
            } catch (Exception e)
            {
                Console.WriteLine("Error connecting to DB");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Open new window
            var window = new AddNewAnimal();
            window.Show();
        }
    }
}
