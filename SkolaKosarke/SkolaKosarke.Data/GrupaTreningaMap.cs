using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class GrupaTreningaMap : ClassMap<GrupaTreninga>
    {
        public GrupaTreningaMap() {

            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.NazivGrupe);
            HasMany(p => p.IgraciUGrupi).Not.LazyLoad();
        }
    }
}
