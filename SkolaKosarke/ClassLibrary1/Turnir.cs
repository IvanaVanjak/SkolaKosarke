using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Turnir : Natjecanje
    {
        private int rang;
        private int brojKlubova;

        public virtual int BrojKlubova
        {
            get { return brojKlubova; }
            set { brojKlubova = value; }
        }

        public virtual int Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Turnir(string inNaziv, int inGodiste, int inRang, int inBrojKlubova) : base(inNaziv, inGodiste){
            rang = inRang;
            brojKlubova = inBrojKlubova;
        }

        public Turnir() { }
    }
}
