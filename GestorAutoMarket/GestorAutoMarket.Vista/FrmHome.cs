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
            // Obtener el TabPage seleccionado
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
    }
}
