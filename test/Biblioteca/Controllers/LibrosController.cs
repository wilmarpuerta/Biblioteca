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

        public async Task<IActionResult> EliminarLibro(int id)
        {
            var libro = await _dbContext.Libros.FindAsync(id);
            _dbContext.Libros.Remove(libro);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Eliminar");
        }

        public IActionResult Eliminar()
        {
            return View();
        }
        
        public IActionResult Registrar(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(Libro l)
        {
            _dbContext.Libros.Add(l);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Actualizar(){ 
            return View();
        }
    }

}