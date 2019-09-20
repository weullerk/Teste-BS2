using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Requests
{
    public class UpdateClienteRequest
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; }

        EnderecoUpdateClienteRequest Endereco { get; set; }

    }

    public class EnderecoUpdateClienteRequest
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
