using System;
using System.Globalization;
using System.Collections.Generic;
using SQLEmail.Entities;
using System.IO;
using System.Linq;

namespace SQLEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o Path do Nome : ");
            string Path = Console.ReadLine();

            Console.Write("Entre com Salario : ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email da Pessoa cujo o salario maior de : " + limite.ToString("F2", CultureInfo.InvariantCulture));

            List<Email> list = new List<Email>();
            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string nome = fields[0];
                        string email = fields[1];
                        double Salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Email(nome, email, Salary));
                    }
                }

                var emails = list.Where(Obj => Obj.Salario > limite).OrderBy(Obj => Obj.EmailNome).Select(Obj => Obj.EmailNome);
                               

                var sum = list.Where(obj => obj.Nome[0] == 'M').Sum(Obj => Obj.Salario);

                var emails2 =
                        from Obj in list
                        where Obj.Salario > limite
                        orderby Obj.Nome
                        select Obj;

                var Nomes = list.Where(Obj => Obj.Salario > limite).OrderBy(Obj => Obj.Nome);

                foreach (String email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine();

                foreach (var  Email in emails2)
                {
                    Console.WriteLine("Nome : "+Email.Nome+" ,  "+Email.EmailNome + " , " + Email.Salario.ToString("F2",CultureInfo.InvariantCulture));

                }

                Console.WriteLine();

                foreach (Email n  in Nomes)
                {
                    Console.WriteLine(n.Nome+ " ,  " + n.EmailNome+ " ,  " + n.Salario);

                }
                Console.WriteLine();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
