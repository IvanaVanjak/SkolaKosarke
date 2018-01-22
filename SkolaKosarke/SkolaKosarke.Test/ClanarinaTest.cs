using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkolaKosarke.Model;
using SkolaKosarke.Model.Repositories;

namespace SkolaKosarke.Test
{
    [TestClass]
    public class ClanarinaTest
    {
        ClanarinaRepository2 repository = ClanarinaRepository2.getInstance();

        [TestMethod]
        [ExpectedException(typeof(ClanarinaAlreadyExists))]
        public void ClanarinaIstiMjesecIstaGodina()
        {
            Clanarina c = new Clanarina(10, 2014, 120);
            repository.dodajClanarinu(c);
            c = new Clanarina(10, 2014, 150);
            repository.dodajClanarinu(c);
        }

        [TestMethod]
        public void NisuPlatiliClanarinu() {
            Clanarina c = new Clanarina(12, 2010, 120);
            repository.dodajClanarinu(c);

            Igrac i = new Igrac("Ivano", "Marić", "Ive", "12312012355", new DateTime(1993, 11, 12), "Ante", "Marić", "00000");
            IgracRepository2.getInstance().dodajIgraca(i);

            int brojPrijePlacanja = repository.nisuPlatiliClanarinu(c).Count;

            repository.platioClanarinu(c, i);

            Assert.AreEqual(brojPrijePlacanja - 1, repository.nisuPlatiliClanarinu(c).Count);
        }
    }
}
