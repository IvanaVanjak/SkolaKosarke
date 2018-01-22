using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Model.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class ProivnickiKlubTest
    {
        private ProtivnickiKlubRepository2 repository = ProtivnickiKlubRepository2.getInstance();

        [TestMethod]
        [ExpectedException(typeof(KlubAlreadyExists))]
        public void KlubIstoIme()
        {
            ProtivnickiKlub pk = ProtivnickiKlubFactory.createProtivnickiKlub("Ime", "1", "Ulica", "4", 988, "Mjesto", "Drzava");
            ProtivnickiKlub pk1 = ProtivnickiKlubFactory.createProtivnickiKlub("Ime", "2", "Ulica2", "24", 2988, "Mjesto2", "Drzava2");

            repository.dodajKlub(pk);
            repository.dodajKlub(pk1);
        }
    }
}
