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
    public class VehiculoLN
    {
        private static int cantidadVehiculos = 0;

        public static int CantidadVehiculos => cantidadVehiculos;
        public static bool AddVehiculo(Vehiculo vehiculo)
        {
            try
            {
                cantidadVehiculos++;
                if (vehiculo == null) return false;
                return AccesoDatos.DataAccess.Add(Entidades.TipoEntidad.Vehiculo, vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo: " + ex.Message);
            }
        }

        public static Vehiculo[] GetVehiculos()
        {
            try
            {
                return (Vehiculo[])AccesoDatos.DataAccess.GetAll(Entidades.TipoEntidad.Vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vehículos: " + ex.Message);
            }
        }
    }
}
