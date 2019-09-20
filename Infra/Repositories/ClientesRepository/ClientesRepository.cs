using Domain.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Repositories.ClientesRepository
{
    class ClientesRepository : IClienteRepository
    {
        public IEnumerable<Cliente> SearchByCriteria(Expression<Func<Cliente, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
