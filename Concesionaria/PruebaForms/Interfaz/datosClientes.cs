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
    public partial class datosClientes : Form
    {

        private DataGridView? dgvClientes;
        private Label? lblClientes;
        private Button? btnResumen;
        private Button? Nuevo_Cliente;
        private Button? Eliminar_Cliente;


        // Instancia de la clase LogicaClientes
        private LogicaClientes logicaClientes;
        

        public datosClientes()
        {
            InitializeComponent();
            logicaClientes = new LogicaClientes(); // Inicializa la lógica de clientes
           // logicaClientes.ClientesChanged += LogicaClientes_ClientesChanged();
        }

        // Evento Load: cargar los datos cuando el formulario se abre
        public void datosClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        // Método para cargar los clientes en el DataGridView
        public void CargarClientes()
        {
            if (dgvClientes != null)
            {
                dgvClientes.DataSource = null; // Limpiar el DataGridView antes de cargar
                dgvClientes.DataSource = logicaClientes.ObtenerClientes(); // Cargar los datos de los clientes
            }
            else
            {
                MessageBox.Show("Error: DataGridView no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void LogicaClientes_ClientesChanged(object sender, EventArgs e)
        //{
        //    // Refresh the DataGridView when the client list changes
        //    CargarClientes();
        //}


        // Evento para el botón "Nuevo Cliente"
        private void Nuevo_Cliente_Click(object sender, EventArgs e)
        {
            // Abre un formulario para ingresar los datos de un nuevo cliente
            var formularioNuevoCliente = new FormularioNuevoCliente(logicaClientes, this);
            if (formularioNuevoCliente.ShowDialog() == DialogResult.OK)
            {
                logicaClientes.CargarClientes();
            }
           

        }

        // Evento para el botón "Eliminar Cliente"
        private void Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes?.SelectedRows.Count > 0)
            {
                var clienteSeleccionado = dgvClientes.SelectedRows[0].DataBoundItem as Clientes;
                if (clienteSeleccionado != null)
                {
                    var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                    if (confirmacion == DialogResult.Yes)
                    {
                        logicaClientes.EliminarCliente(clienteSeleccionado); // Eliminar el cliente
                        CargarClientes(); // Recargar la lista
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para eliminar.");
            }
        }

        // Evento para el botón "Resumen de Cuenta"
        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (dgvClientes?.SelectedRows.Count > 0)
            {
                var clienteSeleccionado = dgvClientes.SelectedRows[0].DataBoundItem as Clientes;
                if (clienteSeleccionado != null)
                {
                    var resumen = logicaClientes.ObtenerResumenCuenta(clienteSeleccionado);
                    MessageBox.Show(resumen, "Resumen de Cuenta");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para ver el resumen.");
            }
        }

        // Evento para cuando el usuario haga clic en una celda de la tabla
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clienteSeleccionado = dgvClientes?.Rows[e.RowIndex].DataBoundItem as Clientes;
                // Aquí puedes hacer algo con el cliente seleccionado si lo deseas
            }
        }


       
    }
}
