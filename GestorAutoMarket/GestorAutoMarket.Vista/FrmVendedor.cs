/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorAutoMarket.Entidades;
using GestorAutoMarket.LogicaNegocios;

namespace GestorAutoMarket.Vista
{
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombreVendedor = txtBxNombre.Text.Trim();
            string identificacionVendedor = txtBxIdentificacion.Text.Trim();
            DateTime fechaNacimientoVendedor = dtpFechaNacimiento.Value;
            string telefono = txtBxTelefono.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreVendedor))
            {
                MessageBox.Show("El nombre completo del vendedor es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(identificacionVendedor))
            {
                MessageBox.Show("La identificación del vendedor es obligatoria.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxIdentificacion.Focus();
                return;
            }

            if (identificacionVendedor.Length < 9)
            {
                MessageBox.Show("La identificación debe tener al menos 9 caracteres.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxIdentificacion.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length < 8)
            {
                MessageBox.Show("El teléfono debe tener al menos 8 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxTelefono.Focus();
                return;
            }

            if (fechaNacimientoVendedor >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser hoy o en el futuro.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return;
            }



            Vendedor vendedor = new Vendedor(VendedorLN.cantidadVendedores, 
                identificacionVendedor, nombreVendedor, fechaNacimientoVendedor, DateTime.Today, telefono);
            VendedorLN.addVendedor(vendedor);
            MessageBox.Show("Vendedor registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBxNombre.Clear();
            txtBxIdentificacion.Clear();
            txtBxTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;

        }
    }
}
