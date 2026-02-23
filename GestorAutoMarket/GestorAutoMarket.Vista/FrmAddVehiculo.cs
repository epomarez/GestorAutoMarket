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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAutoMarket.Vista
{
    public partial class FrmAddVehiculo : Form
    {
        public FrmAddVehiculo()
        {
            InitializeComponent();
        }

        private void FrmAddVehiculo_Load(object sender, EventArgs e)
        {
            CategoriaVehiculo[] categorias = CategoriaVehiculoLN.getCategoriasVehiculo();
            int count = 0;
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    count++;
                }
            }

            // Crear arreglo temporal con solo las categorías válidas
            CategoriaVehiculo[] categoriasValidas = new CategoriaVehiculo[count];
            int index = 0;
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    categoriasValidas[index++] = categorias[i];
                }
            }

            // Asignar al ComboBox
            comBxCategorias.DataSource = categoriasValidas;
            comBxCategorias.DisplayMember = "NombreCategoria";
            comBxCategorias.ValueMember = "IdCategoria";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string marca = txtBxMarca.Text.Trim();
            string modelo = txtBxModelo.Text.Trim();
            int anio = (int)nUDAnio.Value;
            decimal precio = nUDPrecio.Value;
            CategoriaVehiculo categoriaSeleccionada;
            if (comBxCategorias.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría válida.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { 
                categoriaSeleccionada = (CategoriaVehiculo)comBxCategorias.SelectedItem;
            }
            bool estado = chBxEstado.Checked;

            VehiculoLN.addVehiculo(
                new Vehiculo (VehiculoLN.cantidadVehiculos,marca, modelo, anio,
                precio, categoriaSeleccionada, estado) );

            txtBxMarca.Clear();
            txtBxModelo.Clear();
            nUDAnio.Value = nUDAnio.Minimum;
            nUDPrecio.Value = nUDPrecio.Minimum;
            comBxCategorias.SelectedIndex = -1;
            chBxEstado.Checked = false;

        }
    }
}
