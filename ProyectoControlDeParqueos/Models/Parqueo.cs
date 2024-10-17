
using System.ComponentModel.DataAnnotations;

namespace ProyectoControlDeParqueos.Models
{
	public class Parqueo
	{
		[Key]
		public int idParqueo { get; set; }

		[Display(Name = "Nombre del parqueo")]
		public string? nombreParqueo { get; set; }

		[Display(Name = "Ubicación")]
		public string? ubicacion { get; set; }

		[Display(Name = "Capacidad total")]
		public int capacidadTotal { get; set; }

		[Display(Name = "Espacios disponibles")]
		public int espaciosDisponibles { get; set; }

		[Display(Name = "Estado")]
		public bool estado { get; set; }

		// Reporte - Porcentaje de ocupación
		public decimal ReporteOcupacion()
		{
			if (capacidadTotal > 0)
			{
				return (decimal)(capacidadTotal - espaciosDisponibles) / capacidadTotal * 100;
			}
			return 0;
		}
	}
}
