    using System;
    using System.Collections.Generic;
    using SQLProdutos.Entities;
    using System.IO;
    using System.Globalization;
    using System.Linq;

namespace SQLProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre caminho do Aquivo");
            string Path = Console.ReadLine();
            List<Produtos> list = new List<Produtos>();

            using (StreamReader sr = File.OpenText(Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    double preco = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Produtos(nome, preco));
                }
            }
            var avg = list.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Media preco = " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var nomes = list.Where(p => p.Preco < avg).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }

    }
}
