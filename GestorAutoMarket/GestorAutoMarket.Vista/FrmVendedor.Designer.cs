namespace GestorAutoMarket.Vista
{
    partial class FrmVendedor
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
            txtBxIdentificacion = new TextBox();
            txtBxTelefono = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 73);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Identificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 118);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 163);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 208);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 4;
            // 
            // txtBxNombre
            // 
            txtBxNombre.Location = new Point(312, 31);
            txtBxNombre.Name = "txtBxNombre";
            txtBxNombre.Size = new Size(326, 31);
            txtBxNombre.TabIndex = 5;
            // 
            // txtBxIdentificacion
            // 
            txtBxIdentificacion.Location = new Point(312, 73);
            txtBxIdentificacion.Name = "txtBxIdentificacion";
            txtBxIdentificacion.Size = new Size(326, 31);
            txtBxIdentificacion.TabIndex = 6;
            // 
            // txtBxTelefono
            // 
            txtBxTelefono.Location = new Point(312, 163);
            txtBxTelefono.Name = "txtBxTelefono";
            txtBxTelefono.Size = new Size(326, 31);
            txtBxTelefono.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(312, 113);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(326, 31);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(526, 224);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 295);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtBxTelefono);
            Controls.Add(txtBxIdentificacion);
            Controls.Add(txtBxNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVendedor";
            Text = "Nuevo Vendedor";
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
        private TextBox txtBxIdentificacion;
        private TextBox txtBxTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnConfirmar;
    }
}