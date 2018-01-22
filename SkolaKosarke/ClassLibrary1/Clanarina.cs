using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Clanarina
    {
        private int id;
        private int mjesec;
        private int godina;
        private int iznos;
        private IList<Igrac> platiliClanarinu;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual int Mjesec {
            get { return mjesec; }
            set { mjesec = value; }
        }

        public virtual int Godina
        {
            get { return godina; }
            set { godina = value; }
        }

        public virtual int Iznos
        {
            get { return iznos; }
            set { iznos = value; }
        }

        public virtual IList<Igrac> PlatiliClanarinu
        {
            get { return platiliClanarinu; }
            set { platiliClanarinu = value; }
        }

        public Clanarina(int inMjesec, int inGodina, int inIznos) {
            mjesec = inMjesec;
            godina = inGodina;
            iznos = inIznos;
            platiliClanarinu = new List<Igrac>();
        }

        public Clanarina() {
            platiliClanarinu = new List<Igrac>();
        }

        public virtual void dodajIgraca(Igrac inIgrac)
        {
            platiliClanarinu.Add(inIgrac);
        }
       
    }
}
