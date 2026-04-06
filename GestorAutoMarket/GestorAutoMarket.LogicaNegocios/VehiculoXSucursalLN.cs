/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class VehiculoXSucursalLN
    {
        private static int cantidadVehiculoXSucursal = 0;
        public static int CantidadVehiculoXSucursal => cantidadVehiculoXSucursal;
        public static bool AddVehiculoXSucursal(VehiculoXSucursal vehiculoSucursal)
        {
            try
            {
                if (vehiculoSucursal == null) return false;
                cantidadVehiculoXSucursal++;
                return AccesoDatos.DataAccess.Add(Entidades.TipoEntidad.VehiculoXSucursal, vehiculoSucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo a la sucursal: " + ex.Message);
            }
        }

        public static VehiculoXSucursal[] GetVehiculosSucursal()
        {
            try
            {
                return (VehiculoXSucursal[])AccesoDatos.DataAccess.GetAll(Entidades.TipoEntidad.VehiculoXSucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vehículos por sucursal: " + ex.Message);
            }
        }
    }
}
