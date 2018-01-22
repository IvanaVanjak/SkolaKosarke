using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class UtakmicaMap : ClassMap<Utakmica>
    {
        public UtakmicaMap() {
            
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Datum);
            References(p => p.ProtivnickiKlub).Not.LazyLoad();
            Map(p => p.BrojPostignutihKoseva);
            Map(p => p.BrojPrimljenihKoseva);
            HasMany(p => p.StatistikeIgraca).Inverse().Cascade.All().Not.LazyLoad();
        }
    }
}
