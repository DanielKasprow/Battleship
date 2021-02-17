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

namespace Daniel_Kasprów_lista_3
{
    /// <summary>
    /// Interaction logic for Okno.xaml
    /// </summary>
    /// 
    
    public partial class Okno : Window
    {
        Class1 cls;

        MainWindow mainwindow;

        public Okno()
        {
            InitializeComponent();
        }

        public Okno(MainWindow mainwindow) : this()
        {
            this.mainwindow = mainwindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt64(Textpesel.Text) > 9999999999 && Convert.ToInt64(Textpesel.Text) <= 99999999999)
                {
                    cls = new Class1(Textimie.Text, TextNazwisko.Text, Convert.ToInt64(Textpesel.Text));
                    MainWindow.parts.Add(cls);
                    mainwindow.refresh();
                    this.Hide();
                }
                else MessageBox.Show("zla dlugosc pesela");
            }
            catch
            {
                MessageBox.Show("Pesel musi byc liczba");
            }
        }

    }

}

