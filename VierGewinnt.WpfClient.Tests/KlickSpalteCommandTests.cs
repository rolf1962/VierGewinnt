using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class KlickSpalteCommandTests
    {
        private MainWindowViewModelMock _mainWindowViewModelMock;
        private KlickSpalteCommand _testTarget;
        private SpalteMock _spalteMock;

        [TestInitialize]
        public void TestInitialize()
        {
            _mainWindowViewModelMock = new MainWindowViewModelMock();
            _spalteMock = new SpalteMock();
            _testTarget = new KlickSpalteCommand(_spalteMock, _mainWindowViewModelMock);
        }

        [TestMethod]
        public void CommandLöstCanExecuteChangedAusWennGewinnerInMainWindowViewModelGesetztWird()
        {
            var anzahlCanExecuteChangedAufrufe = 0;
            _testTarget.CanExecuteChanged += (sender, args) => anzahlCanExecuteChangedAufrufe++;

            _mainWindowViewModelMock.SetzeGewinnername("Foo");

            Assert.AreEqual(1, anzahlCanExecuteChangedAufrufe);
        }

        [TestMethod]
        public void CanExecuteGibtTrueZurückWennGewinnernameNichtGesetztUndSpalteNichtVollIst()
        {
            var canExecute = _testTarget.CanExecute(null);
            Assert.IsTrue(canExecute);
        }

        [TestMethod]
        public void CanExecuteGibtFalseZurückWennSpalteVollIst()
        {
            _spalteMock.IstSpalteVoll = true;

            var canExecute = _testTarget.CanExecute(null);
            Assert.IsFalse(canExecute);
        }

        [TestMethod]
        public void CanExecuteGibtFalseZurückWennGewinnerGesetztIst()
        {
            _mainWindowViewModelMock.SetzeGewinnername("Foo");

            var canExecute = _testTarget.CanExecute(null);
            Assert.IsFalse(canExecute);
        }

        [TestMethod]
        public void ExecuteRuftSpieleZugAufMainWindowViewModelAuf()
        {
            _testTarget.Execute(null);

            Assert.IsTrue(_mainWindowViewModelMock.WurdeSpieleZugGenauEinmalAufgerufen);
        }

        [TestMethod]
        public void ExecuteLöstCanExecuteChangedAusWennSpalteDurchZugVollWird()
        {
            var anzahlCanExecuteChangedAufrufe = 0;
            _testTarget.CanExecuteChanged += (sender, args) => anzahlCanExecuteChangedAufrufe++;
            _spalteMock.IstSpalteVoll = true;

            _testTarget.Execute(null);

            Assert.AreEqual(1, anzahlCanExecuteChangedAufrufe);
        }
    }
}
