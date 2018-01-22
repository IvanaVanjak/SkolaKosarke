using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Liga : Natjecanje
    {
        private int rang;
        private int brojBodova;
        private int brojKlubova;

        public virtual int Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public virtual int BrojBodova
        {
            get { return brojBodova; }
            set { brojBodova = value; }
        }

        public virtual int BrojKlubova
        {
            get { return brojKlubova; }
            set { brojKlubova = value; }
        }

        public Liga(string inNaziv, int inGodiste, int inRang, int inBrojBodova, int inBrojKlubova) :
            base(inNaziv, inGodiste) {
                rang = inRang;
                brojBodova = inBrojBodova;
                brojKlubova = inBrojKlubova;
        }
    
        public Liga() {}
    }
}
