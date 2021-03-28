using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    public class Mago : Razza
    {
        public static Mago Istanza { get; private set; } = new Mago();
        private Mago()
        {
            Schieramento = Schieramento.Bene;
            Attacco = 8;
            Difesa = 8;
        }
    }
}
