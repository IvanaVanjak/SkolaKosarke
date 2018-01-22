using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class ProtivnickiKlub
    {
        private int id;
        private string nazivKluba;
        private string brojTelefona;
        private Adresa adresa;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual string NazivKluba
        {
            get { return nazivKluba; }
            set { nazivKluba = value; }
        }

        public virtual string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        public virtual Adresa Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public ProtivnickiKlub(string inNaziv, string inBrojTelefona, Adresa inAdresa) {
            nazivKluba = inNaziv;
            brojTelefona = inBrojTelefona;
            adresa = inAdresa;
        }

        public ProtivnickiKlub() { }
    }
}
