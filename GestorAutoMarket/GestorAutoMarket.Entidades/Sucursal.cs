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
    public class Sucursal
    {
        public int idSucursal { get; private set; }

        public string nombreSucursal { get; private set; }

        public string direccion { get; private set; }

        public string telefono { get; private set; }

        public Vendedor encargado { get; private set; }

        public bool esActiva { get; private set; }

        public int encargadoID {
            get {return encargado != null ? encargado.id : 0;}
        }

        public string encargadoNombre {
            get {return encargado != null ? encargado.nombreCompleto : string.Empty;}
        }

        public DateTime fechaNacimientoEncargado {
            get {return encargado != null ? encargado.fechaNacimiento : DateTime.MinValue;}
        }

        public DateTime fechaIngresoENcargado {
            get {return encargado != null ? encargado.fechaIngreso : DateTime.MinValue;}
        }

        public string telefonoEncargado {
            get {return encargado != null ? encargado.telefono : string.Empty;}
        }

        public Sucursal(int idSucursal, string nombreSucursal, string direccion, string telefono, Vendedor encargado, bool esActiva)
        {
            this.idSucursal = idSucursal;
            this.nombreSucursal = nombreSucursal;
            this.direccion = direccion;
            this.telefono = telefono;
            this.encargado = encargado;
            this.esActiva = esActiva;
        }

    }
}
