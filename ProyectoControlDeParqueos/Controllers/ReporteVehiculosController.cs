using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoControlDeParqueos.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoControlDeParqueos.Controllers
{
    public class ReporteVehiculosController : Controller
    {
        private readonly LoginDbContext _context;

        public ReporteVehiculosController(LoginDbContext context)
        {
            _context = context;
        }

        // GET: ReporteVehiculos/Index
        public async Task<IActionResult> Index()
        {
            var vehiculos = await _context.RegistroVehiculos.ToListAsync();

            var reporte = new ReporteVehiculos
            {
                Vehiculos = vehiculos
            };

            return View(reporte);
        }
    }
}
