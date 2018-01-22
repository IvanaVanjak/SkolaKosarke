using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;
using SkolaKosarke.Model.Factory;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class NatjecanjeTest
    {
        NatjecanjeRepository2 repository = NatjecanjeRepository2.getInstance();

        [TestMethod]
        public void DodajUtakmicuNaNatjecanje() {
            Natjecanje nat = NatjecanjeFactory.CreateNatjecanje("Liga", 2000, "Liga", 1, 3, 5);
            ProtivnickiKlub pk = ProtivnickiKlubFactory.createProtivnickiKlub("Ime3", "1", "Ulica", "4", 988, "Mjesto", "Drzava");
            Utakmica u = new Utakmica(DateTime.Now, pk, 56, 53);
            repository.dodajUtakmicuNaNatjecanje(nat, u);

            Assert.AreEqual(1, nat.Utakmice.Count);
        }
    }
}
