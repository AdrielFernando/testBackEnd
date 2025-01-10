using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Exercicios.Q3
{
    public class Q3
    {
        public static void Run()
        {
           string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
           
           string jsonPath = Path.Combine(projectDirectory, @"Exercicios\Q3\faturamento.json");

            if (!File.Exists(jsonPath))
            {
                Console.WriteLine("Arquivo 'faturamento.json' não encontrado.");
                return;
            }

            string json = File.ReadAllText(jsonPath);

            var dias = JArray.Parse(JObject.Parse(json)["dias"].ToString()).Select(d => (double)d);

            var diasComFaturamento = dias.Where(d => d > 0).ToList();

            double menor = diasComFaturamento.Min();
            double maior = diasComFaturamento.Max();
            double media = diasComFaturamento.Average();

            int acimaDaMedia = diasComFaturamento.Count(d => d > media);

            Console.WriteLine($"Menor faturamento: {menor}");
            Console.WriteLine($"Maior faturamento: {maior}");
            Console.WriteLine($"Dias com faturamento acima da média: {acimaDaMedia}");
        }
    }
}
