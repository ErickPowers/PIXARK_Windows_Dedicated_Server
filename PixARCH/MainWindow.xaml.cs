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

namespace PixARCH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bNewServer(object sender, RoutedEventArgs e)
        {
            var newForm = new NewServerFrm();
            newForm.Show(); 
            this.Close(); 
        }

        private void bModify(object sender, RoutedEventArgs e)
        {
            var newForm = new ModifyFrm(); 
            newForm.Show(); 
            this.Close(); 
        }

        private void bTroubleshoot(object sender, RoutedEventArgs e)
        {
            var newForm = new TroubleshootFrm(); 
            newForm.Show();
        }

        private void bExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }        
    }
}
