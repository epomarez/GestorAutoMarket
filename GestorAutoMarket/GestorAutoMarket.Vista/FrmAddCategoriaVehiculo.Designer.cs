namespace GestorAutoMarket.Vista
{
    partial class FrmAddCategoriaVehiculo
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
            txtBxNombreCategoria = new TextBox();
            txtBxDescripcionCategoria = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 97);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // txtBxNombreCategoria
            // 
            txtBxNombreCategoria.Location = new Point(229, 43);
            txtBxNombreCategoria.Name = "txtBxNombreCategoria";
            txtBxNombreCategoria.Size = new Size(224, 31);
            txtBxNombreCategoria.TabIndex = 2;
            // 
            // txtBxDescripcionCategoria
            // 
            txtBxDescripcionCategoria.Location = new Point(229, 97);
            txtBxDescripcionCategoria.Name = "txtBxDescripcionCategoria";
            txtBxDescripcionCategoria.Size = new Size(224, 31);
            txtBxDescripcionCategoria.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(627, 172);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAddCategoriaVehiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            Controls.Add(btnConfirmar);
            Controls.Add(txtBxDescripcionCategoria);
            Controls.Add(txtBxNombreCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddCategoriaVehiculo";
            Text = "Nueva Categoría de Vehículo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxNombreCategoria;
        private TextBox txtBxDescripcionCategoria;
        private Button btnConfirmar;
    }
}