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
    public class CategoriaVehiculoLN
    {
        public static int cantidadCategorias = 0;
        public static bool addCategoriaVehiculo(CategoriaVehiculo categoria)
        {
            try
            {
                if (categoria == null) return false;
                cantidadCategorias++;
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
