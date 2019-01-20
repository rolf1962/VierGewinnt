using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class SpielbrettFactoryTests
    {
        private Spielbrett _spielbrett;

        [TestInitialize]
        public void TestInitialize()
        {
            var testTarget = new SpielbrettFactory();
            _spielbrett = testTarget.Erstelle(6, 7);
        }

        [TestMethod]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlSpalten()
        {
            Assert.AreEqual(7, _spielbrett.Spalten.Count);
        }

        [TestMethod]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlReihen()
        {
            Assert.AreEqual(6, _spielbrett.Reihen.Count);
        }

        [TestMethod]
        public void ErstelleFügtKorrektePlätzeZuSpaltenHinzu()
        {
            var spalte3 = _spielbrett.Spalten[2];
            Assert.IsTrue(spalte3.Plätze.All(platz => platz.X == 2));
        }

        [TestMethod]
        public void ErstelleFügtKorrektePlätzeZuReihenHinzu()
        {
            var reihe4 = _spielbrett.Reihen[3];
            Assert.IsTrue(reihe4.Plätze.All(platz => platz.Y == 3));
        }

        [TestMethod]
        public void ErstelleFügtKorrektPlätzeZuLinksUntenDiagonalen()
        {
            var zieldiagonale = _spielbrett.Diagonalen.First(diagonale => diagonale.DiagonalenRichtung == Diagonalenrichtung.LinksUnten &&
                                                          diagonale.StartIndexX == 5 &&
                                                          diagonale.StartIndexY == 0);

            Assert.IsNotNull(zieldiagonale);

            var ersterPlatz = zieldiagonale.Plätze.First();
            var letzterPlatz = zieldiagonale.Plätze.Last();

            Assert.IsTrue(ersterPlatz.X == 5 && ersterPlatz.Y == 0);
            Assert.IsTrue(letzterPlatz.X == 0 && letzterPlatz.Y == 4);

            // Video Stop = 37:10

        }
    }
}
