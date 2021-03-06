using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Adressbuch_Model;
using Adressbuch_ViewModel;

namespace Adressbuch_WPF
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void btnCollaps_Click(object sender, RoutedEventArgs e)
        {
            if (cdContacts.Width == new GridLength(200))
            {
                cdContacts.Width = new GridLength(0);
                this.Width -= 200;
            }
            else
            {
                cdContacts.Width = new GridLength(200);
                this.Width += 200;
            }
        }
    }
}

