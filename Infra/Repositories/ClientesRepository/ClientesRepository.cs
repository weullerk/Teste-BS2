using Domain.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Repositories.ClientesRepository
{
    public class ClientesRepository : IClienteRepository
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
        }

        public void Remove(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
