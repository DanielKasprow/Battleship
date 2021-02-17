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

namespace Daniel_Kasprów_lista_3
{
    public class Class1
    {
        public string imie;
        public string nazwisko;

        public long pesel;

        public Class1()
        {
            imie = "...";
            nazwisko = "...";
            pesel = 0;
        }

        public Class1(string imie,string nazwisko,long pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public void Writeimie(ListBox lp)
        {
            lp.Items.Add(imie);
            //lp.Items.Add(nazwisko);
            //lp.Items.Add(pesel);
        }
        public void Writenazwisko(ListBox lp)
        {
            //lp.Items.Add(imie);
            lp.Items.Add(nazwisko);
            //lp.Items.Add(pesel);
        }
        public void Writepesel(ListBox lp)
        {
            //lp.Items.Add(imie);
            //lp.Items.Add(nazwisko);
            lp.Items.Add(pesel);
        }
        /*public override string ToString()
        {
            return "Imie: " + imie + "Nazwisko: " + nazwisko + "Pesel: " + pesel;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Class1 objAsPart = obj as Class1;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return pesel;
        }
        public bool Equals(Class1 other)
        {
            if (other == null) return false;
            return (this.pesel.Equals(other.pesel));
        }*/

    }
}
