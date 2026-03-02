using Microsoft.AspNetCore.Mvc;
using LaAbejita.Models;

namespace LaAbejita.Controllers
{
    public class InventoryController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Inventory model)
        {
            // Por ahora solo recibimos los datos
            return View();
        }
    }
}
