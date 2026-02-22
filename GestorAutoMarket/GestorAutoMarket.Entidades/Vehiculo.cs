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
    public class Vehiculo
    {
        private int idVehiculo { get; set; }
        private string marca { get; set; }
        private string modelo { get; set; }
        private int anio { get; set; }
        private decimal precio { get; set; }
        private CategoriaVehiculo categoria { get; set; }
        private bool estado { get; set; }

        public Vehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, bool estado)
        {
            this.idVehiculo = idVehiculo;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.precio = precio;
            this.categoria = categoria;
            this.estado = estado;
        }
    }
}
