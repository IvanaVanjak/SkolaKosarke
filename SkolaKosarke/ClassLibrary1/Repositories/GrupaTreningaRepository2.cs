using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public class GrupaTreningaRepository2 : IGrupaTreningaRepository
    {
        private static GrupaTreningaRepository2 instance = null;

        List<GrupaTreninga> grupe = new List<GrupaTreninga>();

        private GrupaTreningaRepository2()
        {
            GrupaTreninga g = new GrupaTreninga("Mlađa");
            grupe.Add(g);
            g = new GrupaTreninga("Starija");
            grupe.Add(g);
        }

        public static GrupaTreningaRepository2 getInstance()
        {
            if (instance == null)
                instance = new GrupaTreningaRepository2();

            return instance;
        }

        public int Count()
        {
            return grupe.Count;
        }

        public void dodajGrupu(GrupaTreninga grupa)
        {
            if (grupa.NazivGrupe == "")
            {
                throw new GrupaTreningaPraznoImeExists();
            }
            foreach (GrupaTreninga g in grupe)
            {
                if (g.NazivGrupe == grupa.NazivGrupe)
                {
                    throw new GrupaTreningaAlreadyExists();
                }
            }
            grupe.Add(grupa);
        }

        public List<GrupaTreninga> dohvatiSveGrupe()
        {
            return new List<GrupaTreninga>(grupe);
        }

        public void dodajIgracaUGrupu(Igrac igrac, GrupaTreninga grupa)
        {
            foreach (GrupaTreninga g in grupe)
            {
                foreach (Igrac i in g.IgraciUGrupi)
                {
                    if (i.OIB == igrac.OIB)
                    {
                        g.IgraciUGrupi.Remove(i);
                        break;
                    }
                }
                if (g.NazivGrupe == grupa.NazivGrupe)
                {
                    grupa.dodajIgraca(igrac);
                }
            }
        }
    }
}
