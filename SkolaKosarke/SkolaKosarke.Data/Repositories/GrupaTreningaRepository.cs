using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkolaKosarke.Model;
using NHibernate;
using NHibernate.Linq;

using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Data.Repositories
{
    public class GrupaTreningaRepository : IGrupaTreningaRepository
    {
        public GrupaTreningaRepository()
        {
        }

        public void dodajGrupu(GrupaTreninga grupa)
        {
            if (grupa.NazivGrupe == "")
            {
                throw new GrupaTreningaPraznoImeExists();
            }
            List<GrupaTreninga>  grupe = dohvatiSveGrupe();
            foreach (GrupaTreninga g in grupe)
            {
                if (g.NazivGrupe == grupa.NazivGrupe)
                {
                    throw new GrupaTreningaAlreadyExists();
                }
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(grupa);
                    transaction.Commit();
                }
            }
        }

        public List<GrupaTreninga> dohvatiSveGrupe()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<GrupaTreninga> query = (from i in nSession.Query<GrupaTreninga>()
                                           orderby i.NazivGrupe
                                           select i);
                List<GrupaTreninga> grupe = query.ToList<GrupaTreninga>();
                return grupe;
            }
        }

        public void dodajIgracaUGrupu(Igrac igrac, GrupaTreninga grupa)
        {
            if (igrac == null) {
                throw new IgracDoesntExists();
            }
            List<GrupaTreninga> grupe = dohvatiSveGrupe();

            foreach (GrupaTreninga g in grupe)
            {
                foreach (Igrac i in g.IgraciUGrupi)
                {
                    if (i.OIB == igrac.OIB)
                    {
                        using (ISession session = FluentNHibernate.OpenSession())
                        {
                            g.IgraciUGrupi.Remove(i);

                            using (ITransaction transaction = session.BeginTransaction())
                            {
                                session.Update(g);
                                transaction.Commit();
                            }
                        }
                        break;
                    }
                }
                if (g.NazivGrupe == grupa.NazivGrupe)
                {
                    grupa.dodajIgraca(igrac);
                    using (ISession session = FluentNHibernate.OpenSession())
                    {
                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Update(grupa);
                            transaction.Commit();
                        }
                    }
                }
            }
        }
    }
}

