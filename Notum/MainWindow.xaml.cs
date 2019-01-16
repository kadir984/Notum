using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            ClassLibrary.DbIslem.CbDoldur(cbOgrenciAra, "Ogrenci", "AdSoyad");
            ClassLibrary.DbIslem.CbDoldur(cbDersAra, "Ders", "DersAdi");
            ClassLibrary.DbIslem.Ara(dgKayit, "Notlar");
        }

        public void btnOgrenciKyt_Click(object sender, RoutedEventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
            this.Close();
        }

        public void btnDersKyt_Click(object sender, RoutedEventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
            this.Close();
        }

        private void BtnNotKyt_Click(object sender, RoutedEventArgs e)
        {
            ClassLibrary.DbIslem.Ekle("Notlar", "OgrenciId,DersId,Notu,Aciklama",cbOgrenci.SelectedIndex.ToString() + ',' + cbDers.SelectedIndex.ToString() + ',' + tbxNot.Text + ',' + "'" + tbxAciklama.Text.ToString() + "'");
            ClassLibrary.DbIslem.Ara(dgKayit, "Notlar");
        }
    }
}
 