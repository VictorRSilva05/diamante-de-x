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

            while (!int.TryParse(input, out result) || result % 2 == 0)
            {
                Console.Write("Valor inválido, tente novamente: ");
                input = Console.ReadLine();
            }
            return (int)result;
        }

        public static string[] CriarDiamante(int tamanho)
        {
            string[] linhas = new string[tamanho];

            for (int i = 1; i <= tamanho; i += 2)
            {
                linhas[i - 1] = ("").PadRight(i, '*');
            }
            return linhas;
        }

        public static void DesenharDiamante(string[] linhas)
        {
            foreach (string line in linhas)
            {
                Console.WriteLine(line);
            }
        }
    }
}
