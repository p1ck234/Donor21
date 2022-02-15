using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Donor21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static Model1 bd = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            bd.Edinica.Load();
            dtgFromBase.ItemsSource = bd.Edinica.Local;

        }

        private void bldRadio_Checked(object sender, RoutedEventArgs e)
        {
            dtgFromBase.ItemsSource = bd.Edinica.Local.Where(x => x.Component == "Blood");
        }

        private void plzRadio_Checked(object sender, RoutedEventArgs e)
        {
            dtgFromBase.ItemsSource = bd.Edinica.Local.Where(x => x.Component == "Plazma");
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow();   
            this.Close();
            add.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
