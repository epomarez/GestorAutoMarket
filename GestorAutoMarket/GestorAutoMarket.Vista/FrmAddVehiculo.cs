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
            CargarCategoriasEnComboBox();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try {
                string marca = txtBxMarca.Text.Trim();
                string modelo = txtBxModelo.Text.Trim();
                int anio = (int)nUDAnio.Value;
                decimal precio = nUDPrecio.Value;

                if (string.IsNullOrWhiteSpace(marca))
                {
                    MessageBox.Show("La marca del vehículo es obligatoria.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxMarca.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(modelo))
                {
                    MessageBox.Show("El modelo del vehículo es obligatorio.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxModelo.Focus();
                    return;
                }

                if (anio < 1900 || anio > DateTime.Now.Year + 1)
                {
                    MessageBox.Show($"El año debe estar entre 1900 y {DateTime.Now.Year + 1}.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUDAnio.Focus();
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a cero.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUDPrecio.Focus();
                    return;
                }

                if (comBxCategorias.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría válida.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comBxCategorias.Focus();
                    return;
                }



                //Validacion de estado con Radio Buttons
                CategoriaVehiculo categoriaSeleccionada;
                categoriaSeleccionada = (CategoriaVehiculo)comBxCategorias.SelectedItem;
            

                char estado;
                if (rBtnNuevo.Checked)
                {
                    estado = 'N';
                }
                else if (rBtnUsado.Checked)
                {
                    estado = 'U';
                }
                else
                {
                    MessageBox.Show("Debe seleccionar si el vehículo es Nuevo o Usado.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VehiculoLN.addVehiculo(
                    new Vehiculo(VehiculoLN.cantidadVehiculos, marca, modelo, anio,
                    precio, categoriaSeleccionada, estado));

                MessageBox.Show("Vehículo agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            } catch (Exception ex) {
                MessageBox.Show("Ocurrió un error al agregar el vehículo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LimpiarCampos()
        {
            txtBxMarca.Clear();
            txtBxModelo.Clear();
            nUDAnio.Value = nUDAnio.Minimum;
            nUDPrecio.Value = nUDPrecio.Minimum;
            comBxCategorias.SelectedIndex = -1;
            rBtnNuevo.Checked = false;
            rBtnUsado.Checked = false;
            txtBxMarca.Focus();
        }
        private void CargarCategoriasEnComboBox()
        {
            try {
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las categorías: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
