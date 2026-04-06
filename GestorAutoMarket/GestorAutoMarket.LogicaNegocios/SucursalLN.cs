/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */

using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

namespace GestorAutoMarket.LogicaNegocios
{
    public class SucursalLN
    {
        private static int cantidadSucursales = 0;

        public static int CantidadSucursales => cantidadSucursales;

        public static bool AddSucursal(Sucursal sucursal)
        {
            try
            {
                if (sucursal == null) return false;
                cantidadSucursales++;
                return AccesoDatos.DataAccess.Add(Entidades.TipoEntidad.Sucursal, sucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la sucursal: " + ex.Message);
            }
        }

        public static Sucursal[] GetSucursales()
        {
            try
            {
                return (Sucursal[])AccesoDatos.DataAccess.GetAll(Entidades.TipoEntidad.Sucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de sucursales: " + ex.Message);
            }
        }
    }
}
