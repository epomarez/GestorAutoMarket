using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorAutoMarket.Entidades;

/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 21 de Febrero del 2026
 */
// El objetivo de esta clase es simular una base de datos en memoria, utilizando arreglos para almacenar diferentes entidades relacionadas con el negocio de venta de vehículos.
// Cada arreglo representa una colección de objetos de un tipo específico.
// Esta estructura permite gestionar y acceder a los datos de manera organizada dentro del programa.
namespace GestorAutoMarket.AccesoDatos
{
    public class DataAccess
    {

        private static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        private static Vehiculo[] vehiculos = new Vehiculo[50];
        private static Vendedor[] vendedores = new Vendedor[20];
        private static Sucursal[] sucursals = new Sucursal[5];
        private static Cliente[] clientes = new Cliente[5];
        private static VehiculoXSucursal[] vehiculoXSucursals = new VehiculoXSucursal[100];

        // A continuación, se añadirán algunos métodos básicos para gestionar
        // estas colecciones, como agregar nuevos elementos.

        // Estos métodos genéricos permitn manipular los arreglos según el tipo
        // de entidad con que se quiera trabajar.
        // Se sigue el principio de deep modules antes de shallow modules,
        // para hacer el código más modular y fácil de mantener. Así como
        // reducir la carga cognitiva del desarrolador, haciendo una interfaz de módulos más simple.
        public static bool Add(TipoEntidad tipo, object entidad)
        {
            switch (tipo)
            {
                case TipoEntidad.Categoria: return InternalAdd(categorias, entidad);
                case TipoEntidad.Vehiculo: return InternalAdd(vehiculos, entidad);
                case TipoEntidad.Vendedor: return InternalAdd(vendedores, entidad);
                case TipoEntidad.Sucursal: return InternalAdd(sucursals, entidad);
                case TipoEntidad.Cliente: return InternalAdd(clientes, entidad);
                case TipoEntidad.VehiculoXSucursal: return InternalAdd(vehiculoXSucursals, entidad);
                default : return false;
            }
        }

        private static bool InternalAdd(object[] arreglo, object item)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == null)
                {
                    arreglo[i] = item;
                    return true; // Elemento agregado exitosamente
                }
            }
            return false;
        }


        public static object[] GetAll(TipoEntidad tipo)
        {
            switch (tipo)
            {
                case TipoEntidad.Categoria: return categorias;
                case TipoEntidad.Vehiculo: return vehiculos;
                case TipoEntidad.Vendedor: return vendedores;
                case TipoEntidad.Sucursal: return sucursals;
                case TipoEntidad.Cliente: return clientes;
                case TipoEntidad.VehiculoXSucursal: return vehiculoXSucursals;
                default : return null;
            }
        }
    }
}
