using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Models.Cliente
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> SearchByCriteria(Expression<Func<Cliente, bool>> criteria);
    }
}
