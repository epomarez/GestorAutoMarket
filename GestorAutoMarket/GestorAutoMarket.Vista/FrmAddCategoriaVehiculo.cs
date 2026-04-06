/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using GestorAutoMarket.Entidades;
using GestorAutoMarket.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GestorAutoMarket.Vista
{
    public partial class FrmAddCategoriaVehiculo : Form
    {
        public FrmAddCategoriaVehiculo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try{
                string nombreCategoria = txtBxNombreCategoria.Text.Trim();
                string descripcionCategoria = txtBxDescripcionCategoria.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría es obligatorio.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxNombreCategoria.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(descripcionCategoria))
                {
                    MessageBox.Show("La descripción de la categoría es obligatoria.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxDescripcionCategoria.Focus();
                    return;
                }

                if (nombreCategoria.Length < 3)
                {
                    MessageBox.Show("El nombre de la categoría debe tener al menos 3 caracteres.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxNombreCategoria.Focus();
                    return;
                }


                CategoriaVehiculo categoriaVehiculo = new CategoriaVehiculo(CategoriaVehiculoLN.cantidadCategorias, 
                    nombreCategoria, descripcionCategoria);
                CategoriaVehiculoLN.addCategoriaVehiculo(categoriaVehiculo);
                MessageBox.Show("Categoría de vehículo agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            } catch(Exception ex){
                MessageBox.Show("Error al registrar Categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
   
        }

        private void LimpiarCampos()
        {
            txtBxNombreCategoria.Clear();
            txtBxDescripcionCategoria.Clear();
            txtBxDescripcionCategoria.Focus();
        }
    }
}
