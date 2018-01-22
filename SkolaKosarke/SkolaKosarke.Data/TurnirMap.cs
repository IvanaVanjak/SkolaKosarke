using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class TurnirMap : SubclassMap<Turnir>
    {

        public TurnirMap() {

            DiscriminatorValue("TURNIR");
            Map(p => p.Rang);
            Map(p => p.BrojKlubova);
        }
    }
}
