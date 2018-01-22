using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class PrijateljskaUtakmicaMap : SubclassMap<PrijateljskaUtakmica>
    {
        public PrijateljskaUtakmicaMap() {

            DiscriminatorValue("PRIJATELJSKA_UTAKMICA");

        }
    }
}
