﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Patinetas.Modelos
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha y hora son obligatorias")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria")]
        public int CantidadVendida { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal PrecioTotal { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        public int IdProducto { get; set; }

        virtual public Inventario? Inventario { get; set; }
    }
}
