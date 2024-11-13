namespace PruebaForms
{
    partial class CargarOrdenDeCompra
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
            btnCargarOrden = new Button();
            btnConfirmarAplicar = new Button();
            dataGridViewOrdenCompra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdenCompra).BeginInit();
            SuspendLayout();
            // 
            // btnCargarOrden
            // 
            btnCargarOrden.Location = new Point(52, 226);
            btnCargarOrden.Name = "btnCargarOrden";
            btnCargarOrden.Size = new Size(165, 23);
            btnCargarOrden.TabIndex = 0;
            btnCargarOrden.Text = "Cargar orden de compra";
            btnCargarOrden.UseVisualStyleBackColor = true;
            btnCargarOrden.Click += btnCargarOrden_Click;
            // 
            // btnConfirmarAplicar
            // 
            btnConfirmarAplicar.Location = new Point(387, 226);
            btnConfirmarAplicar.Name = "btnConfirmarAplicar";
            btnConfirmarAplicar.Size = new Size(75, 23);
            btnConfirmarAplicar.TabIndex = 1;
            btnConfirmarAplicar.Text = "Confirmar";
            btnConfirmarAplicar.UseVisualStyleBackColor = true;
            btnConfirmarAplicar.Click += btnConfirmarAplicar_Click;
            // 
            // dataGridViewOrdenCompra
            // 
            dataGridViewOrdenCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdenCompra.Location = new Point(139, 11);
            dataGridViewOrdenCompra.Name = "dataGridViewOrdenCompra";
            dataGridViewOrdenCompra.Size = new Size(240, 150);
            dataGridViewOrdenCompra.TabIndex = 2;
            // 
            // CargarOrdenDeCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(dataGridViewOrdenCompra);
            Controls.Add(btnConfirmarAplicar);
            Controls.Add(btnCargarOrden);
            Name = "CargarOrdenDeCompra";
            Text = "Cargar Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdenCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarOrden;
        private Button btnConfirmarAplicar;
        private DataGridView dataGridViewOrdenCompra;
    }
}