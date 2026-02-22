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
    public class VehiculoXSucursal
    {
        private Vehiculo vehiculo { get; set; }
        private Sucursal sucursal { get; set; }
        private int cantidad { get; set; }

        public VehiculoXSucursal(Vehiculo vehiculo, Sucursal sucursal, int cantidad)
        {
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.cantidad = cantidad;
        }
    }
}
