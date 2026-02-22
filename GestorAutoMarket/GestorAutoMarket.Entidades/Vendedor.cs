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
    public class Vendedor : Persona
    {
        private DateTime fechaIngreso { get; set; }

        private string telefono { get; set; }

        public Vendedor(int id, string identificacion, string nombreCompleto,
            DateTime fechaNacimiento, DateTime fechaIngreso, string telefono) : base(id, identificacion, nombreCompleto, fechaNacimiento)
        {
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
        }
    }
}
