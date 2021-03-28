using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    public  class Troll : Razza
    {
        public static Troll Istanza { get; private set; } = new Troll();
        private Troll()
        {
            Schieramento = Schieramento.Bene;
            Attacco = 8;
            Difesa = 11;
        }
    }
}
