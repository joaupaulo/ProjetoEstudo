using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewLife.Contexto;
using NewLife.Models;

namespace NewLife.Controllers
{
    public class ClientesController : Controller
    {
        private ProjetoContexto _projetocontexto;
        public ClientesController(ProjetoContexto projetoContexto)
        {

            _projetocontexto = projetoContexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _projetocontexto.Clientes.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                _projetocontexto.Add(clientes);
                await _projetocontexto.SaveChangesAsync();
                return RedirectToAction("index");
            }

            return View(clientes);

        }
       
        [HttpGet]
        public async  Task<IActionResult> Edit(int? id){

            if(id == null)
            {
                return NotFound();
            }


            var clientes = await _projetocontexto.Clientes.FindAsync(id);

            if(clientes == null)
            {
                return NotFound();

            }

            return View(clientes);

        }



        [HttpPost]
        public async Task<IActionResult> Edit(Clientes clientes)
        {

            if (ModelState.IsValid)
            {
                  _projetocontexto.Update(clientes);
                await _projetocontexto.SaveChangesAsync(clientes);
                return RedirectToAction("Index");

            }

            return View(clientes);

        }


        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {

           if( id == null )
            {
                return NotFound();
            }


            var detalhes = await _projetocontexto.Clientes.FirstOrDefaultAsync(p => p.Id == id);
            if( detalhes == null)
            {
                return NotFound();
            }

            return View(detalhes);

        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var remover = await _projetocontexto.Clientes.FirstOrDefaultAsync(p => p.Id == id);
            if (remover == null)
            {
                return NotFound();
            }

            return View(remover);

        }


        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deletarCliente = await _projetocontexto.Clientes.FindAsync(id);
            _projetocontexto.Clientes.Remove(deletarCliente);
            await _projetocontexto.SaveChangesAsync();
            return RedirectToAction("index");

        }





    }
}
