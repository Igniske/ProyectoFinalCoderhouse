using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionController.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
