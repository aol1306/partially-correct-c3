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

namespace PrzykladKolokwium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var con = new PjatkDb();
            var res = con.Student.Where(s => s.LastName.StartsWith("K")).ToList();
            con.Student.Add(new Student
            {
                IdStudent = 123,
                FirstName = "Abcdefghij",
                LastName = "K",
                Address = "ASDFASDF",
                IndexNumber = "s1928943",
                IdStudies = 1,
            });
            con.SaveChanges();
            var res2 = con.Student.Where(s => s.LastName.StartsWith("K")).ToList();
            int g = 0;
        }
    }
}
