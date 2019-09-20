using API.DTOs.Cliente;
using AutoMapper;
using Domain.Models.Cliente;
using Infra.Repositories.ClientesRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace API.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;
        private IMapper _mapper;

        public ClienteService(IClienteRepository clienteRespository, IMapper mapper)
        {
            _clienteRepository = clienteRespository;
            _mapper = mapper;
        }

        public ClienteWithEnderecoDTO SearchByCodigoAndCpf(int codigo, string cpf)
        {
            List<Cliente> cliente = _clienteRepository.SearchByCriteria(c => c.Codigo == codigo && c.Documento == cpf);
            return _mapper.Map<Cliente, ClienteWithEnderecoDTO>(cliente.FirstOrDefault());
        }

        public ClienteWithEnderecoDTO FindCliente(int codigo)
        {
            Cliente cliente = _clienteRepository.Find(codigo);
            return _mapper.Map<Cliente, ClienteWithEnderecoDTO>(cliente);
        }

        public ClienteWithEnderecoDTO FindClienteByCpf(string cpf)
        {
            List<Cliente> cliente = _clienteRepository.SearchByCriteria(c => c.Documento == cpf);
            return _mapper.Map<Cliente, ClienteWithEnderecoDTO>(cliente.FirstOrDefault());
        }

        public ClienteWithEnderecoDTO CreateCliente(ClienteWithEnderecoDTO clienteDto)
        {
            var check = _clienteRepository.SearchByCriteria(c => c.Documento == clienteDto.Documento);
            if (check.Count > 0) throw new ArgumentException("Cliente já está cadastro");

            Cliente cliente = _mapper.Map<ClienteWithEnderecoDTO, Cliente>(clienteDto);
            _clienteRepository.Add(cliente);
            _clienteRepository.Save();

            return FindClienteByCpf(cliente.Documento);
        }

        public void RemoveCliente(int codigo)
        {
            Cliente cliente = _clienteRepository.Find(codigo);
            _clienteRepository.Remove(cliente);
            _clienteRepository.Save();
        }

        public void UpdateCliente(ClienteWithEnderecoDTO clienteDto)
        {
            Cliente cliente = _mapper.Map<ClienteWithEnderecoDTO, Cliente>(clienteDto);
            _clienteRepository.Update(cliente);
            _clienteRepository.Save();
        }
    }
}
