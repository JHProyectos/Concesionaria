using PruebaForms.Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms.Interfaz
{
    public partial class V_V_SeleccionarCliente : Form
    {
        public V_V_SeleccionarCliente()
        {
            InitializeComponent();
            btn_Lista_Clientes_Seleccionar.Click += Btn_Lista_Clientes_Seleccionar_Click;

        }

        private void V_V_SeleccionarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                LogicaClientes logicaClientes = new LogicaClientes();

                List<Clientes> clientes = logicaClientes.CargarClientes();

                var nombresYApellidos = clientes.Select(c => $"{c.Nombre} {c.Apellido}").ToList();

                Lista_Clientes_Ventas.Items.Clear();

                Lista_Clientes_Ventas.DataSource = nombresYApellidos;
            }
            catch (Exception ex)
            {
                // Handle errors (e.g., file not found, deserialization issues)
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        public event EventHandler<string> ClienteSeleccionado;

       private void Btn_Lista_Clientes_Seleccionar_Click(object sender, EventArgs e)
        {
            if (Lista_Clientes_Ventas.SelectedItem != null)
            {
                string selectedClient = Lista_Clientes_Ventas.SelectedItem.ToString();
                // Raise the event with the selected client
                ClienteSeleccionado?.Invoke(this, selectedClient);
                this.Close(); // Close the selection form
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente.");
            }
        }


    }
}
