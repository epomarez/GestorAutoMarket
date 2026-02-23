/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
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
        public static int cantidadVehiculoXSucursal = 0;
        public static bool addVehiculoXSucursal(VehiculoXSucursal vehiculoSucursal)
        {
            try
            {
                if (vehiculoSucursal == null) return false;
                cantidadVehiculoXSucursal++;
                return AccesoDatos.DataAccess.addVehiculoXSucursal(vehiculoSucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo a la sucursal: " + ex.Message);
            }
        }

        public static VehiculoXSucursal[] getVehiculosSucursal()
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
