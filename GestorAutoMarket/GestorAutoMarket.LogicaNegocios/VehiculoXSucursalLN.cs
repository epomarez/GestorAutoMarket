using GestorAutoMarket.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAutoMarket.LogicaNegocios
{
    public class VehiculoXSucursalLN
    {
        public bool addVehiculoSucursal(VehiculoXSucursal vehiculoSucursal)
        {
            try
            {
                if (vehiculoSucursal == null) return false;
                return AccesoDatos.DataAccess.addVehiculoXSucursal(vehiculoSucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo a la sucursal: " + ex.Message);
            }
        }

        public VehiculoXSucursal[] getVehiculosSucursal()
        {
            try
            {
                return AccesoDatos.DataAccess.getVehiculoXSucursal();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vehículos por sucursal: " + ex.Message);
            }
        }
    }
}
