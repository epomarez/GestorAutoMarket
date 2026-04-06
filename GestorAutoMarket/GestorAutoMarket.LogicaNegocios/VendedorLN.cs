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
    public class VendedorLN
    {
        private static int cantidadVendedores = 0;
        public static int CantidadVendedores => cantidadVendedores;
        public static bool AddVendedor(Vendedor vendedor)
        {
            try
            {
                if (vendedor == null) return false;
                cantidadVendedores++;
                return AccesoDatos.DataAccess.Add(Entidades.TipoEntidad.Vendedor, vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vendedor: " + ex.Message);

            }
        }

        public static Vendedor[] GetVendedores()
        {
            try
            {
                return (Vendedor[])AccesoDatos.DataAccess.GetAll(TipoEntidad.Vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de vendedores: " + ex.Message);
            }
        }
    }
}
