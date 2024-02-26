using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;

namespace SistemaGestionControllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {


        [HttpGet]
        public static Producto ObtenerProductoPorId(int id)
        {
            return SistemaGestionBussiness.ProductoBussiness.ObtenerProductoPorId(id);
        }

        [HttpPost]
        public IActionResult AgregarProducto([FromBody] Producto producto)
        {
            if (SistemaGestionBussiness.ProductoBussiness.AgregaProducto(producto))
            {
                return base.Ok(new { mensaje = "Producto agregado", producto });
            }
            else
            {
                return base.Conflict( new { mensaje = "No se ha podido agregar el producto" });
            }
        }

        [HttpPut("id")]
        public IActionResult ModificarProductoPorId([FromBody]Producto producto)
        {
            if(SistemaGestionBussiness.ProductoBussiness.ActualizarProductoPorId(producto, producto.Id))
            {
                return Ok(producto);
            }
            else
            {
                return BadRequest("No se ha podido modificar el producto");
            }
        }

        [HttpDelete("id")]
        public IActionResult EliminarProductoPorId(Producto producto,int id) 
        {
            if(SistemaGestionBussiness.ProductoBussiness.BorrarUnProductoPorId(producto, id))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
