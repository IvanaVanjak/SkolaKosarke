using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Model;
using NHibernate;

namespace SkolaKosarke.Data.Repositories
{
    public class IgracRepository : IIgracRepository
    {
        public IgracRepository()
        {
        }

        public void dodajIgraca(Igrac igrac)
        {
            IList<Igrac> igraci = dohvatiSveIgrace();

            if (igrac.Ime == "" || igrac.Prezime == "" || igrac.ImeRoditelja == ""
                 || igrac.PrezimeRoditelja == "" || igrac.BrojTelefona == "")
            {
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
            if (igrac.OIB.Length != 11)
            {
                throw new OIBLengthException();
            }
            foreach (Igrac i in igraci)
            {
                if (i.OIB == igrac.OIB)
                {
                    throw new IgracOIBAlreadyExists();
                }
                if (i.Ime == igrac.Ime && i.Prezime == igrac.Prezime && i.Nadimak == igrac.Nadimak)
                {
                    throw new IgracNadimakAlreadyExists();
                }
            }
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(igrac);
                    transaction.Commit();
                }
            }
        }

        public IList<Igrac> dohvatiSveIgrace()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Igrac> query = (from i in nSession.Query<Igrac>()
                                           orderby i.Prezime
                                           select i);
                IList<Igrac> igraci = query.ToList<Igrac>();
                return igraci;
            }
        }

        public Igrac dohvatiIgracePoOIBu(string oib)
        {

            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Igrac> query = (from i in nSession.Query<Igrac>()
                                           where i.OIB.ToString() == oib
                                           orderby i.Prezime
                                           select i);
                IList<Igrac> igraci = query.ToList<Igrac>();
                return igraci.ElementAt(0);
            }
        }

        public IList<Igrac> dohvatiIgraceMladeIliJednake(int godiste)
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Igrac> query = (from i in nSession.Query<Igrac>()
                                           where i.DatumRodenja.Year >= godiste
                                           orderby i.Prezime
                                           select i);
                IList<Igrac> igraci = query.ToList<Igrac>();
                return igraci;
            }
        }

    }
}
