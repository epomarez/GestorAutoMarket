namespace GestorAutoMarket.Vista
{
    partial class FrmAddCliente
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
            txtBxNombre = new TextBox();
            txtBxIdentificacion = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 89);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Identificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 142);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha Nacimiento";
            // 
            // txtBxNombre
            // 
            txtBxNombre.Location = new Point(211, 34);
            txtBxNombre.Name = "txtBxNombre";
            txtBxNombre.Size = new Size(275, 31);
            txtBxNombre.TabIndex = 3;
            // 
            // txtBxIdentificacion
            // 
            txtBxIdentificacion.Location = new Point(211, 86);
            txtBxIdentificacion.Name = "txtBxIdentificacion";
            txtBxIdentificacion.Size = new Size(275, 31);
            txtBxIdentificacion.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(211, 142);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(365, 31);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(639, 221);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 266);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtBxIdentificacion);
            Controls.Add(txtBxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddCliente";
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBxNombre;
        private TextBox txtBxIdentificacion;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnConfirmar;
    }
}