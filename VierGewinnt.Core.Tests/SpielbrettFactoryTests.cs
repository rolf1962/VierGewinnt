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
        [TestMethod]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlSpalten()
        {
            var testTarget = new SpielbrettFactory();
            var spielbrett = testTarget.Erstelle(6, 7);

            Assert.AreEqual(7, spielbrett.Spalten.Count);
        }

        [TestMethod]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlReihen()
        {
            var testTarget = new SpielbrettFactory();
            var spielbrett = testTarget.Erstelle(6, 7);

            Assert.AreEqual(6, spielbrett.Reihen.Count);
        }
    }
}
