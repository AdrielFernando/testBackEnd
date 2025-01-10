using System;
using System.Text;

namespace Exercicios.Q5
{
    public class Q5
    {
        // Método Run para ser chamado pelo menu
        public static void Run()
        {
            Console.Write("Informe uma string: ");
            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();

            // Adicionando os caracteres da string invertida
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine("String invertida: " + reversed.ToString());
        }
    }
}
