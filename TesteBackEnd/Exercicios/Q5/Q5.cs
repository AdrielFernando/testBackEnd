using System;

namespace Exercicios.Q5
{
    public class Q5
    {
        public static void Run()
        {
            Console.Write("Informe uma string: ");
            string input = Console.ReadLine();
            char[] reversedArray = new char[input.Length];

            int index = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedArray[index] = input[i];
                index++;
            }

            string reversed = new string(reversedArray);

            Console.WriteLine("String invertida: " + reversed);
        }
    }
}
