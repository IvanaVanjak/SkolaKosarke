using NHibernate;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Data.Repositories
{
    public class ClanarinaRepository : IClanarinaRepository
    {
        public ClanarinaRepository()
        {
        }

        public void dodajClanarinu(Clanarina c)
        {
            List<Clanarina> clanarine = dohvatiClanarine();

            foreach (Clanarina clanarina in clanarine)
            {
                if (clanarina.Godina == c.Godina && clanarina.Mjesec == c.Mjesec)
                {
                    throw new ClanarinaAlreadyExists();
                }
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(c);
                    transaction.Commit();
                }
            }
        }

        public void platioClanarinu(Clanarina c, Igrac i)
        {
            using (ISession session = FluentNHibernate.OpenSession())
            {
                c.dodajIgraca(i);

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(c);
                    transaction.Commit();
                }
            }
        }

        public List<Clanarina> dohvatiClanarine()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Clanarina> query = (from i in nSession.Query<Clanarina>()
                                               orderby i.Godina, i.Mjesec
                                               select i);
                List<Clanarina> clanarine = query.ToList<Clanarina>();
                return clanarine;
            }
        }

        public List<Igrac> nisuPlatiliClanarinu(Clanarina c)
        {
            List<Igrac> igraci;
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Igrac> query = (from i in nSession.Query<Igrac>()
                                           orderby i.Prezime
                                           select i);
                igraci = query.ToList<Igrac>();
            }
            List<Igrac> a = new List<Igrac>();
            foreach (Igrac i in igraci) {
                bool flag = false;
                foreach (Igrac i2 in c.PlatiliClanarinu) {
                    if (i.Id == i2.Id) {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) {
                    a.Add(i);
                }
                flag = false;
            }
            //return igraci.Except(c.PlatiliClanarinu).ToList();
            return a;

        }
    }
}
