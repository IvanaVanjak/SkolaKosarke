using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public interface IPregledKlubova : Observer
    {
        void UcitajKlub(string naziv, string brojTelefona, string ulica, string kucniBroj, string postanskiBroj, 
            string mjesto, string drzava);
        void ShowForm();

    }
}
