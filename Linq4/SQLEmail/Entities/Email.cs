using System;
using System.Collections.Generic;
using System.Text;

namespace SQLEmail.Entities
{
    class Email
    {
        public string  Nome { get; set; }
        public string  EmailNome { get; set; }
        public double  Salario { get; set; }

        public Email(string nome, string emailNome, double salario)
        {
            Nome = nome;
            EmailNome = emailNome;
            Salario = salario;
        }
    }
}
