using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    internal class SpielbrettMock : ISpielbrett
    {
        public IReadOnlyList<IReadOnlyList<Platz>> Plätze => throw new System.NotImplementedException();

        public IReadOnlyList<Reihe> Reihen => throw new System.NotImplementedException();

        public IReadOnlyList<ISpalte> Spalten => throw new System.NotImplementedException();

        public IReadOnlyList<Diagonale> Diagonalen => throw new System.NotImplementedException();

        public string Gewinnername { get; internal set; }

        public string BestimmerGewinnername()
        {
            throw new System.NotImplementedException();
        }
    }
}