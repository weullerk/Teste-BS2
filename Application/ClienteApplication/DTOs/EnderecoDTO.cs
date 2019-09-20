using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ClienteApplication.DTOs
{
    public class EnderecoDTO
    {
        public int Codigo { get; set; }

        public string Logradouro { get;  set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }
    }
}
