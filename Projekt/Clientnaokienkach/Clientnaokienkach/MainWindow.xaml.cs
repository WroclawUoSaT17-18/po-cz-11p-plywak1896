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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Clientnaokienkach
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();

        }

        public string tekst;
        TcpClient externalClient = new TcpClient(); // tworzymy zewnętrznego klienta
        

        private void button_con_Click(object sender, RoutedEventArgs e)
        {
            
            externalClient.Connect("127.0.0.1", 1024); // próba połączenia

            


        }

        private void button_send_Click(object sender, RoutedEventArgs e)
        {
            tekst = (txb.Text); 
            BinaryWriter writer = new BinaryWriter(externalClient.GetStream()); // nowy strumień
            writer.Write(tekst);

        }

        private void txt_dane_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
