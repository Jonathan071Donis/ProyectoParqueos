using System.ComponentModel.DataAnnotations;

namespace ProyectoControlDeParqueos.Models
{
	public class RegistroVehiculo
	{
        internal decimal costoTotal;

        [Key]
		public int idRegistroVehiculo { get; set; }

		[Display(Name = "Placa del vehículo")]
		public string? placa { get; set; }

		[Display(Name = "Marca")]
		public string? marca { get; set; }

		[Display(Name = "Modelo")]
		public string? modelo { get; set; }

		[Display(Name = "Color")]
		public string? color { get; set; }

		[Display(Name = "Fecha de ingreso")]
		[DataType(DataType.DateTime)]
		public DateTime fechaIngreso { get; set; }

		[Display(Name = "Estado")]
		public bool estado { get; set; }

		// Reporte - Total de vehículos ingresados hoy
		public int ReporteVehiculosIngresadosHoy()
		{
			// Lógica para contar vehículos ingresados hoy
			return 0; // Valor de ejemplo
		}
	}
}
