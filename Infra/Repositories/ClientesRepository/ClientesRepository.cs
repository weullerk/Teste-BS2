using Domain.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Repositories.ClientesRepository
{
    class ClientesRepository : IClienteRepository
    {

        private readonly ClientesContext _context;

        public ClientesRepository(ClientesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Cliente> SearchByCriteria(Func<Cliente, bool> criteria)
        {
            return _context.Set<Cliente>().AsEnumerable().Where(criteria);
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Remove(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
