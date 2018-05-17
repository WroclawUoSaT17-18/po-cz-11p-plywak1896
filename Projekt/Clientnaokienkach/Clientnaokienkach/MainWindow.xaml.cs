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
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.ComponentModel;

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
        TcpClient externalClient = new TcpClient(); // tworzymy klienta


        private void button_con_Click(object sender, RoutedEventArgs e)
        {
            externalClient = new TcpClient();
            try
            {

                externalClient.Connect("127.0.0.1", 1024); // próba połączenia
                txt_sts.Text = "Połączono.";

            }

            catch
            {

            }

        }

        private void button_send_Click(object sender, RoutedEventArgs e)
        {
            tekst = txb.Text;
            try
            {
                BinaryWriter writer = new BinaryWriter(externalClient.GetStream()); // nowy strumień
                writer.Write(tekst);


            }

            catch
            {
                txt_sts.Text = "Brak połączenia.";

            }

        }

        private void txt_dane_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_dis_Click(object sender, RoutedEventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(externalClient.GetStream());
            writer.Write("#!32");

            externalClient.Close();
            txt_sts.Text = "Brak połączenia.";

        }

        void DataWindow_Closing(object sender, CancelEventArgs e)
        {

            try
            {
                BinaryWriter writer = new BinaryWriter(externalClient.GetStream());
                writer.Write("#!32");
            }

            catch
            { }
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            txa.Text = "Stworzono nowe zamówienie.";
            txb.Text = null;
            Pizza pizza1 = new Pizza();
            pizza1.Nazwa = "Marysia";
            pizza1.Skladniki = "sos";
            Pizza pizza2 = new Pizza();
            pizza2.Nazwa = "Salami";
            pizza2.Skladniki = "sos, salami";

            combobox1.Items.Add(pizza1.Nazwa + " " + pizza1.Nazwa);
       
            combobox1.Items.Add(pizza2);
            combobox1.Items.Add("Marysia");
            combobox1.Items.Add("Salami");




        }

        private void _1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            txb.Text = (combobox1.Text);
            
        }
    }
}
