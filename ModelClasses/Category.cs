using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Category
    {
        // Indica que esta propiedad es la clave primaria (Primary Key) de la tabla en la base de datos.
        // Es obligatorio en Entity Framework para identificar de forma única cada registro.
        [Key]
        public int Id { get; set; }

        // Especifica que el campo 'Name' es obligatorio, es decir, no puede ser nulo ni vacío.
        // Esto asegura integridad en la base de datos y también valida el dato desde el modelo.
        [Required]

        // Define que el texto máximo permitido para 'Name' es de 30 caracteres.
        // Si se supera ese límite, se muestra el mensaje de error definido.
        // Esto evita errores de longitud en la base de datos y mejora la validación del lado del servidor.
        [StringLength(12, ErrorMessage = "No se pueden escribir más de 12")]
        public string Name { get; set; }

    }
}
