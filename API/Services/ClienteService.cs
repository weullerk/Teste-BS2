using API.DTOs.Cliente;
using AutoMapper;
using Domain.Models.Cliente;
using Infra.Repositories.ClientesRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Services
{
    public class ClienteService
    {
        private IClienteRepository _clienteRepository;
        private IMapper _mapper;

        public void CreateCliente(ClienteWithEnderecoDTO clienteDto)
        {
            Cliente cliente = _mapper.Map<ClienteWithEnderecoDTO, Cliente>(clienteDto);
            _clienteRepository.Add(cliente);
            _clienteRepository.Save();
        }
    }
}
