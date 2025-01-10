namespace Exercicios.Q1
{
    public class Q1
    {
        // Método Run ao invés de Main, para integração com o menu no Program.cs
        public static void Run()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K += 1;
                SOMA += K;
            }

            Console.WriteLine(SOMA);
        }
    }
}
