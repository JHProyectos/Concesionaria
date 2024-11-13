namespace PruebaForms.Interfaz
{
    partial class VentanaVentas
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
            btn_Crear_Cliente = new Button();
            btnCargarCliente = new Button();
            V_V_CargarProducto = new Button();
            V_V_Cancelar = new Button();
            V_V_Guardar = new Button();
            checkedListBox2 = new CheckedListBox();
            Ventas_Cliente = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Producto";
            // 
            // btn_Crear_Cliente
            // 
            btn_Crear_Cliente.Location = new Point(190, 64);
            btn_Crear_Cliente.Name = "btn_Crear_Cliente";
            btn_Crear_Cliente.Size = new Size(156, 23);
            btn_Crear_Cliente.TabIndex = 5;
            btn_Crear_Cliente.Text = "Crear cliente";
            btn_Crear_Cliente.UseVisualStyleBackColor = true;
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Location = new Point(18, 64);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(156, 23);
            btnCargarCliente.TabIndex = 6;
            btnCargarCliente.Text = "Cargar cliente";
            btnCargarCliente.UseVisualStyleBackColor = true;
            btnCargarCliente.Click += BtnCargarCliente_Click;
            // 
            // V_V_CargarProducto
            // 
            V_V_CargarProducto.Location = new Point(18, 265);
            V_V_CargarProducto.Name = "V_V_CargarProducto";
            V_V_CargarProducto.Size = new Size(156, 23);
            V_V_CargarProducto.TabIndex = 7;
            V_V_CargarProducto.Text = "Cargar producto";
            V_V_CargarProducto.UseVisualStyleBackColor = true;
            V_V_CargarProducto.Click += button3_Click;
            // 
            // V_V_Cancelar
            // 
            V_V_Cancelar.Location = new Point(447, 306);
            V_V_Cancelar.Name = "V_V_Cancelar";
            V_V_Cancelar.Size = new Size(112, 29);
            V_V_Cancelar.TabIndex = 8;
            V_V_Cancelar.Text = "Cancelar";
            V_V_Cancelar.UseVisualStyleBackColor = true;
            // 
            // V_V_Guardar
            // 
            V_V_Guardar.Location = new Point(583, 306);
            V_V_Guardar.Name = "V_V_Guardar";
            V_V_Guardar.Size = new Size(112, 29);
            V_V_Guardar.TabIndex = 9;
            V_V_Guardar.Text = "Guardar";
            V_V_Guardar.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(22, 135);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(601, 112);
            checkedListBox2.TabIndex = 11;
            // 
            // Ventas_Cliente
            // 
            Ventas_Cliente.FormattingEnabled = true;
            Ventas_Cliente.ItemHeight = 15;
            Ventas_Cliente.Location = new Point(72, 22);
            Ventas_Cliente.Name = "Ventas_Cliente";
            Ventas_Cliente.Size = new Size(190, 19);
            Ventas_Cliente.TabIndex = 12;
            // 
            // VentanaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 349);
            Controls.Add(Ventas_Cliente);
            Controls.Add(checkedListBox2);
            Controls.Add(V_V_Guardar);
            Controls.Add(V_V_Cancelar);
            Controls.Add(V_V_CargarProducto);
            Controls.Add(btnCargarCliente);
            Controls.Add(btn_Crear_Cliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaVentas";
            Text = "VentanaVentas";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Crear_Cliente;
        private Button btnCargarCliente;
        private Button V_V_CargarProducto;
        private Button V_V_Cancelar;
        private Button V_V_Guardar;
        private CheckedListBox checkedListBox2;
        private ListBox Ventas_Cliente;
    }
}