/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
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
        public static int cantidadVehiculos = 0;
        public static bool addVehiculo(Vehiculo vehiculo)
        {
            try
            {
                cantidadVehiculos++;
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
