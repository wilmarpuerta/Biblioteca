using Microsoft.AspNetCore.Mvc;

namespace Mvc.controller{
    public class PrestamoController : Controller{ 
        
        public IActionResult Index(){ /*muestra libros */

            return View();
        }

        public IActionResult Renovacion(){ 
            return View();
        }

        public IActionResult Devolucion(){ 
            return View();
        }

        public IActionResult ListarLibrosPrestados(){ 
            return View();
        }

        public IActionResult ListarLibrosDisponibles(){ 
            return View();
        }

        public IActionResult CrearPrestamo(){ 
            return View();
        }

        public IActionResult EditarPrestamo(){ 
            return View();
        }

        public IActionResult EliminarPrestamo(){ 
            return View();
        }




    }

}