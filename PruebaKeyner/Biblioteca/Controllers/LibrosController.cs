using Microsoft.AspNetCore.Mvc;

namespace Mvc.controller{
    public class LibrosController : Controller{ 
        
        public IActionResult Index(){ /*muestra libros */

            return View();
        }

        public IActionResult Actualizar(){ 
            return View();
        }

        





    }

}