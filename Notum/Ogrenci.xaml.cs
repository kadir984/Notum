﻿using System;
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
    /// Interaction logic for Ogrenci.xaml
    /// </summary>
    public partial class Ogrenci : Window
    {
        MainWindow _mainWindow;
        public Ogrenci(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void btnOgrenciKayit_Click(object sender, RoutedEventArgs e)
        {
            ClassLibrary.DbIslem.Ekle("Ogrenci", "AdSoyad", tbxOgrenciAdSoyad.Text);
            MainWindow mainWindow = new MainWindow();
            //mainWindow.Refresh();
            _mainWindow.cbOgrenci
            this.Close();//!!!!
        }

        private void Window_Closed(object sender, EventArgs e)
        {
        
        }
    }
}
