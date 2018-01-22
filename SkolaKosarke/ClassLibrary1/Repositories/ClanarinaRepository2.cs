using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public class ClanarinaRepository2 : IClanarinaRepository
    {
        private static ClanarinaRepository2 instance = null;

        List<Clanarina> clanarine = new List<Clanarina>();

        private ClanarinaRepository2()
        {
            Clanarina c = new Clanarina(10, 2014, 120);
            clanarine.Add(c);
            c = new Clanarina(11, 2014, 120);
            clanarine.Add(c);
            c = new Clanarina(12, 2014, 120);
            clanarine.Add(c);
            c = new Clanarina(1, 2015, 120);
            clanarine.Add(c);
        }

        public static ClanarinaRepository2 getInstance()
        {
            if (instance == null)
                instance = new ClanarinaRepository2();

            return instance;
        }

        public int Count()
        {
            return clanarine.Count;
        }

        public void dodajClanarinu(Clanarina c)
        {
            foreach (Clanarina clanarina in clanarine)
            {
                if (clanarina.Godina == c.Godina && clanarina.Mjesec == c.Mjesec)
                {
                    throw new ClanarinaAlreadyExists();
                }
            }
            clanarine.Add(c);
        }

        public void platioClanarinu(Clanarina c, Igrac i)
        {
            c.dodajIgraca(i);
        }

        public List<Clanarina> dohvatiClanarine()
        {
            return clanarine;
        }

        public List<Igrac> nisuPlatiliClanarinu(Clanarina c)
        {
            return Repositories.IgracRepository2.getInstance().
                dohvatiSveIgrace().Except(c.PlatiliClanarinu).ToList();

        }
    }
}
