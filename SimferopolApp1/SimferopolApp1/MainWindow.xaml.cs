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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.IO;


namespace SimferopolApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

             
 
            zastavka_but.Visibility = Visibility.Visible;            
        }
        private void zastavka_but_Click(object sender, RoutedEventArgs e)
        {
            zastavka.Source = new BitmapImage(new Uri("image/приветствие.jpg", UriKind.Relative));

            buttonrun.Visibility = Visibility.Visible;
        }

    private void buttonrun_Click(object sender, RoutedEventArgs e)
        {
            
            zastavka_but.Visibility = Visibility.Hidden;
            buttonrun.Visibility = Visibility.Hidden;
            weather_but.Visibility = Visibility.Visible;
            news_but.Visibility = Visibility.Visible;
            food_but.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
            button7.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Visible;
            button9.Visibility = Visibility.Visible;


            //var animation = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(1));
            //animation.Completed += (s, _) => zastavka_but.Visibility = Visibility.Hidden;
            //BeginAnimation(UIElement.OpacityProperty, animation);
        }
       
        
           

       

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon(@"C: \Users\kerim\source\repos\SimferopolApp1\SimferopolApp1\bin\Debug\city_86340.ico.ico");
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipText = "Нажми чтобы открыть";
            notifyIcon.Click += NotifyIcon_Click;

            Window1 window1 = new Window1();
            double workHeight = SystemParameters.WorkArea.Height;
            double workWidth = SystemParameters.WorkArea.Width;
            window1.Top = (workHeight / 2 + 2);
            window1.Left = (workWidth - window1.Width);
            window1.Show();
        }

        //public void pogoda()
        //{
        //    string[,] pogoda_mass = new string[12, 4];

        //    XmlDocument xml = new XmlDocument();

        //    xml.Load("http://www.eurometeo.ru/russia/krym/simferopol/export/xml/data/");

        //    int a, b;

        //    a = 1;

        //    b = 1;



        //    foreach (XmlNode n in xml.SelectNodes("/weather/city/step"))

        //    {
                

        //        pogoda_mass[a, b] = n.SelectSingleNode("datetime").InnerText;

        //        a++;


        //        pogoda_mass[a, b] = n.SelectSingleNode("pressure").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("temperature").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("humidity").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("cloudcover").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("windspeed").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("windgust").InnerText;

        //        a++;

        //        pogoda_mass[a, b] = n.SelectSingleNode("winddir").InnerText;

        //        a = 1;

        //        b++;
        //        if (b == 4)
        //        {
        //            break;
        //        }
        //    }


        //}
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Window1 window1 = new Window1();
            double workHeight = SystemParameters.WorkArea.Height;
            double workWidth = SystemParameters.WorkArea.Width;
            window1.Top = (workHeight / 2 + 2);
            window1.Left = (workWidth - window1.Width);
            window1.Show();

            string[,] pogoda_mass = new string[12, 4];

            XmlDocument xml = new XmlDocument();

            xml.Load("http://www.eurometeo.ru/russia/krym/simferopol/export/xml/data/");

            int a, b;

            a = 1;

            b = 1;



            foreach (XmlNode n in xml.SelectNodes("/weather/city/step"))

            {


                pogoda_mass[a, b] = n.SelectSingleNode("datetime").InnerText;

                a++;


                pogoda_mass[a, b] = n.SelectSingleNode("pressure").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("temperature").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("humidity").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("cloudcover").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("windspeed").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("windgust").InnerText;

                a++;

                pogoda_mass[a, b] = n.SelectSingleNode("winddir").InnerText;

                a = 1;

                b++;
                if (b == 4)
                {
                    break;
                }


            }

            window1.pogoda_date.Text = "Дата: " + pogoda_mass[1, 1].Substring(0, 10) + " Время:" + pogoda_mass[1, 1].Substring(10);
            window1.pogoda_cloud.Text = "Густота облаков: " + pogoda_mass[5, 1] + " %";
            window1.pogoda_temp.Text = "Температура: " + pogoda_mass[3, 1] + " C°";
            window1.pogoda_wind.Text = "Скорость ветра: " + pogoda_mass[6, 1] + " м/с";

           

            window1.pogodaimage.Visibility = Visibility.Hidden;
            
        }           
    }
}



