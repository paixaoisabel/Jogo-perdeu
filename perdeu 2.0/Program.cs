using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perdeu_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nj;
            int vez;
            int li;
            int ls;
            int oculto;
            int palpite;

            vez = 0; li = 1; ls = 100;

            Random r = new Random();

            oculto = (r.Next(98) + 1);


            do
            {
                Console.Write("Qual o numero de jogadores: ");
                nj = int.Parse(Console.ReadLine());

            } while (nj < 2 || nj > 5);

            string[] nomes;
            nomes = new string[nj];

            for (int i = 0; i < nj; i++)
            {
                Console.Write("Digite o nome do {0}° jogador:", i + 1);
                nomes[i] = Console.ReadLine();
            }

            do
            {
                do
                {
                    Console.Write("Jogador {0}, Digte um numero entre {1} e {2}: ", nomes[vez], li, ls);
                    palpite = int.Parse(Console.ReadLine());

                } while (palpite <= li || palpite >= ls);


                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns Jogador {0}, você perdeu!", nomes[vez]);
                }

                else

                if (palpite < oculto)

                {
                    li = palpite;
                }
                else
                    ls = palpite;

                vez = vez + 1;

                if (vez == nj)
                {
                    vez = 0;
                }

            } while (palpite != oculto);
        }
    }
}
