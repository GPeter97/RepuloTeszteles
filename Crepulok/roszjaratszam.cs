using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crepulok
{
    class Roszjaratszam : Exception
    {
        public Roszjaratszam(string jaratSzam)
           : base("Hibas szamlaszam: " + jaratSzam)
        {

        }
    }
}
