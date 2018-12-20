using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Reihe : Linie
    {
        public Reihe(IReadOnlyList<Platz> plätze) : base(plätze)
        {
        }
    }
}