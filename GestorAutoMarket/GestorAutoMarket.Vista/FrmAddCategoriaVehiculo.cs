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
            string nombreCategoria = txtBxNombreCategoria.Text.Trim();
            string descripcionCategoria = txtBxDescripcionCategoria.Text.Trim();
            CategoriaVehiculo categoriaVehiculo = new CategoriaVehiculo(CategoriaVehiculoLN.cantidadCategorias, 
                nombreCategoria, descripcionCategoria);
            CategoriaVehiculoLN.addCategoriaVehiculo(categoriaVehiculo);
            MessageBox.Show("Categoría de vehículo agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBxNombreCategoria.Clear();
            txtBxDescripcionCategoria.Clear();
        }
    }
}
