using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoControlDeParqueos.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoControlDeParqueos.Controllers
{
    public class ReporteIngresosController : Controller
    {
        private readonly LoginDbContext _context;

        public ReporteIngresosController(LoginDbContext context)
        {
            _context = context;
        }

        // GET: ReporteIngresos/Index
        public async Task<IActionResult> Index()
        {
            var tarifas = await _context.Tarifas.ToListAsync();
            decimal totalIngresos = tarifas.Sum(t => t.costoPorHora + t.costoPorDia); // Suma de costos por hora y por día

            var reporte = new ReporteIngresos
            {
                Tarifas = tarifas,
                TotalIngresos = totalIngresos
            };

            return View(reporte);
        }
    }
}
