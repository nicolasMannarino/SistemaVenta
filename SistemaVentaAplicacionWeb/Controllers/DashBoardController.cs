using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicacionWeb.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
