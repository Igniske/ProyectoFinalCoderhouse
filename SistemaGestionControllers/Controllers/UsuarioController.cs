using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionControllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("obtenerUsuario")]

        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            return SistemaGestionBussiness.UsuarioBussiness.ObtenerUsuarioPorId(idUsuario);
        }

        [HttpPost]
        public IActionResult AgregarUsuario([FromBody]Usuario usuario)
        {
            if (SistemaGestionBussiness.UsuarioBussiness.AgregarUsuario(usuario))
            {
                return Ok(usuario); 
            }
            else
            {
                return BadRequest("No se ha podido agregar el usuario a la base de dato"); 
            }
        }

        [HttpPut("{id}")]
        public IActionResult ModificarUsuarioPorId([FromBody]Usuario usuario, int id)
        {
            if(SistemaGestionBussiness.UsuarioBussiness.ActualizarUsuarioPorId(usuario, id))
            {
                return Ok(usuario);
            }
            else
            {
                return BadRequest("No se ha podido modificar el usuario");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuarioPorId(Usuario usuario, int id)
        {
            if(SistemaGestionBussiness.UsuarioBussiness.BorrarUnUsuarioPorId(usuario, id))
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
