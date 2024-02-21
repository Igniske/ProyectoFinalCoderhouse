using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;

namespace SistemaGestionControllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        [HttpGet("obtenerVenta")]

        public Venta ObtenerVentaPorId(int id)
        {
            return SistemaGestionBussiness.VentaBussiness.ObtenerVentaPorId(id);
        }

        [HttpPut("id")]
        public IActionResult ModificarVentaPorId(Venta venta, int id)
        {
            if (SistemaGestionBussiness.VentaBussiness.ActualizarVentaPorId(venta, id))
            {
                return Ok(venta);
            } else
            {
                return BadRequest("No se ha podido modificar la venta indicada");
            }
        }
    }


}
