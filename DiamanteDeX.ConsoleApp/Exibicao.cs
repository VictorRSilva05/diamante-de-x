using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.ConsoleApp
{
    public static class Exibicao
    {
        public static int MostrarMenu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Diamond designer");
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("\n!O valor precisa ser ímpar!");
            Console.Write("Insira o tamanho do diamante:");
            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result) || result % 2 == 0 || result < 3)
            {
                Console.Write("Valor inválido, tente novamente: ");
                input = Console.ReadLine();
            }
            return (int)result;
        }

        public static List<string> CriarDiamante(int tamanho)
        {
            List<string> linhas = new List<string>();
            int espaco = default;

            for (int i = 1; i <= tamanho; i += 2)
            {
                //linhas[i - 1] = ("").PadLeft(i, '*');
                linhas.Add(("").PadLeft((tamanho + 10) - espaco, ' ') + ("").PadLeft(i, '*'));
                espaco++;
            }
            return linhas;
        }

        public static void DesenharDiamante(List<string> linhas)
        {
            Console.Clear();
            for (int i = 0; i < linhas.Count; i++)
            {
                Console.WriteLine(linhas[i]);
            }
            for (int i = linhas.Count - 2; i >= 0; i--)
            {
                Console.WriteLine(linhas[i]);
            }
        }
    }
}
