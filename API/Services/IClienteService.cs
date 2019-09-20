using API.DTOs.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IClienteService
    {
        ClienteWithEnderecoDTO SearchByCodigoAndCpf(int codigo, string cpf);

        ClienteWithEnderecoDTO FindCliente(int codigo);

        ClienteWithEnderecoDTO FindClienteByCpf(string cpf);


        ClienteWithEnderecoDTO CreateCliente(ClienteWithEnderecoDTO clienteDto);

        void RemoveCliente(int codigo);

        void UpdateCliente(ClienteWithEnderecoDTO clienteDto);
    }
}
