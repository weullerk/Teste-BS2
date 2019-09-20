using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.Requests;
using API.DTOs.Cliente;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _clienteService;
        private IMapper _mapper;

        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult FindCliente([FromRoute]int codigo)
        {
            ClienteWithEnderecoDTO cliente = _clienteService.FindCliente(codigo);
            return Ok(cliente);
        }

        [HttpGet("{id}/endereco")]
        public IActionResult GetEnderecoCliente(int codigo)
        {
            EnderecoDTO endereco = _clienteService.FindCliente(codigo).Endereco;
            return Ok(endereco);
        }

        [HttpPost]
        public IActionResult CreateCliente([FromBody] CreateClienteRequest clienteRequest)
        {
            try
            { 
                ClienteWithEnderecoDTO clienteDTO = _mapper.Map<CreateClienteRequest, ClienteWithEnderecoDTO>(clienteRequest);
                var cliente = _clienteService.CreateCliente(clienteDTO);
                return Created(String.Empty, cliente);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPut]
        public IActionResult UpdateCliente([FromBody] UpdateClienteRequest clienteRequest)
        {
            try
            {
                ClienteWithEnderecoDTO clienteDTO = _mapper.Map<UpdateClienteRequest, ClienteWithEnderecoDTO>(clienteRequest);
                _clienteService.UpdateCliente(clienteDTO);
                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente([FromRoute] int codigo)
        {
            try
            {
                _clienteService.RemoveCliente(codigo);
                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}