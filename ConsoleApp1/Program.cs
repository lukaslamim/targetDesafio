using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double[] faturamentoDiario = new double[] { 1000, 2000, 0, 500, 3000, 0, 0, 4500, 200, 0, 800, 1200, 0 };


                List<double> diasComFaturamento = new List<double>();


                foreach (var faturamento in faturamentoDiario)
                {
                    if (faturamento > 0)
                    {
                        diasComFaturamento.Add(faturamento);
                    }
                }

                int diasAcimaMedia = 0;

                double menorFatu = diasComFaturamento.Min();

                double maiorFatu = diasComFaturamento.Max();

                double mediaAnual = diasComFaturamento.Average();

                foreach (var faturamento in diasComFaturamento)
                {
                    if (faturamento > mediaAnual)
                    {
                        diasAcimaMedia++;
                    }
                }

                Console.WriteLine("Menor valor de faturamento: " + menorFatu);
                Console.WriteLine("Maior valor de faturamento: " + maiorFatu);
                Console.WriteLine("Numero de dias com faturamento superior à média anual: " + diasAcimaMedia);
            }
        }
}
