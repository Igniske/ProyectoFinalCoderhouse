using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
