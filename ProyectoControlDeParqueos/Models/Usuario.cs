
using System.ComponentModel.DataAnnotations;

namespace ProyectoControlDeParqueos.Models
{
	public class Usuario
	{
		[Key]
		public int idUsuario { get; set; }

		[Display(Name = "Nombre de usuario")]
		public string? nombreUsuario { get; set; }

		[Display(Name = "Correo electrónico")]
		[EmailAddress]
		public string? email { get; set; }

		[Display(Name = "Contraseña")]
		[DataType(DataType.Password)]
		public string? password { get; set; }

		[Display(Name = "Fecha de creación")]
		[DataType(DataType.Date)]
		public DateTime fechaCreacion { get; set; }

		[Display(Name = "Estado")]
		public bool estado { get; set; }

		// Reporte - Cantidad de usuarios activos
		public int ReporteUsuariosActivos()
		{
			// Lógica para contar usuarios activos
			return 1; // Valor de ejemplo
		}
	}
}
