﻿using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicacionWeb.Controllers
{
    public class PlantillaController : Controller
    {
        public IActionResult EnviarClave(string correo, string clave)
        {
            ViewData["Correo"] = correo;
            ViewData["Clave"] = clave;
            ViewData["Url"] = $"{this.Request.Scheme}://{this.Request.Host}";

            return View();
        }

        public IActionResult RestablecerClave()
        {
            return View();
        }
    }
}
