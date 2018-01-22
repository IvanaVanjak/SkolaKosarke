using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class TreningMap : ClassMap<Trening>
    {
        public TreningMap() {

            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Datum);
            Map(p => p.Grupa);
            HasManyToMany(p => p.IgraciNaTreningu).Not.LazyLoad();
        }
    }
}
