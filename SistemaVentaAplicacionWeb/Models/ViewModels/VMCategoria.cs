﻿using SistemaVenta.Entity;

namespace SistemaVentaAplicacionWeb.Models.ViewModels
{
    public class VMCategoria
    {
        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
    }
}
