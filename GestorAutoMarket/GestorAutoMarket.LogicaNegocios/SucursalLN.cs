using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class SucursalLN
    {
        public static bool addSucursal(Sucursal sucursal)
        {
            try
            {
                if (sucursal == null) return false;
                return AccesoDatos.DataAccess.addSucursal(sucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la sucursal: " + ex.Message);
            }
        }

        public static Sucursal[] getSucursales()
        {
            try
            {
                return AccesoDatos.DataAccess.getSucursales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de sucursales: " + ex.Message);
            }
        }
    }
}
