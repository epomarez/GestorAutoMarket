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
    public class Persona
    {
        public int id { get; private set; }
        public string identificacion { get; private set; }
        public string nombreCompleto { get; private set; }
        public DateTime fechaNacimiento { get; private set; }

        protected Persona(int id, string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            this.id = id;
            this.identificacion = identificacion;
            this.nombreCompleto = nombreCompleto;
            this.fechaNacimiento = fechaNacimiento;
        }


    }
}
