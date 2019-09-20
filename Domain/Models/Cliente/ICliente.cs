using Domain.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedWork
{
    public interface ICliente<T> where T : Cliente
    {
    }
}
