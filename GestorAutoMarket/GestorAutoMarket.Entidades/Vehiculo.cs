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
        public int IdVehiculo { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Anio { get; private set; }
        public decimal Precio { get; private set; }
        private CategoriaVehiculo Categoria { get; set; }

        public int CategoriaId => Categoria != null ? Categoria.IdCategoria : 0;

        public string NombreCategoria
        {
            get { return Categoria != null ? Categoria.NombreCategoria : "Sin categoría"; }
        }

        public string DescripcionCategoria
        {
            get { return Categoria != null ? Categoria.Descripcion : "Sin descripción"; }
        }

        public char Estado { get; private set; }

        public string EstadoTexto => Estado == 'N' ? "Nuevo" : "Usado";

        public Vehiculo(int idVehiculo, string marca, string modelo, int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            this.IdVehiculo = idVehiculo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Estado = estado;
        }
    }
}
