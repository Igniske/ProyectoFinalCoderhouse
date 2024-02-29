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

        [HttpGet("nombreUsuario")]

        public string ObtenerNombreDeUsuarioPorId(int idUsuario)
        {
            return ObtenerUsuarioPorId(idUsuario).Nombre;
        }

        [HttpGet]
        public IActionResult IniciarSesionConDatosIndicados(string nombreUsuario, string contrasenia)
        {
            //Se busca si existe el nombre de usuario proporcionado
            if (SistemaGestionBussiness.UsuarioBussiness.VerificarSiNombreDeUsuarioExiste(nombreUsuario))
            {
                //Se busca la contrasenia perteneciente al nombre de usuario indicado y se compara si esta y la del parametro coinciden
                if(SistemaGestionBussiness.UsuarioBussiness.ObtenerContraseniaPorNombreDeUsuario(nombreUsuario) == contrasenia)
                {
                    return base.Ok();
                }
                return base.Conflict(new { message = "La contrasenia no coincide con el nombre de usuario" });
            }
            return base.Conflict(new { message = "Nombre de usuario no existente" } );
            
            
        }

        [HttpPost]
        public IActionResult AgregarUsuario([FromBody]Usuario usuario)
        {
            if (SistemaGestionBussiness.UsuarioBussiness.AgregarUsuario(usuario))
            {
                return base.Ok(usuario); 
            }
            else
            {
                return base.Conflict(new { message = "No se ha podido agregar el usuario a la base de dato" }); 
            }
        }

        [HttpPut("{id}")]
        public IActionResult ModificarUsuarioPorId([FromBody]Usuario usuario)
        {
            if(SistemaGestionBussiness.UsuarioBussiness.ActualizarUsuarioPorId(usuario, usuario.Id))
            {
                return base.Ok(usuario);
            }
            else
            {
                return base.Conflict( new { message = "No se ha podido modificar el usuario" } );
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuarioPorId( int id)
        {
            if(SistemaGestionBussiness.UsuarioBussiness.BorrarUnUsuarioPorId( id))
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
