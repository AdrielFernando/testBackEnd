using System;

namespace Exercicios.Q4
{
    public class Q4
    {
        // Método Run para ser chamado pelo menu
        public static void Run()
        {
            double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;
            double total = SP + RJ + MG + ES + Outros;

            // Exibindo a porcentagem de cada estado
            Console.WriteLine($"SP: {SP / total:P2}");
            Console.WriteLine($"RJ: {RJ / total:P2}");
            Console.WriteLine($"MG: {MG / total:P2}");
            Console.WriteLine($"ES: {ES / total:P2}");
            Console.WriteLine($"Outros: {Outros / total:P2}");
        }
    }
}
