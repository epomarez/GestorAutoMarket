/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 21 de Febrero del 2026
 */

namespace GestorAutoMarket.Entidades
{
    public class Sucursal
    {
        private int idSucursal { get; set; }

        private string nombreSucursal { get; set; }

        private string direccion { get; set; }

        private string telefono { get; set; }

        private Vendedor encargado { get; set; }

        private bool esActiva { get; set; }

        public Sucursal(int idSucursal, string nombreSucursal, string direccion, string telefono, Vendedor encargado, bool esActiva)
        {
            this.idSucursal = idSucursal;
            this.nombreSucursal = nombreSucursal;
            this.direccion = direccion;
            this.telefono = telefono;
            this.encargado = encargado;
            this.esActiva = esActiva;
        }

    }
}
