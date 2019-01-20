using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class Diagonale : Linie
    {
        private readonly int _startIndexX;
        private readonly int _startIndexY;
        private readonly Diagonalenrichtung _diagonalenrichtung;

        public Diagonale(int startIndexX, int startIndexY, Diagonalenrichtung diagonalenrichtung, IReadOnlyList<Platz> plätze) : base(plätze)
        {
            if (startIndexX < 0) { throw new ArgumentOutOfRangeException(nameof(startIndexX), "Der Startspaltenindex X für die Diagonale darf nicht kleiner 0 sein."); }
            if (startIndexY < 0) { throw new ArgumentOutOfRangeException(nameof(startIndexY), "Der Startreihenindex Y für die Diagonale darf nicht kleiner 0 sein."); }

            _startIndexX = startIndexX;
            _startIndexY = startIndexY;
            _diagonalenrichtung = diagonalenrichtung;
        }

        public int StartIndexX => _startIndexX;

        public int StartIndexY => _startIndexY;

        public Diagonalenrichtung DiagonalenRichtung => _diagonalenrichtung;
    }
}
