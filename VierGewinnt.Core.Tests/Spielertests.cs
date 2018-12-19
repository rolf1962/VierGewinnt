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
                new Spielstein(),
                new Spielstein()
            };
            var initialCount = spielsteine.Count;
            var testTarget = new Spieler("Foo", spielsteine);

            var spalte = new Spalte();

            Assert.ThrowsException<NotImplementedException>(() => testTarget.SpieleZug(spalte));
        }

        [TestMethod]
        public void SpielzugLässtEinenSpielsteinFallen()
        {
            var spielsteine = new List<Spielstein>()
            {
                new Spielstein(),
                new Spielstein()
            };
            var testTarget = new Spieler("Foo", spielsteine);
            var spalteMock = new SpalteMock();

            testTarget.SpieleZug(spalteMock);

            Assert.IsTrue(spalteMock.WurdeLasseSpielsteinFallenGenauEinmalAufgerufen);
        }
    }
}
