namespace Concesionario_Nov.Interfaz
{
    partial class Informe_Ventas
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
            Titulo_Informe = new Label();
            Informe_Facturas = new Label();
            Informe_Facturas_Valor = new Label();
            Informe_Monto_Valor = new Label();
            Informe_monto = new Label();
            this.Informe_Facturas_Valor = new System.Windows.Forms.Label();
            this.Informe_Monto_Valor = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Titulo_Informe
            // 
            Titulo_Informe.AutoSize = true;
            Titulo_Informe.Font = new Font("Segoe UI", 22F);
            Titulo_Informe.Location = new Point(74, 46);
            Titulo_Informe.Name = "Titulo_Informe";
            Titulo_Informe.Size = new Size(242, 41);
            Titulo_Informe.TabIndex = 0;
            Titulo_Informe.Text = "Informe Mensual";
            // 
            // Informe_Facturas
            // 
            Informe_Facturas.AutoSize = true;
            Informe_Facturas.Font = new Font("Segoe UI", 13F);
            Informe_Facturas.Location = new Point(47, 140);
            Informe_Facturas.Name = "Informe_Facturas";
            Informe_Facturas.Size = new Size(122, 25);
            Informe_Facturas.TabIndex = 1;
            Informe_Facturas.Text = "Total Facturas:";
            // 
            // Informe_Facturas_Valor
            // 
            Informe_Facturas_Valor.AutoSize = true;
            Informe_Facturas_Valor.Font = new Font("Segoe UI", 13F);
            Informe_Facturas_Valor.Location = new Point(224, 140);
            Informe_Facturas_Valor.Name = "Informe_Facturas_Valor";
            Informe_Facturas_Valor.Size = new Size(122, 25);
            Informe_Facturas_Valor.TabIndex = 2;
            Informe_Facturas_Valor.Text = "Total Facturas:";
            // 
            // Informe_Monto_Valor
            // 
            Informe_Monto_Valor.AutoSize = true;
            Informe_Monto_Valor.Font = new Font("Segoe UI", 13F);
            Informe_Monto_Valor.Location = new Point(224, 215);
            Informe_Monto_Valor.Name = "Informe_Monto_Valor";
            Informe_Monto_Valor.Size = new Size(122, 25);
            Informe_Monto_Valor.TabIndex = 4;
            Informe_Monto_Valor.Text = "Total Facturas:";
            // 
            // Informe_monto
            // 
            Informe_monto.AutoSize = true;
            Informe_monto.Font = new Font("Segoe UI", 13F);
            Informe_monto.Location = new Point(47, 215);
            Informe_monto.Name = "Informe_monto";
            Informe_monto.Size = new Size(112, 25);
            Informe_monto.TabIndex = 3;
            Informe_monto.Text = "Monto Total:";
            // 
            // Informe_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 309);
            Controls.Add(Informe_Monto_Valor);
            Controls.Add(Informe_monto);
            Controls.Add(Informe_Facturas_Valor);
            Controls.Add(Informe_Facturas);
            Controls.Add(Titulo_Informe);
            Name = "Informe_Ventas";
            Text = "Informe de Ventas Mensual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo_Informe;
        private Label Informe_Facturas;
        private Label Informe_Facturas_Valor;
        private Label Informe_Monto_Valor;
        private Label Informe_monto;
        
    }
}