﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class Diagonale : Linie
    {
        public Diagonale(IReadOnlyList<Platz> plätze) : base(plätze)
        {
        }
    }
}
