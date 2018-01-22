using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface IIgracRepository
    {   
        void dodajIgraca(Igrac igrac);
        Igrac dohvatiIgracePoOIBu(string oib);
        IList<Igrac> dohvatiSveIgrace();
        IList<Igrac> dohvatiIgraceMladeIliJednake(int godiste);

    }
}
