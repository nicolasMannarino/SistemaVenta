using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicacionWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
