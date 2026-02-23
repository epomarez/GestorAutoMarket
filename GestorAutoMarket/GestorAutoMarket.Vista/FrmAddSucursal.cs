using GestorAutoMarket.Entidades;
using GestorAutoMarket.LogicaNegocios;
using System;
/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAutoMarket.Vista
{
    public partial class FrmAddSucursal : Form
    {
        public FrmAddSucursal()
        {
            InitializeComponent();
        }

        private void FrmAddSucursal_Load(object sender, EventArgs e)
        {
            string nombre = txtBxNombre.Text.Trim();
            string direccion = txtBxDireccion.Text.Trim();
            string telefono = nUDTelefono.Value.ToString();
            Vendedor vendedorSeleccionado;
            if (comBxEncargado.SelectedIndex == null)
            {
                MessageBox.Show("Por favor, seleccione un encargado válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { 
                vendedorSeleccionado = (Vendedor)comBxEncargado.SelectedItem;
            }
            bool disponible = chkBxDisponible.Checked;
            Sucursal nuevaSucursal = new Sucursal(SucursalLN.cantidadSucursales, nombre, 
                direccion, telefono, vendedorSeleccionado, disponible);
            SucursalLN.addSucursal(nuevaSucursal);

            txtBxDireccion.Clear();
            txtBxNombre.Clear();
            nUDTelefono.Value = 0;
            comBxEncargado.SelectedIndex = -1;
            disponible = false;


        }
    }
}
