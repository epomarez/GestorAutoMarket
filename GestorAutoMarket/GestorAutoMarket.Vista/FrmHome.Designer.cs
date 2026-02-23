namespace GestorAutoMarket.Vista
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tCMenu = new TabControl();
            tPCategoriaVehiculo = new TabPage();
            tPVehiculo = new TabPage();
            tPSucursal = new TabPage();
            tPVendedor = new TabPage();
            tPCliente = new TabPage();
            dgvInfoArreglos = new DataGridView();
            tCMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfoArreglos).BeginInit();
            SuspendLayout();
            // 
            // tCMenu
            // 
            tCMenu.Controls.Add(tPCategoriaVehiculo);
            tCMenu.Controls.Add(tPVehiculo);
            tCMenu.Controls.Add(tPSucursal);
            tCMenu.Controls.Add(tPVendedor);
            tCMenu.Controls.Add(tPCliente);
            tCMenu.Location = new Point(120, 57);
            tCMenu.Multiline = true;
            tCMenu.Name = "tCMenu";
            tCMenu.SelectedIndex = 0;
            tCMenu.Size = new Size(567, 39);
            tCMenu.TabIndex = 0;
            tCMenu.SelectedIndexChanged += tCMenu_SelectedIndexChanged;
            // 
            // tPCategoriaVehiculo
            // 
            tPCategoriaVehiculo.Location = new Point(4, 34);
            tPCategoriaVehiculo.Name = "tPCategoriaVehiculo";
            tPCategoriaVehiculo.Padding = new Padding(3);
            tPCategoriaVehiculo.Size = new Size(563, 1);
            tPCategoriaVehiculo.TabIndex = 0;
            tPCategoriaVehiculo.Text = "Categorías de Vehículo";
            tPCategoriaVehiculo.UseVisualStyleBackColor = true;
            // 
            // tPVehiculo
            // 
            tPVehiculo.Location = new Point(4, 34);
            tPVehiculo.Name = "tPVehiculo";
            tPVehiculo.Padding = new Padding(3);
            tPVehiculo.Size = new Size(563, 1);
            tPVehiculo.TabIndex = 1;
            tPVehiculo.Text = "Vehiculos";
            tPVehiculo.UseVisualStyleBackColor = true;
            // 
            // tPSucursal
            // 
            tPSucursal.Location = new Point(4, 34);
            tPSucursal.Name = "tPSucursal";
            tPSucursal.Padding = new Padding(3);
            tPSucursal.Size = new Size(559, 1);
            tPSucursal.TabIndex = 2;
            tPSucursal.Text = "Sucursales";
            tPSucursal.UseVisualStyleBackColor = true;
            // 
            // tPVendedor
            // 
            tPVendedor.Location = new Point(4, 34);
            tPVendedor.Name = "tPVendedor";
            tPVendedor.Size = new Size(563, 1);
            tPVendedor.TabIndex = 3;
            tPVendedor.Text = "Vendedores";
            tPVendedor.UseVisualStyleBackColor = true;
            // 
            // tPCliente
            // 
            tPCliente.Location = new Point(4, 34);
            tPCliente.Name = "tPCliente";
            tPCliente.Size = new Size(563, 1);
            tPCliente.TabIndex = 4;
            tPCliente.Text = "Clientes";
            tPCliente.UseVisualStyleBackColor = true;
            // 
            // dgvInfoArreglos
            // 
            dgvInfoArreglos.AllowUserToAddRows = false;
            dgvInfoArreglos.AllowUserToDeleteRows = false;
            dgvInfoArreglos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoArreglos.Location = new Point(120, 94);
            dgvInfoArreglos.MultiSelect = false;
            dgvInfoArreglos.Name = "dgvInfoArreglos";
            dgvInfoArreglos.ReadOnly = true;
            dgvInfoArreglos.RowHeadersWidth = 62;
            dgvInfoArreglos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoArreglos.Size = new Size(855, 357);
            dgvInfoArreglos.TabIndex = 1;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 491);
            Controls.Add(dgvInfoArreglos);
            Controls.Add(tCMenu);
            Name = "FrmHome";
            Text = "FrmHome";
            tCMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInfoArreglos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tCMenu;
        private TabPage tPCategoriaVehiculo;
        private TabPage tPVehiculo;
        private TabPage tPSucursal;
        private TabPage tPVendedor;
        private TabPage tPCliente;
        private DataGridView dgvInfoArreglos;
    }
}