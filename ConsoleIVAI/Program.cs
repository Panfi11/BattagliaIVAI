using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattagliaIVAI;

namespace ConsoleIVAI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Personaggio Tina = new Personaggio("Tina", Uomo.Istanza);
                Personaggio Givo = new Personaggio("Givo", Orco.Istanza);

                Console.WriteLine($"{Tina} attacca {Givo}");
                Console.WriteLine($"{Tina.Attacca(Givo)}\n");

                Console.WriteLine(Tina);
                Console.WriteLine(Givo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
     
        } 
 
    }
}
