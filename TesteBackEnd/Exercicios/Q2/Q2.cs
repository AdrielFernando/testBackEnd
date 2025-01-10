namespace Exercicios.Q2
{
    public class Q2
    {
        // Mudança do método Main para Run
        public static void Run()
        {
            Console.Write("Informe um número: ");
            
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                int a = 0, b = 1, soma = 0;
                bool pertence = false;

                while (soma <= numero)
                {
                    if (soma == numero)
                    {
                        pertence = true;
                        break;
                    }
                    soma = a + b;
                    a = b;
                    b = soma;
                }

                if (pertence)
                    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                else
                    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }
    }
}
