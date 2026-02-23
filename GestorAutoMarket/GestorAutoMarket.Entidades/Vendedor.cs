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
        public DateTime fechaIngreso { get; private set; }

        public string telefono { get; private set; }

        public Vendedor(int id, string identificacion, string nombreCompleto,
            DateTime fechaNacimiento, DateTime fechaIngreso, string telefono) : base(id, identificacion, nombreCompleto, fechaNacimiento)
        {
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
        }
    }
}
