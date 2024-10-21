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

namespace Vernyomasnaplo
{
    /// <summary>
    /// Interaction logic for Modosit.xaml
    /// </summary>
    public partial class Modosit : Window
    {
        public Modosit()
        {
            InitializeComponent(); 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnOK.Content = Title;
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Title,"OK");
        }

        
    }
}
