using Microsoft.AspNetCore.Mvc;

namespace Mvc.controller{
    public class LibrosController : Controller{ 
        
        public IActionResult Index(){ /*muestra libros */

            return View();
        }

        public IActionResult Actualizar(){ 
            return View();
        }

        public IActionResult Detalle(){ 
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