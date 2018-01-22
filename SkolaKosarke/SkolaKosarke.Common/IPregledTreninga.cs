using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IPregledTreninga : Observer
    {
        void ShowForm();
        void UcitajTrening(string id, string datum, string grupa);
        void UcitajIgraceNaTreningu(string id,string datum, string grupa, string igrac);
    }
}
