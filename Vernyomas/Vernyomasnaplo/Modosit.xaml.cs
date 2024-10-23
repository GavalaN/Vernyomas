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
using Vernyomas;

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

        int id = -1;

        public Modosit(int id)
        {
            InitializeComponent();
            this.id = id;
            Adatok adatok = MainWindow.AdatokLista[id];
            tbDatum.Text = adatok.Datum;
            tbIdo.Text = adatok.Ido;
            tbSzisztoles.Text = Convert.ToString(adatok.Szisztoles);
            tbDiasztoles.Text = Convert.ToString(adatok.Diaszteles);
            tbPulzus.Text = Convert.ToString(adatok.Pulzus);
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
            switch (Title)
            {
                case "Felvétel":
                    MainWindow.AdatokLista.Add(new Adatok(new string[] { tbDatum.Text, tbIdo.Text, tbSzisztoles.Text, tbDiasztoles.Text, tbPulzus.Text }));
                    break;
                case "Módosítás":
                    MainWindow.AdatokLista[id] = new Adatok(new string[] { tbDatum.Text, tbIdo.Text, tbSzisztoles.Text, tbDiasztoles.Text, tbPulzus.Text });
                    break;
                default:
                    break;
            }
            MessageBox.Show($"Sikeres {Title}!","Információ",MessageBoxButton.OK,MessageBoxImage.Asterisk);
        }
    }
}
