using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Cliente
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        List<Cliente> SearchByCriteria(Func<Cliente, bool> criteria);
    }
}
