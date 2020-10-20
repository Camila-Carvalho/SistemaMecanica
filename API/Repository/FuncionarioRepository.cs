using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class FuncionarioRepository
    {
        private readonly ApiContext _context;

        //CONSTRUTOR
        public FuncionarioRepository(ApiContext context) {
            _context = context;
        }

        public async Task Create(Funcionario funcionario) {
            _context.Add(funcionario); //adiciona obj
            await _context.SaveChangesAsync();//salva no banco
        }

        public async Task Update(Funcionario funcionario) {
            _context.Update(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Funcionario funcionario) {
            _context.Remove(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Funcionario>> Find()
        {
            return await _context.Funcionario.ToListAsync();
        }

    }
}
