using GestorAutoMarket.Entidades;
using GestorAutoMarket.LogicaNegocios;
using System;
using System.Collections.Generic;
/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GestorAutoMarket.Vista
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtBxNombre.Text.Trim();
            string identificacionCliente = txtBxIdentificacion.Text.Trim();
            DateTime fechaNacimientoCliente = dtpFechaNacimiento.Value;

            Cliente cliente = new Cliente(ClienteLN.cantidadClientes, identificacionCliente, nombreCliente, fechaNacimientoCliente, DateTime.Today);
            ClienteLN.addCliente(cliente);
            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBxIdentificacion.Clear();
            txtBxNombre.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;

        }
    }
}
