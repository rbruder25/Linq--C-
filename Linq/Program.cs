using System;
using Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
   class Program
        {
            static void Main(string[] args)
            {

                List<Produto> list = new List<Produto>();

                list.Add(new Produto("Tv", 900.00));
                list.Add(new Produto("Mouse", 50.00));
                list.Add(new Produto("Tablet", 350.50));
                list.Add(new Produto("HD Case", 80.90));
                list.Add(new Produto("Not Pad", 40.90));

                List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
                foreach (string s in result)
                {
                    Console.WriteLine(s);
                }
            }
        }
}
