using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
namespace SistemaGestionControllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        [HttpGet]
        public static ProductoVendido ObtenerProductoVendidoPorId(int id)
        {
            return SistemaGestionBussiness.ProductoVendidoBussiness.ObtenerProductoVendidoPorId(id);
        }

        [HttpPost]
        public IActionResult AgregarProductoVendido([FromBody]ProductoVendido productoVendido)
        {
            if(SistemaGestionBussiness.ProductoVendidoBussiness.AgregaProductoVendido(productoVendido))
            {
                return Ok(productoVendido);
            }
            else
            {
                return BadRequest("El producto vendido indicado no se ha podido agregar");
            }
        }

        [HttpPost]
        public IActionResult ModificarProductoVendidoPorId([FromBody] ProductoVendido productoVendido, int id)
        {
            if(SistemaGestionBussiness.ProductoVendidoBussiness.ActualizarProductoVendidoPorId(productoVendido, id))
            {
                return Ok(productoVendido);
            }
            else
            {
                return BadRequest("No se ha podido modifcar el producto vendido");
            }
        }

        [HttpDelete]
        public IActionResult EliminarProductoVendidoPorId( int id) 
        {
            if(SistemaGestionBussiness.ProductoVendidoBussiness.BorrarUnProductoVendidoPorId( id))
            {
                return NoContent();
            }
            else
            {
                return NotFound("No se ha encontrado el producto vendido a eliminar");
            }
        }
    }
}
