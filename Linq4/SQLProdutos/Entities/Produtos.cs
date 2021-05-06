using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProdutos.Entities
{
    class Produtos
    {
        public string  Nome { get; set; }
        public double  Preco { get; set; }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
