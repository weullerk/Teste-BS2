using System;
using System.Collections.Generic;
using System.Text;

namespace API.DTOs.Cliente
{
    public class ClienteWithEnderecoDTO : ClienteDTO
    {
        public EnderecoDTO Endereco { get; set; }
    }
}
