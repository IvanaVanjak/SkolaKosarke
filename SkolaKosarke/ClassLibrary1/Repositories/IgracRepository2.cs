
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories 
{
   public class IgracRepository2 : IIgracRepository
    {
        private static IgracRepository2 instance = null;

        List<Igrac> igraci = new List<Igrac>();


        private IgracRepository2()
        {
            Igrac i = new Igrac("Toni", "Vanjak", "Tonks","12345678912", new DateTime(2002, 7 ,28), "Ivan", "Vanjak", "098111111");
            igraci.Add(i);
            i = new Igrac("David", "Dijan", "Daki", "11122233311", new DateTime(2002, 8, 3), "Marko", "Dijan", "0982222222");
            igraci.Add(i);
            i = new Igrac("Roko", "Rogoznica", "Role","22299988877", new DateTime(2002, 10, 13), "Damir", "Rogoznica", "0919999999");
            igraci.Add(i);
            i = new Igrac("Jakov", "Klarić", "Jakša","55577766633", new DateTime(2001, 1, 13), "Marin", "Klarić", "0995557774");
            igraci.Add(i);
            i = new Igrac("Ivan", "Smolić", "Ive", "22229999444", new DateTime(2001, 7, 8), "Josip", "Smolić", "0954444447");
            igraci.Add(i);
            i = new Igrac("Mate", "Pavić", "Matko", "33388833777", new DateTime(2004, 9, 22), "Ante", "Pavić", "0951234564");
            igraci.Add(i);
            i = new Igrac("Luka", "Klarić", "Luki", "87687654344", new DateTime(2004, 5, 28), "Marin", "Klarić", "0951234564");
            igraci.Add(i);
            
        }

        public static IgracRepository2 getInstance()
        {
            if (instance == null)
                instance = new IgracRepository2();

            return instance;
        }

        public int Count()
        {
            return igraci.Count;
        }

        public void dodajIgraca(Igrac igrac)
        {
            if (igrac.Ime == "" || igrac.Prezime == "" || igrac.ImeRoditelja == ""
                || igrac.PrezimeRoditelja == "" || igrac.BrojTelefona == "") {
                    throw new IgracPraznoPolje();
            }
            try
            {
                Convert.ToInt64(igrac.OIB);
            }
            catch (Exception)
            {
                throw new OIBFormatException();
            }
            if (igrac.OIB.ToString().Length != 11)
            {
                throw new OIBLengthException();
            }
            foreach (Igrac i in igraci)
            {
                if (i.OIB == igrac.OIB)
                {
                    throw new IgracOIBAlreadyExists();
                }
                if (i.Ime == igrac.Ime && i.Prezime == igrac.Prezime && i.Nadimak == igrac.Nadimak) {
                    throw new IgracNadimakAlreadyExists();
                }
            }
            igraci.Add(igrac);           
        }

        public IList<Igrac> dohvatiSveIgrace()
        {
            return new List<Igrac>(igraci);
        }

        public IList<Igrac> dohvatiIgraceMladeIliJednake(int godiste) {
            List<Igrac> igr = new List<Igrac>();

            foreach (Igrac i in igraci) {
                if (i.DatumRodenja.Year >= godiste) {
                    igr.Add(i);
                }
            }
            return igr;
        }


        public Igrac dohvatiIgracePoOIBu(string oib)
        {
            foreach (Igrac i in igraci)
            {
                if (i.OIB.ToString() == oib)
                {
                    Igrac igr = i;
                    return igr;
                }
            }
            throw new IgracDoesntExists();
        }
    }
}
