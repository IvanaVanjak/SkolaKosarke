using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface IProtivnickiKlubRepository
    {
        void dodajKlub(ProtivnickiKlub klub);
        List<ProtivnickiKlub> dohvatiSveKlubove();
    }
}
