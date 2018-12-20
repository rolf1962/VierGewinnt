using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spalte : Linie, ISpalte
    {
        public Spalte(IReadOnlyList<Platz> plätze) : base(plätze)
        {
        }

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            throw new NotImplementedException();
        }
    }
}