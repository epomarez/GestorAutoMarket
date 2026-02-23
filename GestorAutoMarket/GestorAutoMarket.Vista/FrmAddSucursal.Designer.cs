namespace GestorAutoMarket.Vista
{
    partial class FrmAddSucursal
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBxNombre = new TextBox();
            txtBxDireccion = new TextBox();
            nUDTelefono = new NumericUpDown();
            comBxEncargado = new ComboBox();
            chkBxDisponible = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDTelefono).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 195);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 3;
            label4.Text = "Vendedor Encargado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 241);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // txtBxNombre
            // 
            txtBxNombre.Location = new Point(295, 62);
            txtBxNombre.Name = "txtBxNombre";
            txtBxNombre.Size = new Size(352, 31);
            txtBxNombre.TabIndex = 5;
            // 
            // txtBxDireccion
            // 
            txtBxDireccion.Location = new Point(295, 106);
            txtBxDireccion.Name = "txtBxDireccion";
            txtBxDireccion.Size = new Size(352, 31);
            txtBxDireccion.TabIndex = 6;
            // 
            // nUDTelefono
            // 
            nUDTelefono.Location = new Point(295, 149);
            nUDTelefono.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nUDTelefono.Minimum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nUDTelefono.Name = "nUDTelefono";
            nUDTelefono.Size = new Size(182, 31);
            nUDTelefono.TabIndex = 7;
            nUDTelefono.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // comBxEncargado
            // 
            comBxEncargado.FormattingEnabled = true;
            comBxEncargado.Location = new Point(295, 195);
            comBxEncargado.Name = "comBxEncargado";
            comBxEncargado.Size = new Size(182, 33);
            comBxEncargado.TabIndex = 8;
            // 
            // chkBxDisponible
            // 
            chkBxDisponible.AutoSize = true;
            chkBxDisponible.Location = new Point(295, 240);
            chkBxDisponible.Name = "chkBxDisponible";
            chkBxDisponible.Size = new Size(153, 29);
            chkBxDisponible.TabIndex = 9;
            chkBxDisponible.Text = "Disponibilidad";
            chkBxDisponible.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(571, 315);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmAddSucursal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkBxDisponible);
            Controls.Add(comBxEncargado);
            Controls.Add(nUDTelefono);
            Controls.Add(txtBxDireccion);
            Controls.Add(txtBxNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddSucursal";
            Text = "Nueva Sucursal";
            Load += FrmAddSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)nUDTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBxNombre;
        private TextBox txtBxDireccion;
        private NumericUpDown nUDTelefono;
        private ComboBox comBxEncargado;
        private CheckBox chkBxDisponible;
        private Button button1;
    }
}