using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{

    public class Elfo : Razza
    {
        public static Elfo Istanza { get; private set; } = new Elfo();
        private Elfo()
        {
            Schieramento = Schieramento.Bene;
            Attacco = 8;
            Difesa = 11;
        }
    }
}
