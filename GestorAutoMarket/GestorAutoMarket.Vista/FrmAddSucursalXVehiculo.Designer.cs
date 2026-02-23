namespace GestorAutoMarket.Vista
{
    partial class FrmAddSucursalXVehiculo
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
            label1 = new Label();
            label2 = new Label();
            comBxSucursal = new ComboBox();
            comBxVehiculo = new ComboBox();
            btnConfirmar = new Button();
            label3 = new Label();
            nUDCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 39);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 134);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Vehiculo";
            // 
            // comBxSucursal
            // 
            comBxSucursal.FormattingEnabled = true;
            comBxSucursal.Location = new Point(210, 39);
            comBxSucursal.Name = "comBxSucursal";
            comBxSucursal.Size = new Size(182, 33);
            comBxSucursal.TabIndex = 2;
            // 
            // comBxVehiculo
            // 
            comBxVehiculo.FormattingEnabled = true;
            comBxVehiculo.Location = new Point(210, 134);
            comBxVehiculo.Name = "comBxVehiculo";
            comBxVehiculo.Size = new Size(182, 33);
            comBxVehiculo.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(438, 218);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 205);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // nUDCantidad
            // 
            nUDCantidad.Location = new Point(212, 203);
            nUDCantidad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nUDCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDCantidad.Name = "nUDCantidad";
            nUDCantidad.Size = new Size(180, 31);
            nUDCantidad.TabIndex = 6;
            nUDCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmAddSucursalXVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 283);
            Controls.Add(nUDCantidad);
            Controls.Add(label3);
            Controls.Add(btnConfirmar);
            Controls.Add(comBxVehiculo);
            Controls.Add(comBxSucursal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddSucursalXVehiculo";
            Text = "Asociar SucursalXVehiculo";
            Load += FrmAddSucursalXVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)nUDCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comBxSucursal;
        private ComboBox comBxVehiculo;
        private Button btnConfirmar;
        private Label label3;
        private NumericUpDown nUDCantidad;
    }
}