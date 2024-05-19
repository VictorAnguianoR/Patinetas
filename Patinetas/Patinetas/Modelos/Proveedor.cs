using System.ComponentModel.DataAnnotations;

namespace Patinetas.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        public string? ClaveProducto { get; set; }

        virtual public ICollection<Inventario> Inventario { get; set; }
    }
}