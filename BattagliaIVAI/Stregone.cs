using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    public class Stregone : Razza
    {
        public static Stregone Istanza { get; private set; } = new Stregone();
        private Stregone()
        {
            Schieramento = Schieramento.Bene;
            Attacco = 9;
            Difesa = 8;
        }
    }
}
