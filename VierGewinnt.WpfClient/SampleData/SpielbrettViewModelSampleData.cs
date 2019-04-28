using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    /// <summary>
    /// ToDo: Implementierung Video11, Position 12:50
    /// </summary>
    public class SpielbrettViewModelSampleData : ISpielbrettViewModel
    {
        private IReadOnlyList<Platz> _plätze;
        private IReadOnlyList<IKlickSpalteCommand> _klickSpalteCommands;

        public SpielbrettViewModelSampleData()
        {
            // Plätze initialisieren
            var plätze = new Platz[7][];

            for (var i = 0; i < 7; i++)
            {
                plätze[i] = new Platz[6];
                for (var j = 0; j < 6; j++)
                {
                    plätze[i][j] = new Platz(i, j);
                }
            }

            for (var i = 0; i < 7; i++)
            {
                plätze[i][4].Spielstein = new Spielstein(new Farbe(128, 0, 0), "Foo");
            }

            for (var i = 0; i < 7; i++)
            {
                plätze[i][5].Spielstein = new Spielstein(new Farbe(0, 0, 128), "Bar");
            }

            _plätze = plätze.SelectMany(innerArray => innerArray).ToList();

            // Spaltenkommandos initialisieren
            var klickSpalteKommandos = new List<IKlickSpalteCommand>();
            for (var i = 0; i < 7; i++)
            {
                var canExecute = i != 0 && i != 1;
                klickSpalteKommandos.Add(new KlickSpalteCommandDummy(i, canExecute));
            }
            _klickSpalteCommands = klickSpalteKommandos;
        }

        public IReadOnlyList<Platz> Plätze
        {
            get { return _plätze; }
        }

        public IReadOnlyList<IKlickSpalteCommand> KlickSpalteCommands
        {
            get { return _klickSpalteCommands; }
        }
    }
}
