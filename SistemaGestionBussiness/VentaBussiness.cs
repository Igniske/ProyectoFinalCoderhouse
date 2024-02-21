using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static Venta ObtenerVentaPorId(int id)

        {
            List<Venta> listaDeVentas = VentaData.ObtenerVenta(id);
            Venta ventaSeleccionada = listaDeVentas.FirstOrDefault();

            return ventaSeleccionada;
        }

        public static bool AgregarVenta(Venta venta)

        {
            return VentaData.CrearVenta(venta);
        }



        public static bool BorrarUnaVentaPorId(Venta venta, int id)

        {
            return VentaData.EliminarVenta(venta, id);
        }



        public static bool ActualizarVentaPorId(Venta venta, int id)

        {
            return VentaData.ModificarVenta(venta, id);
        }
    }
}
