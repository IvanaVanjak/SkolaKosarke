using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Trening
    {
        //private static int ids = 0;
        private int id;
        private DateTime datum;
        //private GrupaTreninga grupa;
        private string grupa;
        private IList<Igrac> igraciNaTreningu;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }


        public virtual DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        //public virtual GrupaTreninga Grupa
        //{
        //    get { return grupa; }
        //    set { grupa = value; }
        //}

        public virtual string Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }

        public virtual IList<Igrac> IgraciNaTreningu
        {
            get { return igraciNaTreningu; }
            set { igraciNaTreningu = value; }
        }


        public Trening(DateTime inDatum, string inGrupa, List<Igrac> inIgraci)
        {
            //id = ids++;
            datum = inDatum;
            grupa = inGrupa;
            igraciNaTreningu = new List<Igrac>(inIgraci);
        }

        public virtual void dodajIgraca(Igrac inIgrac)
        {
            igraciNaTreningu.Add(inIgrac);
        }

        public Trening() {
        }
    }
}
