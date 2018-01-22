using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class IgracMap : ClassMap<Igrac>
    {
        public IgracMap() {

            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Ime);
            Map(p => p.Prezime);
            Map(p => p.Nadimak);
            Map(p => p.OIB);
            Map(p => p.DatumRodenja);
            Map(p => p.ImeRoditelja);
            Map(p => p.PrezimeRoditelja);
            Map(p => p.BrojTelefona);
        }
    }
}
