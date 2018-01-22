using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model.Factory
{
    public class ProtivnickiKlubFactory
    {
        public static ProtivnickiKlub createProtivnickiKlub(string nazivKluba, string brojTelefona, string ulica, 
                    string kucniBroj, long postanskiBroj, string mjesto, string drzava) {
                        Adresa adresa = new Adresa(ulica, kucniBroj, postanskiBroj, mjesto, drzava);
                        ProtivnickiKlub klub = new ProtivnickiKlub(nazivKluba, brojTelefona, adresa);
                        return klub;
        }
    }
}
