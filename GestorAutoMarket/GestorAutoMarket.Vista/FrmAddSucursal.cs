using GestorAutoMarket.Entidades;
using GestorAutoMarket.LogicaNegocios;
/*
    UNED I Cuatrimestre.
    Proyecto 1: Gestor AutoMarket.
    Descripcion: Este es un proyecto en C# desarrollado en Visual Studio 2022, 
    y forma parte del curso de Programación Avanzada en la UNED (Costa Rica).
    Estudiante: Edrey Pomarez.
    Fecha: 22 de Febrero del 2026
 */

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
            CargarVendedoresEnCombobox();
        }

        private void CargarVendedoresEnCombobox()
        {
            try
            {
                Vendedor[] todosLosVendedores = VendedorLN.getVendedores();

                // Contar cuántos vendedores reales hay
                int count = 0;
                for (int i = 0; i < todosLosVendedores.Length; i++)
                {
                    if (todosLosVendedores[i] != null)
                        count++;
                }

                // Crear un nuevo arreglo solo con los vendedores válidos
                Vendedor[] vendedoresValidos = new Vendedor[count];
                int index = 0;
                for (int i = 0; i < todosLosVendedores.Length; i++)
                {
                    if (todosLosVendedores[i] != null)
                    {
                        vendedoresValidos[index] = todosLosVendedores[i];
                        index++;
                    }
                }

                comBxEncargado.DataSource = vendedoresValidos;
                comBxEncargado.DisplayMember = "NombreCompleto";
                comBxEncargado.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBxNombre.Text.Trim();
                string direccion = txtBxDireccion.Text.Trim();
                string telefono = nUDTelefono.Value.ToString();
                Vendedor vendedorSeleccionado;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre de la sucursal es obligatorio.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(direccion))
                {
                    MessageBox.Show("La dirección de la sucursal es obligatoria.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBxDireccion.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(telefono) || telefono.Length < 8)
                {
                    MessageBox.Show("El teléfono debe tener al menos 8 dígitos.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUDTelefono.Focus();
                    return;
                }



                if (comBxEncargado.SelectedIndex == null)
                {
                    MessageBox.Show("Debe seleccionar un vendedor encargado.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comBxEncargado.Focus();
                    return;
                }

                vendedorSeleccionado = (Vendedor)comBxEncargado.SelectedItem;

                bool disponible = chkBxDisponible.Checked;
                Sucursal nuevaSucursal = new Sucursal(SucursalLN.cantidadSucursales, nombre,
                    direccion, telefono, vendedorSeleccionado, disponible);
                SucursalLN.addSucursal(nuevaSucursal);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar sucursal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtBxDireccion.Clear();
            txtBxNombre.Clear();
            nUDTelefono.Value = 0;
            comBxEncargado.SelectedIndex = -1;
            chkBxDisponible.Checked = false;
        }
    }
}
