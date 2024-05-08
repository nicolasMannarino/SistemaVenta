using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicacionWeb.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
