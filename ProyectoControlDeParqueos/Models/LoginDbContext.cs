

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoControlDeParqueos.Models
{
    public class LoginDbContext : IdentityDbContext<ApplicationUsers>

    {

        public LoginDbContext (DbContextOptions<LoginDbContext> options) : base (options) 
        
        { 
        }

        public DbSet<persona>personas { get; set; }
		public DbSet<Usuario> Usuarios   { get; set; }
		public DbSet<Parqueo> Parqueos { get; set; }
		public DbSet<RegistroVehiculo> RegistroVehiculos { get; set; }
		public DbSet<Tarifa> Tarifas { get; set; }
	}
}
