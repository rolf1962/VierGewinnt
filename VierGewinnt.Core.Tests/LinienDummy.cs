using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core.Tests
{
    public class LinienDummy : Linie
    {
        public LinienDummy(IReadOnlyList<Platz> plätze) : base(plätze)
        {
        }
    }
}
