namespace GestorAutoMarket.Vista
{
    partial class FrmAddVehiculo
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
            label6 = new Label();
            txtBxMarca = new TextBox();
            txtBxModelo = new TextBox();
            nUDPrecio = new NumericUpDown();
            nUDAnio = new NumericUpDown();
            comBxCategorias = new ComboBox();
            chBxEstado = new CheckBox();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDAnio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 157);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 232);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 301);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Categoría";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 367);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // txtBxMarca
            // 
            txtBxMarca.Location = new Point(238, 25);
            txtBxMarca.Name = "txtBxMarca";
            txtBxMarca.Size = new Size(249, 31);
            txtBxMarca.TabIndex = 6;
            // 
            // txtBxModelo
            // 
            txtBxModelo.Location = new Point(238, 82);
            txtBxModelo.Name = "txtBxModelo";
            txtBxModelo.Size = new Size(249, 31);
            txtBxModelo.TabIndex = 7;
            // 
            // nUDPrecio
            // 
            nUDPrecio.DecimalPlaces = 2;
            nUDPrecio.Location = new Point(238, 232);
            nUDPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUDPrecio.Name = "nUDPrecio";
            nUDPrecio.Size = new Size(180, 31);
            nUDPrecio.TabIndex = 8;
            // 
            // nUDAnio
            // 
            nUDAnio.Location = new Point(238, 155);
            nUDAnio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nUDAnio.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            nUDAnio.Name = "nUDAnio";
            nUDAnio.Size = new Size(180, 31);
            nUDAnio.TabIndex = 9;
            nUDAnio.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // comBxCategorias
            // 
            comBxCategorias.FormattingEnabled = true;
            comBxCategorias.Location = new Point(238, 301);
            comBxCategorias.Name = "comBxCategorias";
            comBxCategorias.Size = new Size(182, 33);
            comBxCategorias.TabIndex = 10;
            // 
            // chBxEstado
            // 
            chBxEstado.AutoSize = true;
            chBxEstado.Location = new Point(238, 367);
            chBxEstado.Name = "chBxEstado";
            chBxEstado.Size = new Size(123, 29);
            chBxEstado.TabIndex = 11;
            chBxEstado.Text = "Disponible";
            chBxEstado.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(591, 395);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(chBxEstado);
            Controls.Add(comBxCategorias);
            Controls.Add(nUDAnio);
            Controls.Add(nUDPrecio);
            Controls.Add(txtBxModelo);
            Controls.Add(txtBxMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddVehiculo";
            Text = "Nuevo Vehiculo";
            Load += FrmAddVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBxMarca;
        private TextBox txtBxModelo;
        private NumericUpDown nUDPrecio;
        private NumericUpDown nUDAnio;
        private ComboBox comBxCategorias;
        private CheckBox chBxEstado;
        private Button btnConfirmar;
    }
}