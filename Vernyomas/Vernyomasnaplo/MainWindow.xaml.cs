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
using System.IO;
using System.Collections.ObjectModel;
using Vernyomas;

namespace Vernyomasnaplo
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
        
        static ObservableCollection<Adatok> AdatokLista = new System.Collections.ObjectModel.ObservableCollection<Adatok>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"vernyomas.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                AdatokLista.Add(new Adatok(temp));
            }
            sr.Close();
            dtgAdatok.ItemsSource = AdatokLista;
        }

        private void btnFelvetel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnModositas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
