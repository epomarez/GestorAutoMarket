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
using System.Windows.Forms;

namespace GestorAutoMarket.Vista
{
    public partial class FrmAddSucursalXVehiculo : Form
    {
        public FrmAddSucursalXVehiculo()
        {
            InitializeComponent();
        }

        private void FrmAddSucursalXVehiculo_Load(object sender, EventArgs e)
        {
            CargarSucursalesEnComboBox();
            CargarVehiculosEnComboBox();

        }

        private void CargarSucursalesEnComboBox() {
            try
            {
                Sucursal[] sucursales = SucursalLN.getSucursales();

                int count = 0;
                for (int i = 0; i < sucursales.Length; i++)
                {
                    if (sucursales[i] != null)
                        count++;
                }

                Sucursal[] sucursalesValidas = new Sucursal[count];
                int index = 0;

                for (int i = 0; i < sucursales.Length; i++)
                {
                    if (sucursales[i] != null)
                    {
                        sucursalesValidas[index++] = sucursales[i];
                    }
                }

                comBxSucursal.DataSource = sucursalesValidas;
                comBxSucursal.DisplayMember = "NombreSucursal";   // ← Muestra el nombre de la sucursal
                comBxSucursal.ValueMember = "IdSucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVehiculosEnComboBox() {
            try
            {
                Vehiculo[] vehiculos = VehiculoLN.getVehiculos();

                int count = 0;
                for (int i = 0; i < vehiculos.Length; i++)
                {
                    if (vehiculos[i] != null)
                        count++;
                }

                Vehiculo[] vehiculosValidos = new Vehiculo[count];
                int index = 0;

                for (int i = 0; i < vehiculos.Length; i++)
                {
                    if (vehiculos[i] != null)
                    {
                        vehiculosValidos[index++] = vehiculos[i];
                    }
                }

                comBxVehiculo.DataSource = vehiculosValidos;
                comBxVehiculo.DisplayMember = "Marca";           // ← Muestra la marca (puedes mejorar esto)
                comBxVehiculo.ValueMember = "IdVehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try{
                if (comBxSucursal.SelectedItem == null || comBxVehiculo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una sucursal y un vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                    Sucursal sucursalSeleccionada = (Sucursal)comBxSucursal.SelectedItem;
                    Vehiculo vehiculoSeleccionado = (Vehiculo)comBxVehiculo.SelectedItem;
                    int cantidad = (int)nUDCantidad.Value;

                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    VehiculoXSucursalLN.addVehiculoXSucursal(
                        new VehiculoXSucursal(sucursalSeleccionada, vehiculoSeleccionado, cantidad));
                }
    
                Limpiarcampos();
            }
            catch(Exception ex){
                MessageBox.Show("Error al registrar SucursalXVehiculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiarcampos()
        {
            comBxSucursal.SelectedItem = null;
            comBxVehiculo.SelectedItem = null;
            nUDCantidad.Value = 1;
            comBxSucursal.Focus();
        }
    }
}
