using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spalte : ISpalte
    {
        private readonly IReadOnlyList<Platz> _plätze;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            throw new NotImplementedException();
        }
    }
}