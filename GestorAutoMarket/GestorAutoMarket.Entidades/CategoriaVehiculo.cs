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
    public class CategoriaVehiculo
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public string Descripcion { get; set; }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            this.IdCategoria = idCategoria;
            this.NombreCategoria = nombreCategoria;
            this.Descripcion = descripcion;
        }
    }
}
