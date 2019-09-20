using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Cliente
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> SearchByCriteria(Func<Cliente, bool> criteria);
    }
}
