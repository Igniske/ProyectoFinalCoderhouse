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
                return base.Ok(producto);
            }
            else
            {
                return base.Conflict( new { mensaje = "No se ha podido modificar el producto" } );
            }
        }

        [HttpDelete("id")]
        public IActionResult EliminarProductoPorId(int id) 
        {
            if(SistemaGestionBussiness.ProductoBussiness.BorrarUnProductoPorId(id))
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
