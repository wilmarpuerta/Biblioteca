using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Mvc.controller{
    public class LibrosController : Controller{ 
        
        public readonly BDbibliotecaContext _dbContext;

        public LibrosController(BDbibliotecaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _dbContext.Libros.ToListAsync());
        }

        public async Task<IActionResult> Detalle(int id)
        {
            return View(await _dbContext.Libros.FirstOrDefaultAsync(l => l.Id == id));
        }

        public IActionResult Actualizar(){ 
            return View();
        }

         public IActionResult Eliminar(){ 
            return View();
        }

        public IActionResult Registrar(){
            return View();
        }
        

    }

}