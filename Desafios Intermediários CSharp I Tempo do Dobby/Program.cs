using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Intermediários_CSharp_I_Tempo_do_Dobby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoRestante = int.Parse(Console.ReadLine());
            string[] tempos = Console.ReadLine().Split();
            int tempo1 = int.Parse(tempos[0]);
            int tempo2 = int.Parse(tempos[1]);
            int tempoTotal = tempo1 + tempo2;

            if (tempoTotal > tempoRestante)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }

            Console.ReadKey();
        }
    }
}
