using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;

namespace SistemaGestionControllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        [HttpGet("obtenerVenta")]

        public List<Venta> ObtenerVentaPorId(int id)
        {
            return SistemaGestionBussiness.VentaBussiness.ObtenerVentaPorId(id);
        }

        [HttpPost]
        public IActionResult AgregarVenta(Venta venta)
        {
            if (SistemaGestionBussiness.VentaBussiness.AgregarVenta(venta))
            {
                return Ok(venta);
            } else 
            {
                return BadRequest();
            }
        }

        [HttpPut("id")]
        public IActionResult ModificarVentaPorId(Venta venta, int id)
        {
            if (SistemaGestionBussiness.VentaBussiness.ActualizarVentaPorId(venta, id))
            {
                return base.Ok(venta);
            } else
            {
                return base.Conflict(new {   message = "No se ha podido modificar la venta indicada"});
            }
        }

        [HttpDelete("id")]
        public IActionResult EliminarVentaPorId(int id)
        {
            if (SistemaGestionBussiness.VentaBussiness.BorrarUnaVentaPorId( id))
            {
                return NoContent();
            }
            else
            {
                return NotFound("No se ha podido eliminar el usuario indicado");
            }
        }
    }
}
