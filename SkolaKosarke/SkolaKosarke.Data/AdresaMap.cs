using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using FluentNHibernate.Mapping;

namespace SkolaKosarke.Data
{
    public class AdresaMap : ComponentMap<Adresa>
    {
        public AdresaMap() {

            Map(x => x.Ulica);
            Map(x => x.KucniBroj);
            Map(x => x.PostanskiBroj);
            Map(x => x.Mjesto);
            Map(x => x.Drzava);
        }
    }
}
