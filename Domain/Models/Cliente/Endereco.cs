using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Cliente
{
    public class Endereco
    {
        public int Codigo { get; private set; }

        public string Logradouro { get; private set; }

        public int Numero { get; private set; }

        public string Complemento { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Uf { get; private set; }

        public Endereco(string logradouro, int numero, string complemento, string bairro, string cidade, string uf)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Uf = uf;
        }
    }
}
