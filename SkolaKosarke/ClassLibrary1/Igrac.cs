using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Igrac
    {
        private int id;
        private string ime;
        private string prezime;
        private string nadimak;
        private string oib;
        private DateTime datumRodenja;
        private string imeRoditelja;
        private string prezimeRoditelja;
        private string brojTelefona;

        public virtual int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public virtual string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public virtual string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }


        public virtual string Nadimak
        {
            get { return nadimak; }
            set { nadimak = value; }
        }

        public virtual string OIB
        {
            get { return oib; }
            set { oib = value; }
        }

        public virtual string ImeRoditelja
        {
            get { return imeRoditelja; }
            set { imeRoditelja = value; }
        }

        public virtual string PrezimeRoditelja
        {
            get { return prezimeRoditelja; }
            set { prezimeRoditelja = value; }
        }

        public virtual DateTime DatumRodenja
        {
            get { return datumRodenja; }
            set { datumRodenja = value; }
        }

        public virtual string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        public Igrac(string inIme, string inPrezime, string inNadimak, string inOib, DateTime inDatumRodenja, string inImeRoditelja, string inPrezimeRoditelja,
             string inBrojTelefona)
        {
            ime = inIme;
            prezime = inPrezime;
            nadimak = inNadimak;
            oib = inOib;
            imeRoditelja = inImeRoditelja;
            prezimeRoditelja = inPrezimeRoditelja;
            datumRodenja = inDatumRodenja;
            brojTelefona = inBrojTelefona;
        }

        public Igrac(string inIme, string inPrezime, string inOib, DateTime inDatumRodenja, string inImeRoditelja, string inPrezimeRoditelja,
             string inBrojTelefona)
        {
            ime = inIme;
            prezime = inPrezime;
            nadimak = "-";
            oib = inOib;
            imeRoditelja = inImeRoditelja;
            prezimeRoditelja = inPrezimeRoditelja;
            datumRodenja = inDatumRodenja;
            brojTelefona = inBrojTelefona;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Nadimak;
        }

        public Igrac() { }
    }
}
