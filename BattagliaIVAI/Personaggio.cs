using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaIVAI
{
    class Personaggio
    {
        public string Nome { get; private set; }
        public Razza Razza { get; private set; }
        public uint Vita { get; private set; } = 100;
        public uint Esperienza { get; private set; } = 4;

        public Personaggio(string nome, Razza razza)
        {
            Nome = nome;
            Razza = razza;
        }

        public uint GetAttacco()
        {
            return Razza.Attacco * Esperienza;
        }

        public uint GetDifesa()
        {
            return Razza.Difesa * Esperienza;
        }
    }
}
