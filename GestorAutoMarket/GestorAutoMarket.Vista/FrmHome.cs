/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */
using GestorAutoMarket.LogicaNegocios;

namespace GestorAutoMarket.Vista
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        // Este método se ejecuta al cambiar de TabPage y recarga el GridView
        // con la información correspondiente
        private void tCMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarGridView();

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            cargarGridView();
        }

        // Este método se ejecuta al hacer clic en el botón "Añadir Elemento" 
        // y abre el formulario correspondiente según el TabPage seleccionado
        private void btnAniadirElemento_Click(object sender, EventArgs e)
        {
            try {
                var selectedTab = tCMenu.SelectedTab;
                if (selectedTab == null) return;

                switch (selectedTab.Text)
                {
                    case "Categorías de Vehículo":
                        FrmAddCategoriaVehiculo frmAddCategoriaVehiculo = new FrmAddCategoriaVehiculo();
                        frmAddCategoriaVehiculo.ShowDialog();
                        cargarGridView();
                        break;
                    case "Clientes":
                        FrmAddCliente frmAddCliente = new FrmAddCliente();
                        frmAddCliente.ShowDialog();
                        cargarGridView();
                        break;
                    case "Vehiculos":
                        FrmAddVehiculo frmAddVehiculo = new FrmAddVehiculo();
                        frmAddVehiculo.ShowDialog();
                        cargarGridView();
                        break;
                    case "Vendedores":
                        FrmVendedor frmAddVendedor = new FrmVendedor();
                        frmAddVendedor.ShowDialog();
                        cargarGridView();
                        break;
                    case "Sucursales":
                        FrmAddSucursal frmAddSucursal = new FrmAddSucursal();
                        frmAddSucursal.ShowDialog();
                        cargarGridView();
                        break;
                    case "SucursalXVehiculo":
                        FrmAddSucursalXVehiculo frmAddSucursalXVehiculo =
                        new FrmAddSucursalXVehiculo();
                        frmAddSucursalXVehiculo.ShowDialog();
                        cargarGridView();
                        break;
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Este método carga el DataSource en el GridView según el TabPage seleccionado
        private void cargarGridView()
        {
            try {
                var selectedTab = tCMenu.SelectedTab;
                if (selectedTab == null) return;
                dgvInfoArreglos.DataSource = null;
                dgvInfoArreglos.AutoGenerateColumns = false;
                dgvInfoArreglos.Columns.Clear();

                switch (selectedTab.Text)
                {
                    case "Categorías de Vehículo":
                        dgvInfoArreglos.DataSource = CategoriaVehiculoLN.getCategoriasVehiculo();
                        ConfigurarColumnasCategorias();
                        break;
                    case "Vehiculos":
                        dgvInfoArreglos.DataSource = VehiculoLN.getVehiculos();
                        ConfigurarColumnasVehiculos();
                        break;
                    case "Clientes":
                        dgvInfoArreglos.DataSource = ClienteLN.getClientes();
                        ConfigurarColumnasClientes();

                        break;
                    case "Sucursales":
                        dgvInfoArreglos.DataSource = SucursalLN.getSucursales();
                        ConfigurarColumnasSucursales();
                        break;
                    case "Vendedores":
                        dgvInfoArreglos.DataSource = VendedorLN.getVendedores();
                        ConfigurarColumnasVendedores();
                        break;
                    case "SucursalXVehiculo":
                        dgvInfoArreglos.DataSource = 
                            VehiculoXSucursalLN.getVehiculosSucursal();
                        ConfigurarColumnasSucursalXVehiculo();
                        break;

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en el grid: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Estos métodos permiten configurar
        // las columnas para el gridview según el TabPage seleccionado
        private  void ConfigurarColumnasCategorias()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idCategoria",
                HeaderText = "ID"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreCategoria",
                HeaderText = "Categoría"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "descripcion",
                HeaderText = "Descripción"
            });
        }
        private void ConfigurarColumnasClientes()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "identificacion",
                HeaderText = "Identificación"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreCompleto",
                HeaderText = "Nombre Completo"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "fehaNacimiento",
                HeaderText = "Fecha de Nacimiento"
            });
        }
        private void ConfigurarColumnasSucursales()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idSucursal",
                HeaderText = "ID"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreSucursal",
                HeaderText = "Nombre"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "direccion",
                HeaderText = "Dirección"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "telefono",
                HeaderText = "Teléfono"
            });
        }

        private void ConfigurarColumnasSucursalXVehiculo()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreSucursal",
                HeaderText = "Sucursal"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Marca",
                HeaderText = "Marca"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Modelo",
                HeaderText = "Modelo"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Anio",
                HeaderText = "Año"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad"
            });

            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoTexto",
                HeaderText = "Estado"
            });
        }
        private void ConfigurarColumnasVehiculos()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idVehiculo",
                HeaderText = "ID"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "marca",
                HeaderText = "Marca"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "modelo",
                HeaderText = "Modelo"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "anio",
                HeaderText = "Año"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "precio",
                HeaderText = "Precio"
            });
        }
        private void ConfigurarColumnasVendedores()
        {
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "identificacion",
                HeaderText = "Identificación"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreCompleto",
                HeaderText = "Nombre Completo"
            });
            dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "fechaNacimiento",
                HeaderText = "Fecha de Nacimiento"
            });
        }

    }
}
