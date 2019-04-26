using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class SpielerViewModelTests
    {
        [TestMethod]
        public void ViewModelGibtBenachrichtigungWennIstAnDerReiheGeändertWird()
        {
            var testTarget = new SpielerViewModel(new Spieler("Foo", new List<Spielstein>(), new Farbe(0, 0, 0)));
            var callCount = 0;
            testTarget.PropertyChanged += (sender, args) => callCount++;

            testTarget.IstAnDerReihe = !testTarget.IstAnDerReihe;

            Assert.AreEqual(1, callCount);
        }
    }
}
