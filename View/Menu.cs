namespace View;

public static class Menu
{
    public static void MostrarMenu()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Diamond designer");
        Console.WriteLine("---------------------------------------");


        Console.WriteLine("!O valor precisa ser ímpar!");
        Console.Write("Insira o tamanho do diamante:");
        string input = Console.ReadLine();
        float result;

        while (!float.TryParse(input, out result) || result % 2 == 0)
        {
            Console.Write("Valor inválido, tente novamente: ");
            input = Console.ReadLine();
        }
    }
}
