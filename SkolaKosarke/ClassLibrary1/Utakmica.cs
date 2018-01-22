using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Utakmica
    {
        //private static int ids = 0;
        private int id;
        private DateTime datum;
        private ProtivnickiKlub protivnickiKlub;
        private int brojPostignutihKoseva;
        private int brojPrimljenihKoseva;
        private IList<Statistika> statistikeIgraca;

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

        public virtual ProtivnickiKlub ProtivnickiKlub {
            get { return protivnickiKlub; }
            set { protivnickiKlub = value; }
        }

        public virtual int BrojPostignutihKoseva
        {
            get { return brojPostignutihKoseva; }
            set { brojPostignutihKoseva = value; }
        }

        public virtual int BrojPrimljenihKoseva
        {
            get { return brojPrimljenihKoseva; }
            set { brojPrimljenihKoseva = value; }
        }

        public virtual IList<Statistika> StatistikeIgraca
        {
            get { return statistikeIgraca; }
            set { statistikeIgraca = value; }
        }

        public Utakmica(DateTime inDatum, ProtivnickiKlub inProtivnickiKlub, int inBrojPostignuthKoseva, int inBrojPrimljenihKoseva, List<Statistika> inStatistike) {
            //id = ids++;
            datum = inDatum;
            protivnickiKlub = inProtivnickiKlub;
            brojPostignutihKoseva = inBrojPostignuthKoseva;
            brojPrimljenihKoseva = inBrojPostignuthKoseva;
            statistikeIgraca = new List<Statistika>(inStatistike);
        }

        public Utakmica(DateTime inDatum, ProtivnickiKlub inProtivnickiKlub, int inBrojPostignuthKoseva, int inBrojPrimljenihKoseva)
        {
            //id = ids++;
            datum = inDatum;
            protivnickiKlub = inProtivnickiKlub;
            brojPostignutihKoseva = inBrojPostignuthKoseva;
            brojPrimljenihKoseva = inBrojPrimljenihKoseva;
            statistikeIgraca = new List<Statistika>();
        }

        public virtual void dodajStatistiku(Statistika inStatistika)
        {
            statistikeIgraca.Add(inStatistika);
        }

        public Utakmica() {
            statistikeIgraca = new List<Statistika>();
        }
    
    }
}
