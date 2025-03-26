
namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int tamanhoDiamante = Exibicao.MostrarMenu();

                List<string> linhas = Exibicao.CriarDiamante(tamanhoDiamante);

                Exibicao.DesenharDiamante(linhas);

                Console.Write("Deseja desenhar outro diamante? (S/n)");
                string opcao = Console.ReadLine().ToUpper();

                while (opcao != "S" && opcao != "N")
                {
                    Console.Write("Valor inválido, tente novamente: ");
                    opcao = Console.ReadLine();
                }
                if (opcao == "N")
                    break;
            }
        }

    }
}
