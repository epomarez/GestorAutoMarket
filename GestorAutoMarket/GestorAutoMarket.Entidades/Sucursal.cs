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
        public int IdSucursal { get; private set; }

        public string NombreSucursal { get; private set; }

        public string Direccion { get; private set; }

        public string Telefono { get; private set; }

        public Vendedor Encargado { get; private set; }

        public bool EsActiva { get; private set; }

        public int EncargadoID => Encargado != null ? Encargado.Id : 0;

        public string EncargadoNombre => Encargado != null ? Encargado.NombreCompleto : string.Empty;

        public DateTime FechaNacimientoEncargado => Encargado != null ? Encargado.FechaNacimiento : DateTime.MinValue;

        public DateTime FechaIngresoENcargado => Encargado != null ? Encargado.FechaIngreso : DateTime.MinValue;

        public string TelefonoEncargado => Encargado != null ? Encargado.Telefono : string.Empty;

        public Sucursal(int idSucursal, string nombreSucursal, string direccion, string telefono, Vendedor encargado, bool esActiva)
        {
            this.IdSucursal = idSucursal;
            this.NombreSucursal = nombreSucursal;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Encargado = encargado;
            this.EsActiva = esActiva;
        }

    }
}
