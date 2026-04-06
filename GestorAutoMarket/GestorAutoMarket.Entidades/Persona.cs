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
        public int Id { get; private set; }
        public string Identificacion { get; private set; }
        public string NombreCompleto { get; private set; }
        public DateTime FechaNacimiento { get; private set; }

        protected Persona(int id, string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            this.Id = id;
            this.Identificacion = identificacion;
            this.NombreCompleto = nombreCompleto;
            this.FechaNacimiento = fechaNacimiento;
        }


    }
}
