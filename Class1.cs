using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    internal class Class1
    {
        string ime, prezime, uloge, aktivnost;

        public Class1(string Ime, string Prezime, string Uloge)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.uloge = Uloge;
        }

        public override string ToString()
        {
            string ispis = "ime: " + this.Ime
                + "\tprezime: " + this.Prezime
                + "\tuloge: " + this.uloge
                + "\taktivnost: " + this.aktivnost
                + "\r\n";
            return ispis;
        }


        public string Ime { get => Ime; set => Ime = value; }
        public string Prezime { get => Prezime; set => Prezime = value; }
        public string Uloge { get => Uloge; set => Uloge = value; }
        public string Aktivnost { get => Aktivnost; set => Aktivnost = value; }
    }
}
