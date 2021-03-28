using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    public class Uomo : Razza 
    {
        public static Uomo Istanza { get; private set; } = new Uomo();
        private Uomo()
        {
            Schieramento = Schieramento.Bene;
            Attacco = 12;
            Difesa = 5;
        }
    }
}
