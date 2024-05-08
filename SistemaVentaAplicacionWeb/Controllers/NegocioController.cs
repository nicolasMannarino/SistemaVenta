using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicacionWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
