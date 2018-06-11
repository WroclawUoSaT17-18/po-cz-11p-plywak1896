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
using System.Threading;

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
        bool check = true;
        Pizza pizza1 = new Pizza();
        Pizza pizza2 = new Pizza();
        Pizza pizza3 = new Pizza();
        Pizza pizza4 = new Pizza();
        Pizza pizza5 = new Pizza();
        Pizza pizza6 = new Pizza();
        public int suma;


        private void button_con_Click(object sender, RoutedEventArgs e)
        {
            externalClient = new TcpClient();
            try
            {

                externalClient.Connect("127.0.0.1", 1024); // próba połączenia
                txt_sts.Text = "Połączono.";
                button_dis.Visibility = System.Windows.Visibility.Visible;
                button_con.Visibility = System.Windows.Visibility.Hidden;
                button_new.Visibility = System.Windows.Visibility.Visible;
                txa.Visibility = System.Windows.Visibility.Visible;
                cena.Visibility = System.Windows.Visibility.Visible;
                statyczny.Visibility = System.Windows.Visibility.Visible;

            }

            catch
            {

            }

        }

        private void button_send_Click(object sender, RoutedEventArgs e)
        {
            tekst = txb.Text + "Cena końcowa:" + cena.Text;
            try
            {
                BinaryWriter writer = new BinaryWriter(externalClient.GetStream()); // nowy strumień
                writer.Write(tekst);

                MessageBox.Show("Zamówienie zostało wysłane ;) ");









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
            try
            {
                BinaryWriter writer = new BinaryWriter(externalClient.GetStream());
                writer.Write("#!32");

                externalClient.Close();
                txt_sts.Text = "Brak połączenia.";
                button_dis.Visibility = System.Windows.Visibility.Hidden;
                button_send.Visibility = System.Windows.Visibility.Hidden;
                button_new.Visibility = System.Windows.Visibility.Hidden;
                button_con.Visibility = System.Windows.Visibility.Visible;
                button_clr.Visibility = System.Windows.Visibility.Hidden;
                button_1.Visibility = System.Windows.Visibility.Hidden;
                button_2.Visibility = System.Windows.Visibility.Hidden;
                button_3.Visibility = System.Windows.Visibility.Hidden;
                button_4.Visibility = System.Windows.Visibility.Hidden;
                button_5.Visibility = System.Windows.Visibility.Hidden;
                button_6.Visibility = System.Windows.Visibility.Hidden;
                txa.Visibility = System.Windows.Visibility.Hidden;
                cena.Visibility = System.Windows.Visibility.Hidden;
                statyczny.Visibility = System.Windows.Visibility.Hidden;
            }
            catch
            {

            }
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
            
            while (check)
            {
                
                pizza1.Nazwa = "Marysia";
                pizza1.Skladniki = "sos";
                pizza1.Cena = 10;
                pizza2.Nazwa = "Salami";
                pizza2.Skladniki = "sos, salami";
                pizza2.Cena = 12;
                pizza3.Nazwa = "Serowa";
                pizza3.Skladniki = "sos, ser";
                pizza3.Cena = 13;
                pizza4.Nazwa = "Wege";
                pizza4.Skladniki = "sos, warzywa";
                pizza4.Cena = 12;
                pizza5.Nazwa = "Mięsna";
                pizza5.Skladniki = "sos, salami, szynka";
                pizza5.Cena = 14;
                pizza6.Nazwa = "Hawajska";
                pizza6.Skladniki = "sos, szynka, ananas";
                pizza6.Cena = 12;
                //Idiotoodporny kawałek kodu 
                button_1.Content = pizza1.Nazwa;
                button_2.Content = pizza2.Nazwa;
                button_3.Content = pizza3.Nazwa;
                button_4.Content = pizza4.Nazwa;
                button_5.Content = pizza5.Nazwa;
                button_6.Content = pizza6.Nazwa;
                button_1.Visibility = System.Windows.Visibility.Visible;
                button_2.Visibility = System.Windows.Visibility.Visible;
                button_3.Visibility = System.Windows.Visibility.Visible;
                button_4.Visibility = System.Windows.Visibility.Visible;
                button_5.Visibility = System.Windows.Visibility.Visible;
                button_6.Visibility = System.Windows.Visibility.Visible;
                button_clr.Visibility = System.Windows.Visibility.Visible;
                button_new.Visibility = System.Windows.Visibility.Hidden;
                button_send.Visibility = System.Windows.Visibility.Visible;



                txa.Text = "Stworzono nowe zamówienie.";
                txb.Text = null;
                check = false;
            }
        }

        

        private void button_clr_Click(object sender, RoutedEventArgs e)
        {
                txb.Text = null;
                txc.Text = null;
                txd.Text = null;
                check = true;
                txa.Text = "Zamówienie usunięte.";
                suma = 0;
                cena.Text = suma.ToString();
                button_new.Visibility = System.Windows.Visibility.Visible;
                button_1.Visibility = System.Windows.Visibility.Hidden;
                button_2.Visibility = System.Windows.Visibility.Hidden;
                button_3.Visibility = System.Windows.Visibility.Hidden;
                button_4.Visibility = System.Windows.Visibility.Hidden;
                button_5.Visibility = System.Windows.Visibility.Hidden;
                button_6.Visibility = System.Windows.Visibility.Hidden;
                button_clr.Visibility = System.Windows.Visibility.Hidden;
                button_send.Visibility = System.Windows.Visibility.Hidden;
        }



        private void button_1_Click (object sender, RoutedEventArgs e)
        {

                txb.Text += pizza1.Nazwa + Environment.NewLine;
                txc.Text += pizza1.Skladniki + Environment.NewLine;
                txd.Text += pizza1.Cena + Environment.NewLine;
                suma += pizza1.Cena;
                cena.Text = suma.ToString();


        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            txb.Text += pizza2.Nazwa + Environment.NewLine;
            txc.Text += pizza2.Skladniki + Environment.NewLine;
            txd.Text += pizza2.Cena + Environment.NewLine;
            suma += pizza2.Cena;
            cena.Text = suma.ToString();
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            txb.Text += pizza3.Nazwa + Environment.NewLine;
            txc.Text += pizza3.Skladniki + Environment.NewLine;
            txd.Text += pizza3.Cena + Environment.NewLine;
            suma += pizza3.Cena;
            cena.Text = suma.ToString();
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            txb.Text += pizza4.Nazwa + Environment.NewLine;
            txc.Text += pizza4.Skladniki + Environment.NewLine;
            txd.Text += pizza4.Cena + Environment.NewLine;
            suma += pizza4.Cena;
            cena.Text = suma.ToString();

        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            txb.Text += pizza5.Nazwa + Environment.NewLine;
            txc.Text += pizza5.Skladniki + Environment.NewLine;
            txd.Text += pizza5.Cena + Environment.NewLine;
            suma += pizza5.Cena;
            cena.Text = suma.ToString();
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            txb.Text += pizza6.Nazwa + Environment.NewLine;
            txc.Text += pizza6.Skladniki + Environment.NewLine;
            txd.Text += pizza6.Cena + Environment.NewLine;
            suma += pizza6.Cena;
            cena.Text = suma.ToString();

        }

        
    }
}
