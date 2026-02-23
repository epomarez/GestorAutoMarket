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
