using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    internal class SpielerViewModelMock : ISpielerViewModel
    {
        private ISpieler _spieler;

        public SpielerViewModelMock(ISpieler spieler)
        {
            _spieler = spieler;
        }

        public ISpieler Spieler
        {
            get { return _spieler; }
        }

        public bool IstAnDerReihe { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}