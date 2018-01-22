using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public abstract class Natjecanje
    {
        //private static int ids = 0;
        private int id;
        private string naziv;
        private int godiste;
        private IList<Utakmica> utakmice;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual IList<Utakmica> Utakmice
        {
            get { return utakmice; }
            set { utakmice = value; }
        }

        public virtual string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public virtual int Godiste
        {
            get { return godiste; }
            set { godiste = value; }
        }

        protected Natjecanje(string inNaziv, int inGodiste)
        {
            //id = ids++;
            naziv = inNaziv;
            godiste = inGodiste;
            utakmice = new List<Utakmica>();
        }

        public Natjecanje() {
            utakmice = new List<Utakmica>();
        }

        public virtual void dodajUtakmicu(Utakmica inUtakmica)
        {
            utakmice.Add(inUtakmica);
        }
    }
}
