using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class StatistikaMap : ClassMap<Statistika>
    {
        public StatistikaMap() {

            Id(p => p.Id).GeneratedBy.Native();
            References(p => p.Igrac).Not.LazyLoad();
            References(p => p.Utakmica);
            Map(p => p.PostignutiKosevi);
            Map(p => p.Skokovi);
            Map(p => p.Asistencije);
            Map(p => p.OsobnePogreske);

        }
    }
}
