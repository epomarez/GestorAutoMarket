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
    public class SucursalLN
    {
        public static int cantidadSucursales = 0;
        public static bool addSucursal(Sucursal sucursal)
        {
            try
            {
                if (sucursal == null) return false;
                cantidadSucursales++;
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
