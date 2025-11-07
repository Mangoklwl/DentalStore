using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
    // Esta clase representa el contexto principal de la base de datos.
    // Hereda de IdentityDbContext para incluir las tablas y funcionalidades de ASP.NET Identity
    // (usuarios, roles, autenticación, etc.), además de tus propias tablas personalizadas.
    public class ApplicationDBContext : IdentityDbContext
    {
        // Constructor del contexto.
        // Recibe las opciones de configuración (como la cadena de conexión o el proveedor de base de datos)
        // y las pasa al constructor de la clase base (IdentityDbContext).
        // Esto permite que el contexto se configure desde Program.cs mediante inyección de dependencias.
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
             
        }

        // DbSet representa una tabla dentro de la base de datos.
        // En este caso, 'categories' será la tabla que almacene las entidades 'Category'.
        // Entity Framework Core usará esta propiedad para mapear los objetos Category a registros de base de datos.
        public DbSet<Category> categories { get; set; }
    }

}
