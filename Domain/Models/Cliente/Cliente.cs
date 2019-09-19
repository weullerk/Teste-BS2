using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Cliente
{
    public class Cliente
    {
        public int Codigo { get; set; }

        public string Nome { get; private set; }

        public string Documento { get; private set; }

        public IPessoa Pessoa { get; set; }

        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }
    }
}
