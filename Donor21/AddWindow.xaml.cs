using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Donor21
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        Edinica addEdinica = new Edinica();
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            addEdinica.GUID_Donor = ID.ToString();
            addEdinica.Component = Component.ToString();
            //addEdinica.FK_Status = int.Parse(Status);
            addEdinica.Date_Sbora = DateTime.Parse(Date_Sbora.ToString());
            addEdinica.Date_Freeze = DateTime.Parse(Date_Fro.ToString());  
            addEdinica.Group = Group.ToString();
            //addEdinica.Rh = bool.Parse(Rh.ToString()); 

            MainWindow.bd.Edinica.Add(addEdinica);
            MainWindow.bd.SaveChanges();
            this.Close();
        }

        
    }
}
