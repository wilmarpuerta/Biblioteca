using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Mvc.controller{

    public  class UsersController : Controller{

        public readonly BDbibliotecaContext _dbContext;

        public UsersController(BDbibliotecaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _dbContext.Usuarios.ToListAsync());
        }

        public async Task<IActionResult> Show(int id)
        {
            return View(await _dbContext.Usuarios.FirstOrDefaultAsync(l => l.Id == id));
        }

        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _dbContext.Usuarios.FindAsync(id);
            _dbContext.Usuarios.Remove(user);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Delete");
        }

        public IActionResult Delete()
        {
            return View();
        }
        
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario u)
        {
            _dbContext.Usuarios.Add(u);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Update(int id){ 
            return View(await _dbContext.Usuarios.FirstOrDefaultAsync(m => m.Id == id));
        }
        
        [HttpPost]
        public async Task<IActionResult> Update(Usuario u)
        {
            _dbContext.Usuarios.Update(u);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}