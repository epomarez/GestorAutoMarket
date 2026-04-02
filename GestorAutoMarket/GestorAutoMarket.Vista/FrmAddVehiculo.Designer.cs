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
            btnConfirmar = new Button();
            groupBox1 = new GroupBox();
            rBtnNuevo = new RadioButton();
            rBtnUsado = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nUDPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDAnio).BeginInit();
            groupBox1.SuspendLayout();
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
            label6.Location = new Point(21, 339);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnUsado);
            groupBox1.Controls.Add(rBtnNuevo);
            groupBox1.Location = new Point(90, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 90);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // rBtnNuevo
            // 
            rBtnNuevo.AutoSize = true;
            rBtnNuevo.Location = new Point(26, 47);
            rBtnNuevo.Name = "rBtnNuevo";
            rBtnNuevo.Size = new Size(89, 29);
            rBtnNuevo.TabIndex = 0;
            rBtnNuevo.TabStop = true;
            rBtnNuevo.Text = "Nuevo";
            rBtnNuevo.UseVisualStyleBackColor = true;
            // 
            // rBtnUsado
            // 
            rBtnUsado.AutoSize = true;
            rBtnUsado.Location = new Point(185, 47);
            rBtnUsado.Name = "rBtnUsado";
            rBtnUsado.Size = new Size(88, 29);
            rBtnUsado.TabIndex = 1;
            rBtnUsado.TabStop = true;
            rBtnUsado.Text = "Usado";
            rBtnUsado.UseVisualStyleBackColor = true;
            // 
            // FrmAddVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnConfirmar);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnConfirmar;
        private GroupBox groupBox1;
        private RadioButton rBtnNuevo;
        private RadioButton rBtnUsado;
    }
}