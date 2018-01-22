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
    public class TreningRepository : ITreningRepository
    {
        public TreningRepository()
        {
        }

        public void DodajNoviTrening(Trening trening)
        {
            using (ISession session = FluentNHibernate.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    trening.IgraciNaTreningu = trening.IgraciNaTreningu;
                    session.Save(trening);
                    transaction.Commit();
                }
            }
        }

        public List<Trening> DohvatiSveTreninge()
        {
            using (ISession nSession = FluentNHibernate.OpenSession())
            {
                IQueryable<Trening> query = (from i in nSession.Query<Trening>()
                                                   orderby i.Datum
                                                   select i);
                List<Trening> treninzi = query.ToList<Trening>();
                return treninzi;
            }
        }
    }
}
