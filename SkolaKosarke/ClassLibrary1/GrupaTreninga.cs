using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class GrupaTreninga
    {
        private int id;
        private string nazivGrupe;
        private IList<Igrac> igraciUGrupi;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual string NazivGrupe
        {
            get { return nazivGrupe; }
            set { nazivGrupe = value; }
        }

        public GrupaTreninga(string inGrupaTreninga)
        {
            nazivGrupe = inGrupaTreninga;
            igraciUGrupi = new List<Igrac>();
        }

        public GrupaTreninga() {
            igraciUGrupi = new List<Igrac>();
        }

        public virtual IList<Igrac> IgraciUGrupi
        {
            get { return igraciUGrupi; }
            set { igraciUGrupi = value; }
        }

        public virtual void dodajIgraca(Igrac inIgrac)
        {
            igraciUGrupi.Add(inIgrac);
        }

    }
}
