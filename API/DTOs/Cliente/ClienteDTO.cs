using System;
using System.Collections.Generic;
using System.Text;

namespace API.DTOs.Cliente
{
    public class ClienteDTO
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; }
    }
}
