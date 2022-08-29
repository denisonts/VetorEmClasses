using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VetorEmClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] Lista = new Produto[n];

            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Lista[i] = new Produto { NomeProduto = nome, Preco = preco };
            }

            double soma =0.0;
            for (int i = 0; i < n; i++) {
                soma += Lista[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Media dos valores: " + avg);
        }
    }
}
