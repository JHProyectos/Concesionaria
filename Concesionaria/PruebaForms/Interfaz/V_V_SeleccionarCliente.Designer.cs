namespace PruebaForms.Interfaz
{
    partial class V_V_SeleccionarCliente
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
            Lista_Clientes_Ventas = new ListBox();
            btn_Lista_Clientes_Seleccionar = new Button();
            btn_Lista_Clientes_Cancelar = new Button();
            SuspendLayout();
            this.Load += new System.EventHandler(this.V_V_SeleccionarCliente_Load);

            // 
            // Lista_Clientes_Ventas
            // 
            Lista_Clientes_Ventas.FormattingEnabled = true;
            Lista_Clientes_Ventas.ItemHeight = 15;
            Lista_Clientes_Ventas.Location = new Point(12, 12);
            Lista_Clientes_Ventas.Name = "Lista_Clientes_Ventas";
            Lista_Clientes_Ventas.Size = new Size(168, 154);
            Lista_Clientes_Ventas.TabIndex = 0;
            // 
            // btn_Lista_Clientes_Seleccionar
            // 
            btn_Lista_Clientes_Seleccionar.Location = new Point(173, 190);
            btn_Lista_Clientes_Seleccionar.Name = "btn_Lista_Clientes_Seleccionar";
            btn_Lista_Clientes_Seleccionar.Size = new Size(98, 23);
            btn_Lista_Clientes_Seleccionar.TabIndex = 1;
            btn_Lista_Clientes_Seleccionar.Text = "Seleccionar";
            btn_Lista_Clientes_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // btn_Lista_Clientes_Cancelar
            // 
            btn_Lista_Clientes_Cancelar.Location = new Point(46, 190);
            btn_Lista_Clientes_Cancelar.Name = "btn_Lista_Clientes_Cancelar";
            btn_Lista_Clientes_Cancelar.Size = new Size(98, 23);
            btn_Lista_Clientes_Cancelar.TabIndex = 2;
            btn_Lista_Clientes_Cancelar.Text = "Cancelar";
            btn_Lista_Clientes_Cancelar.UseVisualStyleBackColor = true;
            // 
            // V_V_SeleccionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 234);
            Controls.Add(btn_Lista_Clientes_Cancelar);
            Controls.Add(btn_Lista_Clientes_Seleccionar);
            Controls.Add(Lista_Clientes_Ventas);
            Name = "V_V_SeleccionarCliente";
            Text = "Seleccionar Cliente";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Lista_Clientes_Ventas;
        private Button btn_Lista_Clientes_Seleccionar;
        private Button btn_Lista_Clientes_Cancelar;
    }
}