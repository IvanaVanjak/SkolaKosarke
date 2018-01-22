using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class ClanarinaMap : ClassMap<Clanarina>
    {
        public ClanarinaMap() {

            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Mjesec);
            Map(p => p.Godina);
            Map(p => p.Iznos);
            HasManyToMany(p => p.PlatiliClanarinu).Not.LazyLoad();

        }
    }
}
