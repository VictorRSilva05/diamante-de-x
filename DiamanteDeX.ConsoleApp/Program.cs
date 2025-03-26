
namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante = Exibicao.MostrarMenu();

            List<string> linhas = Exibicao.CriarDiamante(tamanhoDiamante);

            Exibicao.DesenharDiamante(linhas);
        }

    }
}
