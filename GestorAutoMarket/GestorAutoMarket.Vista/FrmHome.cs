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
            dgvInfoArreglos.DataSource = null;
            dgvInfoArreglos.AutoGenerateColumns = false;
            dgvInfoArreglos.Columns.Clear();

            switch (selectedTab.Text)
            {
                case "Categorías de Vehículo":
                    dgvInfoArreglos.DataSource = CategoriaVehiculoLN.getCategoriasVehiculo();
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

                    break;
                case "Vehiculos":
                    dgvInfoArreglos.DataSource = VehiculoLN.getVehiculos();

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

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "categoriaId",
                        HeaderText = "ID Categoría"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "nombreCategoria",
                        HeaderText = "Categoría"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "descripcionCategoria",
                        HeaderText = "Descripción de Categoría"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "estado",
                        HeaderText = "Estado"
                    });

                    break;
                case "Clientes":
                    dgvInfoArreglos.DataSource = ClienteLN.getClientes();
                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fechaRegistro",
                        HeaderText = "Fecha de Registro"
                    });

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
                        HeaderText = "Nombre"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fehaNacimiento",
                        HeaderText = "Fecha de Nacimiento"
                    });

                    break;
                case "Sucursales":
                    dgvInfoArreglos.DataSource = SucursalLN.getSucursales();

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

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "encargado",
                        HeaderText = "Encargado"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "esActiva",
                        HeaderText = "Activa"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "encargadoID",
                        HeaderText = "ID de Encargado"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "encargadoNombre",
                        HeaderText = "Nombre de Encargado"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fechaNacimientoEncargado",
                        HeaderText = "Fecha de nacimiento de Encargado"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fechaIngresoENcargado",
                        HeaderText = "Fecha de Ingreso de Encargado"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "telefonoEncargado",
                        HeaderText = "Teléfono de Encargado"
                    });


                    break;
                case "Vendedores":
                    dgvInfoArreglos.DataSource = VendedorLN.getVendedores();
                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fechaIngreso",
                        HeaderText = "Fecha de Ingreso"
                    });

                    dgvInfoArreglos.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "telefono",
                        HeaderText = "Teléfono"
                    });

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

                    break;

            }
        }

        private void btnAniadirElemento_Click(object sender, EventArgs e)
        {
            var selectedTab = tCMenu.SelectedTab;
            if (selectedTab == null) return;

            switch (selectedTab.Text) { 
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
        }
    }
}
