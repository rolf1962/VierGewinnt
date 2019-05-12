using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VierGewinnt.WpfClient.SampleData;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class MainWindowViewModelTests
    {
        private SpielerMock _spielerAMock;
        private SpielerMock _spielerBMock;
        private SpielbrettMock _spielbrettMock;
        private IMainWindowViewModel _testTarget;
        private List<SpielerViewModelMock> _spielerViewModelMocks;

        [TestInitialize]
        public void TestInitialize()
        {
            _spielerAMock = new SpielerMock();
            _spielerBMock = new SpielerMock() { };
            _spielbrettMock = new SpielbrettMock();
            _spielerViewModelMocks = new List<SpielerViewModelMock>()
            {
                new SpielerViewModelMock(_spielerAMock),
                new SpielerViewModelMock(_spielerBMock)
            };
            _testTarget = new MainWindowViewModel(_spielerViewModelMocks, new SpielbrettViewModelSampleData(), _spielbrettMock);
        }

        [TestMethod]
        public void SpieleZugLeitetAufrufAnSpielerWeiter()
        {
            _testTarget.SpieleZug(new SpalteMock());
            Assert.IsTrue(_spielerAMock.WurdeSpieleZugGenauEinmalAufgerufen &&
                _spielerBMock.AnzahlSpieleZugAufrufe == 0);
        }

        [TestMethod]
        public void SpieleZugLöstPropertyChangedMitGewinnernameAusWennGewinnerErmitteltWird()
        {
            _spielbrettMock.Gewinnername = "Foo";
            var anzahlPropertyChangedAufrufe = 0;
            _testTarget.PropertyChanged += (sender, args) => anzahlPropertyChangedAufrufe++;

            _testTarget.SpieleZug(new SpalteMock());

            Assert.AreEqual(1, anzahlPropertyChangedAufrufe);
            Assert.AreEqual("Foo", _testTarget.Gewinnername);
        }

        [TestMethod]
        public void SpieleZugTauschtSpielerAnDerReiheWennKeinGewinnerFeststeht()
        {
            _testTarget.SpieleZug(new SpalteMock());
            Assert.IsTrue(_spielerViewModelMocks[0].IstAnDerReihe == false &&
                _spielerViewModelMocks[1].IstAnDerReihe);
        }
    }
}
