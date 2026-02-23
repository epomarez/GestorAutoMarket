using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class VehiculoLN
    {
        public static bool addVehiculo(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo == null) return false;
                return AccesoDatos.DataAccess.addVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo: " + ex.Message);
            }
        }

        public static Vehiculo[] getVehiculos()
        {
            try
            {
                return AccesoDatos.DataAccess.getVehiculos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vehículos: " + ex.Message);
            }
        }
    }
}
