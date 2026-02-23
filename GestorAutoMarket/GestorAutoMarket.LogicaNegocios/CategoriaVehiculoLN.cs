using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class CategoriaVehiculoLN
    {
        public static bool addCategoriaVehiculo(CategoriaVehiculo categoria)
        {
            try
            {
                if (categoria == null) return false;
                return AccesoDatos.DataAccess.addCategoriaVehiculo(categoria);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la categoría de vehículo: " + ex.Message);
            }
        }

        public static CategoriaVehiculo[] getCategoriasVehiculo()
        {
            try
            {
                return AccesoDatos.DataAccess.getCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de categorías de vehículos: " + ex.Message);
            }
        }
    }
}
