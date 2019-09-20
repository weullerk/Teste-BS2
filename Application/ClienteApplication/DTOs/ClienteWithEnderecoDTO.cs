using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ClienteApplication.DTOs
{
    public class ClienteWithEnderecoDTO : ClienteDTO
    {
        public EnderecoDTO Endereco { get; set; }
    }
}
