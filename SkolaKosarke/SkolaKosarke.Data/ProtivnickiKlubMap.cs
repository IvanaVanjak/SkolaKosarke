using FluentNHibernate.Mapping;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class ProtivnickiKlubMap : ClassMap<ProtivnickiKlub>
    {
        public ProtivnickiKlubMap() {

            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.NazivKluba);
            Map(p => p.BrojTelefona);
            Component(p => p.Adresa);
        }
    }
}
