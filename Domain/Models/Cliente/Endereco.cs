using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Cliente
{
    public class Endereco
    {
        public int Codigo { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }
    }
}
