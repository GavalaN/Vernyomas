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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
        
        internal static ObservableCollection<Adatok> AdatokLista = new System.Collections.ObjectModel.ObservableCollection<Adatok>();

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
            dtgAdatok.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
        }

        private void btnFelvetel_Click(object sender, RoutedEventArgs e)
        {
            Modosit modosit = new Modosit();
            modosit.Title = "Felvétel";
            modosit.ShowDialog();
        }

        private void btnModositas_Click(object sender, RoutedEventArgs e)
        {
            if (dtgAdatok.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kijelölve elem!","Figyelmeztetés",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            else
            {
                Modosit modosit = new Modosit(dtgAdatok.SelectedIndex);
                modosit.Title = "Módosítás";
                modosit.ShowDialog();
            }
            
        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            if (dtgAdatok.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs kijelölve elem!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (MessageBox.Show("Biztos ki szeretnéd törölni?", "Figyelmeztetés", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    AdatokLista.RemoveAt(dtgAdatok.SelectedIndex);
                }
            }
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"vernyomas.txt");
            sw.WriteLine("datum;ido;szisztoles;diasztoles;pulzus;tipus");
            foreach (var item in AdatokLista)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            MessageBox.Show("Sikeres Mentés!","Információ",MessageBoxButton.OK,MessageBoxImage.Asterisk);
        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
