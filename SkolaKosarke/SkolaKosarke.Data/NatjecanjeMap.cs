using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class NatjecanjeMap : ClassMap<Natjecanje>
    {

        public NatjecanjeMap() {

            Id(p => p.Id);
            Map(p => p.Naziv);
            Map(p => p.Godiste);
            HasMany(p => p.Utakmice).Cascade.All().Not.LazyLoad();

            DiscriminateSubClassesOnColumn("VRSTA_NATJECANJA");
        }
    }
}
