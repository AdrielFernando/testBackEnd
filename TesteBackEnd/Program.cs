using System;
using Exercicios.Q1;
using Exercicios.Q2;
using Exercicios.Q3;
using Exercicios.Q4;
using Exercicios.Q5;

class Program
{
    static void Main()
    {
        bool executar = true;

        while (executar)
        {
            Console.Clear();
            Console.WriteLine("Escolha o exercício a ser executado:");
            Console.WriteLine("1 - Q1");
            Console.WriteLine("2 - Q2");
            Console.WriteLine("3 - Q3");
            Console.WriteLine("4 - Q4");
            Console.WriteLine("5 - Q5");
            Console.WriteLine("0 - Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Q1.Run();
                    break;
                case "2":
                    Q2.Run();
                    break;
                case "3":
                    Q3.Run();
                    break;
                case "4":
                    Q4.Run();
                    break;
                case "5":
                    Q5.Run();
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    executar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}