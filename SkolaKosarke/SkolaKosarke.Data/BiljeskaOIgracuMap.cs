using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class BiljeskaOIgracuMap : ClassMap<BiljeskaOIgracu>
    {
        public BiljeskaOIgracuMap() {

            Id(p => p.Id).GeneratedBy.Native();
            References(p => p.Igrac);
            Map(p => p.Datum);
            Map(p => p.Biljeska);

        }
    }
}
