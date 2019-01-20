using System;

namespace VierGewinnt.Core
{
    public class Platz
    {
        private readonly int _x;
        private readonly int _y;

        public Platz(int x, int y)
        {
            if (_x < 0) { throw new ArgumentOutOfRangeException(nameof(x), $"Der Spaltenindex {nameof(x)} kann nicht kleiner als 0 sein."); }
            if (_y < 0) { throw new ArgumentOutOfRangeException(nameof(y), $"Der Reihenindex {nameof(y)} kann nicht kleiner als 0 sein."); }

            _x = x;
            _y = y;
        }

        public Spielstein Spielstein { get; set; }

        public int X => _x;

        public int Y => _y;
    }
}