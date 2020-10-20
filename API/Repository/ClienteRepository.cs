using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class ClienteRepository
    {
        private readonly ApiContext _context;

        //CONSTRUTOR
        public ClienteRepository(ApiContext context) {
            _context = context;
        }

        public async Task Create(Cliente cliente) {
            _context.Add(cliente); //adiciona obj
            await _context.SaveChangesAsync();//salva no banco
        }

        public async Task Update(Cliente cliente) {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Cliente cliente) {
            _context.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cliente>> Find()
        {
            return await _context.Cliente.ToListAsync();
        }

    }
}
