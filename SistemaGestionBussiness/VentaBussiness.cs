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
        public static List<Venta> ObtenerVentaPorId(int id)

        {
            List<Venta> listaDeVentas = VentaData.ObtenerVenta(id);

            return listaDeVentas;
        }

        public static bool AgregarVenta(Venta venta)

        {
            return VentaData.CrearVenta(venta);
        }



        public static bool BorrarUnaVentaPorId( int id)

        {
            return VentaData.EliminarVenta( id);
        }



        public static bool ActualizarVentaPorId(Venta venta, int id)

        {
            return VentaData.ModificarVenta(venta, id);
        }
    }
}
