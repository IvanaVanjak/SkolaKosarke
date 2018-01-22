using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Statistika
    {
        //private static int ids = 0;
        private int id;
        private Igrac igrac;
        private Utakmica utakmica;
        private int postignutiKosevi;
        private int skokovi;
        private int asistencije;
        private int osobnePogreske;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual Igrac Igrac
        {
            get { return igrac; }
            set { igrac = value; }
        }


        public virtual Utakmica Utakmica
        {
            get { return utakmica; }
            set { utakmica = value; }
        }

        public virtual int PostignutiKosevi
        {
            get { return postignutiKosevi; }
            set { postignutiKosevi = value; }
        }

        public virtual int Skokovi
        {
            get { return skokovi; }
            set { skokovi = value; }
        }

        public virtual int Asistencije
        {
            get { return asistencije; }
            set { asistencije = value; }
        }

        public virtual int OsobnePogreske
        {
            get { return osobnePogreske; }
            set { osobnePogreske = value; }
        }

        public Statistika(Igrac inIgrac, Utakmica inUtakmica, int inPostignutiKosevi, int inSkokovi, int inAsistencije, int inOsobnePogreske)
        {
            //id = ids++;
            igrac = inIgrac;
            postignutiKosevi = inPostignutiKosevi;
            skokovi = inSkokovi;
            asistencije = inAsistencije;
            osobnePogreske = inOsobnePogreske;
            utakmica = inUtakmica;
        }

        public Statistika(Igrac inIgrac, Utakmica inUtakmica)
        {
            igrac = inIgrac;
            utakmica = inUtakmica;
            postignutiKosevi = 0;
            skokovi = 0;
            asistencije = 0;
            osobnePogreske = 0;
        }

        public Statistika() { }
    }
}
