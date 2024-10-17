using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProyectoControlDeParqueos.Models
{
	public class Tarifa
	{
        internal decimal cantidadVehiculos;

        [Key]
		public int idTarifa { get; set; }

		[Display(Name = "Descripción de la tarifa")]
		public string? descripcion { get; set; }

		[Display(Name = "Costo por hora")]
		[Precision(18, 2)]
		public decimal costoPorHora { get; set; }

		[Display(Name = "Costo por día")]
		[Precision(18, 2)]
		public decimal costoPorDia { get; set; }

		[Display(Name = "Estado")]
		public bool estado { get; set; }

		// Reporte - Tarifas activas
		public int ReporteTarifasActivas()
		{
			// Lógica para contar tarifas activas
			return 0; // Valor de ejemplo
		}
	}
}
