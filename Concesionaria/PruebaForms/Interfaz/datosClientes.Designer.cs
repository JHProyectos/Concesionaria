using PruebaForms.Lógica;
using System;
using System.Windows.Forms;

namespace PruebaForms.Interfaz
{

    public partial class datosClientes : Form
    {
       
        private System.ComponentModel.IContainer components = null;

       
   
        /// <param name="disposing"->true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

 
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            lblClientes = new Label();
            btnResumen = new Button();
            Nuevo_Cliente = new Button();
            Eliminar_Cliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 63);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(722, 228);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += new DataGridViewCellEventHandler(dgvClientes_CellContentClick);
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.Location = new Point(269, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(182, 30);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Datos de Clientes";

            // btnResumen
           
            btnResumen.Location = new Point(12, 297);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(130, 23);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Resumen de Cuenta";
            btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new EventHandler(this.btnResumen_Click);

            // 
            // Nuevo_Cliente
            // 
            Nuevo_Cliente.Location = new Point(148, 297);
            Nuevo_Cliente.Name = "Nuevo_Cliente";
            Nuevo_Cliente.Size = new Size(130, 23);
            Nuevo_Cliente.TabIndex = 3;
            Nuevo_Cliente.Text = "Nuevo Cliente";
            Nuevo_Cliente.UseVisualStyleBackColor = true;
            this.Nuevo_Cliente.Click += new EventHandler(this.Nuevo_Cliente_Click);
            // 
            // Eliminar_Cliente
            // 
            Eliminar_Cliente.Location = new Point(284, 297);
            Eliminar_Cliente.Name = "Eliminar_Cliente";
            Eliminar_Cliente.Size = new Size(130, 23);
            Eliminar_Cliente.TabIndex = 4;
            Eliminar_Cliente.Text = "Eliminar Cliente";
            Eliminar_Cliente.UseVisualStyleBackColor = true;
            this.Eliminar_Cliente.Click += new EventHandler(this.Eliminar_Cliente_Click);
            // 
            // datosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(746, 332);
            Controls.Add(Eliminar_Cliente);
            Controls.Add(Nuevo_Cliente);
            Controls.Add(btnResumen);
            Controls.Add(lblClientes);
            Controls.Add(dgvClientes);
            Name = "datosClientes";
            Text = "Datos de Clientes";
            this.Load += new EventHandler(datosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

       
    }
}


