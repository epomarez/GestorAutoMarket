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
        public Vehiculo vehiculo { get; set; }
        public Sucursal sucursal { get; set; }
        public int cantidad { get; set; }

        public VehiculoXSucursal( Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.cantidad = cantidad;
        }

        public int IdSucursal => sucursal?.idSucursal ?? 0;
        public string NombreSucursal => sucursal?.nombreSucursal ?? "Sin sucursal";

        public int IdVehiculo => vehiculo?.idVehiculo ?? 0;
        public string Marca => vehiculo?.marca ?? "Sin marca";
        public string Modelo => vehiculo?.modelo ?? "Sin modelo";
        public int Anio => vehiculo?.anio ?? 0;
        public decimal Precio => vehiculo?.precio ?? 0;
        public string EstadoTexto => vehiculo?.estadoTexto ?? "—";
    }
}
