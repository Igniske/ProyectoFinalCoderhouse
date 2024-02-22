using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static Producto ObtenerProductoPorId(int id)

        {
            List<Producto> listaDeProductos = ProductoData.ObtenerProducto(id);
            Producto productoSeleccionado = listaDeProductos.FirstOrDefault();

            return productoSeleccionado;
        }

        public static bool AgregaProducto(Producto producto)

        {
            return ProductoData.CrearProducto(producto);
        }



        public static bool BorrarUnProductoPorId(Producto producto, int id)

        {
            return ProductoData.EliminarProducto(producto, id);
        }



        public static bool ActualizarProductoPorId(Producto producto, int id)

        {
            return ProductoData.ModificarProducto(producto, id);
        }
    }
}
