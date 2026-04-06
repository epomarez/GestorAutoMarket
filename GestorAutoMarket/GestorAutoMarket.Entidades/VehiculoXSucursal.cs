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
        public Vehiculo Vehiculo { get; set; }
        public Sucursal Sucursal { get; set; }
        public int Cantidad { get; set; }

        public VehiculoXSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            this.Vehiculo = vehiculo;
            this.Sucursal = sucursal;
            this.Cantidad = cantidad;
        }

        public int IdSucursal => Sucursal?.IdSucursal ?? 0;
        public string NombreSucursal => Sucursal?.NombreSucursal ?? "Sin sucursal";

        public int IdVehiculo => Vehiculo?.IdVehiculo ?? 0;
        public string Marca => Vehiculo?.Marca ?? "Sin marca";
        public string Modelo => Vehiculo?.Modelo ?? "Sin modelo";
        public int Anio => Vehiculo?.Anio ?? 0;
        public decimal Precio => Vehiculo?.Precio ?? 0;
        public string EstadoTexto => Vehiculo?.EstadoTexto ?? "—";
    }
}
