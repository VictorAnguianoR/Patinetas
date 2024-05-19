﻿using System.ComponentModel.DataAnnotations;

namespace Patinetas.Modelos
{
    public class Inventario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? NombreProducto { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
     
        public int CantidadDisponible { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        public int ProveedorId { get; set; }
        virtual public Proveedor? Proveedor { get; set; }    
    }
}