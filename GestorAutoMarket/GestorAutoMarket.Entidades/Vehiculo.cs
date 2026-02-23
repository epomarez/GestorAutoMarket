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
        public int idVehiculo { get; private set; }
        public string marca { get; private set; }
        public string modelo { get; private set; }
        public int anio { get; private set; }
        public decimal precio { get; private set; }
        private CategoriaVehiculo categoria { get; set; }

        public int categoriaId 
        {
            get { return categoria != null ? categoria.idCategoria : 0; }
        }

        public string nombreCategoria
        {
            get { return categoria != null ? categoria.nombreCategoria : "Sin categoría"; }
        }

        public string descripcionCategoria
        {
            get { return categoria != null ? categoria.descripcion : "Sin descripción"; }
        }

        public bool estado { get; private set; }

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
