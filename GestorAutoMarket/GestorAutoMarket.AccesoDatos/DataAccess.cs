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

        // A continuación, se añadirán algunos métodos básicos para gestionar estas colecciones, como agregar nuevos elementos.

        public static bool addCategoriaVehiculo(CategoriaVehiculo categoria)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] == null)
                {
                    categorias[i] = categoria;
                    return true; // Categoría agregada exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        public static bool addVehiculo(Vehiculo vehiculo)
        {
            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (vehiculos[i] == null)
                {
                    vehiculos[i] = vehiculo;
                    return true; // Vehículo agregado exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        public static bool addVendedor(Vendedor vendedor)
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] == null)
                {
                    vendedores[i] = vendedor;
                    return true; // Vendedor agregado exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        public static bool addSucursal(Sucursal sucursal)
        {
            for (int i = 0; i < sucursals.Length; i++)
            {
                if (sucursals[i] == null)
                {
                    sucursals[i] = sucursal;
                    return true; // Sucursal agregada exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        public static bool addCliente(Cliente cliente)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] == null)
                {
                    clientes[i] = cliente;
                    return true; // Cliente agregado exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        public static bool addVehiculoXSucursal(VehiculoXSucursal vehiculoXSucursal)
        {
            for (int i = 0; i < vehiculoXSucursals.Length; i++)
            {
                if (vehiculoXSucursals[i] == null)
                {
                    vehiculoXSucursals[i] = vehiculoXSucursal;
                    return true; // Vehículo por sucursal agregado exitosamente
                }
            }
            return false; // No se pudo agregar, el arreglo está lleno
        }

        // En esta parte se implementarán los métodos para consultar alguno de los arreglos por entero, no por id.
        public static CategoriaVehiculo[] getCategorias()
            {
                return categorias;
            }

        public static Vehiculo[] getVehiculos()
            {
                return vehiculos;
            }

        public static Vendedor[] getVendedores()
            {
                return vendedores;
            }

        public static Sucursal[] getSucursales()
            {
                return sucursals;
            }

        public static Cliente[] getClientes()
            {
                return clientes;
            }

        public static VehiculoXSucursal[] getVehiculoXSucursal()
        {
            return vehiculoXSucursals;
        }
    }
}
