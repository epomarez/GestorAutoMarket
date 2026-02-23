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
    public class ClienteLN
    {

        public static int cantidadClientes = 0;
        public static bool addCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null) return false;
                cantidadClientes++;
                return AccesoDatos.DataAccess.addCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
        }

        public static Cliente[] getClientes()
        {
            try
            {
                return AccesoDatos.DataAccess.getClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de clientes: " + ex.Message);
            }
        }
    }
}
