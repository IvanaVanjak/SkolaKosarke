using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IPregledGrupaTreninga : Observer
    {
        void UcitajGrupuIgraca(string naziv);
        void UcitajIgraceUGrupi(string grupa, string igrac);
        void ShowForm();
    }
}
