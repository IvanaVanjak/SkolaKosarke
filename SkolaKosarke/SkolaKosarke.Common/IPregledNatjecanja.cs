using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;

namespace SkolaKosarke.Common
{
    public interface IPregledNatjecanja : Observer
    {
        void ShowForm();
        void UcitajNatjecanje(Natjecanje n);
        void UcitajNatjecanje(string id, string naziv, string godiste);
        void UcitajUtakmice(string id, string datum, string klub, string postignuti, string primljeni);
        void UcitajStatistike(string igrac, string kosevi, string skokovi, string asistencije, string osobne);
        void Message(string m);
    }
}
