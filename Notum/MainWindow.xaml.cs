using System;
using System.Collections.Generic;
using System.Data;
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

namespace Notum
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
     
        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            ClassLibrary.DbIslem.CbDoldur(cbOgrenci, "Ogrenci", "AdSoyad");
            ClassLibrary.DbIslem.CbDoldur(cbDers, "Ders", "DersAdi");
        }

        public void btnOgrenciKyt_Click(object sender, RoutedEventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
            
        }

        public void btnDersKyt_Click(object sender, RoutedEventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
        }

        
    }
}
