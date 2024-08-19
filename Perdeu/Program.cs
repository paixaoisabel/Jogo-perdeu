using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perdeu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vez;
            int li;
            int ls;
            int oculto;
            int palpite;

            vez = 1; li = 1; ls = 100;

            do
            {
                Console.Write("Jogado neutro, digite numero entre 1 e 100: ");
                oculto = int.Parse(Console.ReadLine());

            } while (oculto <= 1 || oculto >= 100);
            do
            {


                do
                {
                    Console.Write("Jogador {0}, Digte um numero entre {1} e {2}: ", vez, li, ls);
                    palpite = int.Parse(Console.ReadLine());

                } while (palpite <= li || palpite >= ls);


                if (palpite == oculto)
                {
                    Console.Write("Parabéns Jogador {0}, você perdeu!", vez);
                }

                else

                if (palpite < oculto)

                {
                    li = palpite;
                }
                else
                    ls = palpite;

                vez = vez + 1;

                if (vez > 2)
                {
                    vez = 1;
                }

            } while (palpite != oculto);

        }
    }
}
