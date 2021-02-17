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
using System.Xml.Serialization;

namespace Daniel_Kasprów_lista_3
{

    partial class MainWindow : Window
    {
        public static List<Class1> parts = new List<Class1>();
        Class1 cls;
        Okno okno = new Okno();

        private int i = 0;

        public MainWindow()
        {
            InitializeComponent();
            okno = new Okno(this);
            refresh();
            if (parts.Count > 0)
            {
                parts[0].Writeimie(listaimie);
                parts[0].Writenazwisko(listanazwisko);
                parts[0].Writepesel(listapesel);
            }
        }

        public void refresh()
        {
            listaimie.Items.Clear();
            listanazwisko.Items.Clear();
            listapesel.Items.Clear();
           // i = 0;
            foreach(Class1 c in parts)
            {
                c.Writeimie(listaimie);
                c.Writenazwisko(listanazwisko);
                c.Writepesel(listapesel);
            }
          /*  try
            {
                do
                {
                    parts[i].Writeimie(listaimie);
                    parts[i].Writenazwisko(listanazwisko);
                    parts[i].Writepesel(listapesel);
                    i++;
                }
                while (i >= 0);
            }
            catch { }*/
        }

        public void savefile()
        {
            Stream stream = File.Create(Environment.CurrentDirectory + "\\myText.txt");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Class1>));

            xmlSer.Serialize(stream, parts);

            stream.Close();
        }

        public void openfile()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\myText.txt"))
            {
                savefile();
            }
            FileStream stream = File.OpenRead(Environment.CurrentDirectory + "\\myText.txt");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Class1>));

            parts = (List<Class1>)xmlSer.Deserialize(stream);
            stream.Close();
            refresh();
        }
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            okno.Show();
        }

        private void ButtonZapisz_Click(object sender, RoutedEventArgs e)
        {
            savefile();
        }

        private void ButtonWczytaj_Click(object sender, RoutedEventArgs e)
        {
            openfile();
        }
    }
}
