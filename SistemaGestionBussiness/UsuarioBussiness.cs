using SistemaGestionEntities;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static Usuario ObtenerUsuarioPorId(int id)

        {
            List<Usuario> listaDeUsuarios = UsuarioData.ObtenerUsuario(id);
            Usuario usuarioSeleccionado = listaDeUsuarios.FirstOrDefault();

            return usuarioSeleccionado;
        }

        public static bool AgregarUsuario(Usuario usuario)

        {
            return UsuarioData.CrearUsuario(usuario);
        }

        public static string ObtenerContraseniaPorNombreDeUsuario(string nombreUsuario)
        {
            return UsuarioData.ObtenerContraseniaPorNombreDeUsuario(nombreUsuario);
        }

        public static bool BorrarUnUsuarioPorId(int id)

        {
            return UsuarioData.EliminarUsuario(id);
        }



        public static bool ActualizarUsuarioPorId(Usuario usuario, int id)

        {
            return UsuarioData.ModificarUsuario(usuario, id);
        }
    }
}
