namespace PruebaForms
{
    partial class datosProveedores
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
            btnResumen = new Button();
            lblProveedores = new Label();
            dgvProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(10, 297);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(130, 23);
            btnResumen.TabIndex = 5;
            btnResumen.Text = "Resumen de Cuenta";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedores.Location = new Point(294, 9);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(226, 30);
            lblProveedores.TabIndex = 4;
            lblProveedores.Text = "Datos de Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(10, 53);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(812, 228);
            dgvProveedores.TabIndex = 3;
            // 
            // datosProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 332);
            Controls.Add(btnResumen);
            Controls.Add(lblProveedores);
            Controls.Add(dgvProveedores);
            Name = "datosProveedores";
            Text = "Datos de Proveedores";
            Load += datosProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResumen;
        private Label lblProveedores;
        private DataGridView dgvProveedores;
    }
}