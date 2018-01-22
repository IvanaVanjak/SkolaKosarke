using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Adresa
    {
        private string ulica;
        private string kucniBroj;
        private long postanskiBroj;
        private string mjesto;
        private string drzava;

        public virtual string Ulica
        {
            get { return ulica; }
            set { ulica = value; }
        }

        public virtual string KucniBroj
        {
            get { return kucniBroj; }
            set { kucniBroj = value; }
        }

        public virtual long PostanskiBroj
        {
            get { return postanskiBroj; }
            set { postanskiBroj = value; }
        }

        public virtual string Mjesto
        {
            get { return mjesto; }
            set { mjesto = value; }
        }

        public virtual string Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }

        public Adresa(string inUlica, string inKucniBroj, long inPostanskiBroj, string inMjesto, string inDrzava) {
            ulica = inUlica;
            kucniBroj = inKucniBroj;
            postanskiBroj = inPostanskiBroj;
            mjesto = inMjesto;
            drzava = inDrzava;
        }

        public Adresa() {}
    }
}
