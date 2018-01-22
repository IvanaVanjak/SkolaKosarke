using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class LigaMap : SubclassMap<Liga>
    {

        public LigaMap() {

            DiscriminatorValue("LIGA");
            Map(p => p.Rang);
            Map(p => p.BrojKlubova);
            Map(p => p.BrojBodova);
            
        }
    }
}
