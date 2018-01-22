using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface IBiljeskaOIgracuRepository
    {
        void dodajBiljesku(BiljeskaOIgracu b);
        List<BiljeskaOIgracu> dohvatiSveBiljeske();
        List<BiljeskaOIgracu> dohvatiBiljeskeOIgracu(Igrac i);
    }
}
