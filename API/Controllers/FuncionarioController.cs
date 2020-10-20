using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class FuncionarioController : Controller
    {
        //injeção de dependencia
        private readonly ApiContext _context;
        private FuncionarioRepository _funcionarioRepository;

        //CONSTRUTOR
        public FuncionarioController(ApiContext context, FuncionarioRepository funcionarioRepository)
        {
            _context = context;
            _funcionarioRepository = funcionarioRepository;
        }

        #region PÁGINAS FUNCIONÁRIO
        //GET
        //lista de todos os funcionarios
        public async Task<IActionResult> Index()
        {
            var list = await _funcionarioRepository.Find();
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var funcionario = await _context.Funcionario.FindAsync(id);
            return View(funcionario);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var funcionario = await _context.Funcionario.FirstOrDefaultAsync(c => c.Id == id);
            return View(funcionario);
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> Create(Funcionario funcionario) {
            await _funcionarioRepository.Create(funcionario);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Funcionario funcionario)
        {
            await _funcionarioRepository.Update(funcionario);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Remove(int id)
        {
            var funcionario = await _context.Funcionario.FindAsync(id);
            await _funcionarioRepository.Delete(funcionario);
            return RedirectToAction(nameof(Index));
        }
    }
}
