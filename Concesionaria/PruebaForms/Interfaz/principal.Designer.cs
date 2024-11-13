namespace PruebaForms
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            tsAcciones = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            tsmClientes = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            tsmProvedoores = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            ingresarVentaToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            ingresarCompraToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tsReportes = new ToolStripMenuItem();
            tsSalir = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            lblFecha = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TITULO = new Label();
            Generar_Informe = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsAcciones, tsReportes, tsSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsAcciones
            // 
            tsAcciones.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, proveedoresToolStripMenuItem, ventasToolStripMenuItem, comprasToolStripMenuItem, stockToolStripMenuItem });
            tsAcciones.Name = "tsAcciones";
            tsAcciones.Size = new Size(67, 20);
            tsAcciones.Text = "Acciones";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmClientes });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsmClientes
            // 
            tsmClientes.Name = "tsmClientes";
            tsmClientes.Size = new Size(165, 22);
            tsmClientes.Text = "Datos de Clientes";
            tsmClientes.Click += tsmClientes_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmProvedoores });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // tsmProvedoores
            // 
            tsmProvedoores.Name = "tsmProvedoores";
            tsmProvedoores.Size = new Size(188, 22);
            tsmProvedoores.Text = "Datos de Proveedores";
            tsmProvedoores.Click += tsmProvedoores_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarVentaToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(180, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ingresarVentaToolStripMenuItem
            // 
            ingresarVentaToolStripMenuItem.Name = "ingresarVentaToolStripMenuItem";
            ingresarVentaToolStripMenuItem.Size = new Size(148, 22);
            ingresarVentaToolStripMenuItem.Text = "Ingresar Venta";
            ingresarVentaToolStripMenuItem.Click += ingresarVentaToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarCompraToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(180, 22);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // ingresarCompraToolStripMenuItem
            // 
            ingresarCompraToolStripMenuItem.Name = "ingresarCompraToolStripMenuItem";
            ingresarCompraToolStripMenuItem.Size = new Size(162, 22);
            ingresarCompraToolStripMenuItem.Text = "Ingresar Compra";
            ingresarCompraToolStripMenuItem.Click += ingresarCompraToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(180, 22);
            stockToolStripMenuItem.Text = "Productos/Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(103, 22);
            toolStripMenuItem1.Text = "Stock";
            // 
            // tsReportes
            // 
            tsReportes.Name = "tsReportes";
            tsReportes.Size = new Size(12, 20);
            // 
            // tsSalir
            // 
            tsSalir.Name = "tsSalir";
            tsSalir.Size = new Size(41, 20);
            tsSalir.Text = "&Salir";
            tsSalir.Click += tsSalir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.Fixed3D;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(589, 303);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(148, 19);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha actual: 1/1/2024";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Location = new Point(588, 433);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 75);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 303);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 3;
            label1.Text = "Valor USD: $1200";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TITULO
            // 
            TITULO.AutoSize = true;
            TITULO.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TITULO.Location = new Point(200, 93);
            TITULO.Name = "TITULO";
            TITULO.Size = new Size(382, 40);
            TITULO.TabIndex = 5;
            TITULO.Text = "GESTION CONCESIONARIA";
            // 
            // Generar_Informe
            // 
            Generar_Informe.Location = new Point(331, 296);
            Generar_Informe.Name = "Generar_Informe";
            Generar_Informe.Size = new Size(111, 32);
            Generar_Informe.TabIndex = 6;
            Generar_Informe.Text = "Generar Informe";
            Generar_Informe.UseVisualStyleBackColor = true;
            Generar_Informe.Click += Generar_Informe_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(772, 352);
            Controls.Add(Generar_Informe);
            Controls.Add(TITULO);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Gestión Concesionaria";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

       

        //private void IngresarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsAcciones;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem tsmClientes;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label lblFecha;
        private ToolStripMenuItem tsReportes;
        private ToolStripMenuItem tsSalir;
        private GroupBox groupBox1;
        private Label label1;
        private ToolStripMenuItem tsmProvedoores;
        private ToolStripMenuItem ingresarVentaToolStripMenuItem;
        private ToolStripMenuItem ingresarCompraToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label TITULO;
        private Button Generar_Informe;
    }
}
