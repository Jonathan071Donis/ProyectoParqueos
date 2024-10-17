using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoControlDeParqueos.Models;

namespace ProyectoControlDeParqueos.Controllers
{
    public class ReporteController : Controller
    {
        private readonly LoginDbContext _context;

        public ReporteController(LoginDbContext context)
        {
            _context = context;
        }

        // GET: Reporte
        public async Task<IActionResult> Index()
        {
            // Obtener datos de los vehículos registrados
            var vehiculos = await _context.RegistroVehiculos.ToListAsync();

            // Obtener tarifas activas
            var tarifas = await _context.Tarifas.Where(t => t.estado).ToListAsync();

            // Obtener datos del parqueo
            var parqueos = await _context.Parqueos.ToListAsync();

            // Crear el modelo de reporte
            var reporte = new ReporteGeneral
            {
                Vehiculos = vehiculos,
                Tarifas = tarifas,
                Parqueos = parqueos
            };

            return View(reporte);
        }
    }
}
