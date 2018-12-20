using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.Core.Tests
{
    [TestClass]
    public class Spielertests
    {
        [TestMethod]
        public void SpieleZugEntferntEinElementAusDenSpielsteinen()
        {
            var spielsteine = new List<Spielstein>()
            {
                new Spielstein(new Farbe(128,0,0), "Foo"),
                new Spielstein(new Farbe(128,0,0), "Foo")
            };
            var initialCount = spielsteine.Count;
            var testTarget = new Spieler("Foo", spielsteine);

            //var spalte = new Spalte();
            testTarget.SpieleZug(/*spalte*/new SpalteMock());

            Assert.AreEqual(initialCount - 1, testTarget.Spielsteine.Count);
        }

        [TestMethod]
        public void SpielzugLässtEinenSpielsteinFallen()
        {
            var spielsteine = new List<Spielstein>()
            {
                new Spielstein(new Farbe(128,0,0), "Foo"),
                new Spielstein(new Farbe(128,0,0), "Foo")
            };

            var testTarget = new Spieler("Foo", spielsteine);
            var spalteMock = new SpalteMock();

            testTarget.SpieleZug(spalteMock);

            Assert.IsTrue(spalteMock.WurdeLasseSpielsteinFallenGenauEinmalAufgerufen);
        }
    }
}
