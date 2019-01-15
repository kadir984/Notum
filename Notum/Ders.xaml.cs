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

namespace Notum
{
    /// <summary>
    /// Interaction logic for Ders.xaml
    /// </summary>
    public partial class Ders : Window
    {
        public Ders()
        {
            InitializeComponent();
        }

        private void btnDersKyt_Click(object sender, RoutedEventArgs e)
        {
            ClassLibrary.DbIslem.Ekle("Ders","DersAdi",tbxDersAdi.Text);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();


        }
    }
}
