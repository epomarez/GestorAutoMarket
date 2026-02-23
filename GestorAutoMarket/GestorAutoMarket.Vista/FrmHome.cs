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
using GestorAutoMarket.LogicaNegocios;

namespace GestorAutoMarket.Vista
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void tCMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarGridView();

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            cargarGridView();
        }

        // Este método lo abstraje para evitar repetir código, me permite obtener
        // los datos para el gridview según el TabPage seleccionado
        private void cargarGridView()
        {
            var selectedTab = tCMenu.SelectedTab;
            if (selectedTab == null) return;

            switch (selectedTab.Text)
            {
                case "Categorías de Vehículo":
                    dgvInfoArreglos.DataSource = CategoriaVehiculoLN.getCategoriasVehiculo();
                    break;
                case "Vehiculos":
                    dgvInfoArreglos.DataSource = VehiculoLN.getVehiculos();
                    break;
                case "Clientes":
                    dgvInfoArreglos.DataSource = ClienteLN.getClientes();
                    break;
                case "Sucursales":
                    dgvInfoArreglos.DataSource = SucursalLN.getSucursales();
                    break;
                case "Vendedores":
                    dgvInfoArreglos.DataSource = VendedorLN.getVendedores();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedTab = tCMenu.SelectedTab;
            if (selectedTab == null) return;

            switch (selectedTab.Text) { 
                case "Categorías de Vehículo":
                    FrmAddCategoriaVehiculo frmAddCategoriaVehiculo = new FrmAddCategoriaVehiculo();
                    frmAddCategoriaVehiculo.ShowDialog();
                    break;
                case "Clientes":
                    FrmAddCliente frmAddCliente = new FrmAddCliente();
                    frmAddCliente.ShowDialog();
                    break;
                case "Vehiculos":
                    FrmAddVehiculo frmAddVehiculo = new FrmAddVehiculo();
                    frmAddVehiculo.ShowDialog();
                    break;
                case "Vendedores":
                    FrmVendedor frmAddVendedor = new FrmVendedor();
                    frmAddVendedor.ShowDialog();
                    break;
                case "Sucursales":
                    FrmAddSucursal frmAddSucursal = new FrmAddSucursal();
                    frmAddSucursal.ShowDialog();
                    break;
                case "SucursalXVehiculo":
                    break;
            }
        }
    }
}
