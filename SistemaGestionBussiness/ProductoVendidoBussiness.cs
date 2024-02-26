using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static ProductoVendido ObtenerProductoVendidoPorId(int id)

        {
            List<ProductoVendido> listaDeProductosVendidos = ProductoVendidoData.ObtenerProductoVendido(id);
            ProductoVendido productoVendidoSeleccionado = listaDeProductosVendidos.FirstOrDefault();

            return productoVendidoSeleccionado;
        }

        public static bool AgregaProductoVendido(ProductoVendido productoVendido)

        {
            return ProductoVendidoData.CrearProductoVendido(productoVendido);
        }



        public static bool BorrarUnProductoVendidoPorId(ProductoVendido productoVendido, int id)

        {
            return ProductoVendidoData.EliminarProductoVendido(productoVendido, id);
        }



        public static bool ActualizarProductoVendidoPorId(ProductoVendido productoVendido, int id)

        {
            return ProductoVendidoData.ModificarProductoVendido(productoVendido, id);
        }
    }
}
