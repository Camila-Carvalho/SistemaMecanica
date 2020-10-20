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
    public class ClienteController : Controller
    {
        //injeção de dependencia
        private readonly ApiContext _context;
        private readonly ClienteRepository _clienteRepository;

        //CONSTRUTOR
        public ClienteController(ApiContext context, ClienteRepository clienteRepository)
        {
            _context = context;
            _clienteRepository = clienteRepository;
        }

        #region PÁGINAS CLIENTE
        //GET
        //lista de todos os clientes
        public async Task<IActionResult> Index()
        {
            var list = await _clienteRepository.Find();
            //return View(await _context.Cliente.ToListAsync());
            return View(list);
        }

        //BUSCAR A PÁGINA para criar cliente
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int?id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            return View(cliente);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var cliente = await _context.Cliente.FirstOrDefaultAsync(c => c.Id == id);
            return View(cliente);
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente) {
            await _clienteRepository.Create(cliente);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            await _clienteRepository.Delete(cliente);
            return RedirectToAction(nameof(Index));
        }
    }
}
