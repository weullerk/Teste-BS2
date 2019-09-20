using API.Controllers.Requests;
using API.DTOs.Cliente;
using AutoMapper;
using Domain.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ClienteWithEnderecoDTO, Cliente>();
            CreateMap<Cliente, ClienteWithEnderecoDTO>();
            CreateMap<CreateClienteRequest, ClienteWithEnderecoDTO>();
            CreateMap<UpdateClienteRequest, ClienteWithEnderecoDTO>();
        }
    }
}
