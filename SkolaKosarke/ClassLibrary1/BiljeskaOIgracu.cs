using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class BiljeskaOIgracu
    {
        private int id;
        private Igrac igrac;
        private DateTime datum;
        private string biljeska;

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

        public virtual Igrac Igrac
        {
            get { return igrac; }
            set { igrac = value; }
        }

        public virtual string Biljeska
        {
            get { return biljeska; }
            set { biljeska = value; }
        }

        public BiljeskaOIgracu(Igrac inIngrac, DateTime inDatum, string inBiljeska)
        {
            igrac = inIngrac;
            datum = inDatum;
            biljeska = inBiljeska;
        }

        public BiljeskaOIgracu() { }
    }
}
