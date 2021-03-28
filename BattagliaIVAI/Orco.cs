using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    public class Orco : Razza
    {
        public static Orco Istanza { get; private set; } = new Orco();
        private Orco()
        {
            Schieramento = Schieramento.Male;
            Attacco = 11;
            Difesa = 7;
        }
    }
}
