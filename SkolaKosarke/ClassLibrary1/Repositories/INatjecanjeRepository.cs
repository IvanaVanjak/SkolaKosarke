using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Repositories
{
    public interface INatjecanjeRepository
    {
        void dodajNovoNatjecanje(Natjecanje n);
        List<Natjecanje> dohvatiSvaNatjecanja();
        void dodajUtakmicuNaNatjecanje(Natjecanje n, Utakmica u);
        Natjecanje dohvatiNatjecanjeID(string id);
        IList<Utakmica> dohvatiUtakmiceNaNatjecanju(string natjecanjeId);
        IList<Statistika> dohvatiStatistike(string id);
        void dodajStatistiku(Natjecanje natjecanje, Utakmica utakmica, Statistika s);
        List<Natjecanje> dohvatiTurnireLige();
        void izmijeni(Natjecanje n);
    }
}
