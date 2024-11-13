using Concesionario_Nov.Entidades;
using Concesionario_Nov.Interfaz;
using PruebaForms.Interfaz;

namespace PruebaForms
{
    public partial class Principal : Form
    {
        readonly string? FacturasXml = Rutas.FacturasXml;
        public Principal()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha actual: " + DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void tsmClientes_Click(object sender, EventArgs e)
        {
            datosClientes datosClientes = new datosClientes();
            datosClientes.Show();
        }
        private void tsmProvedoores_Click(object sender, EventArgs e)
        {
            datosProveedores datosProveedores = new datosProveedores();
            datosProveedores.Show();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosProductos datosProductos = new datosProductos();
            datosProductos.Show();
        }
        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaVentas VentanaVentas = new VentanaVentas();
            VentanaVentas.Show();

        }

        private void ingresarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarOrdenDeCompra cargarOrdenDeCompra = new CargarOrdenDeCompra();
            cargarOrdenDeCompra.Show();
        }

        private void Generar_Informe_Click(object sender, EventArgs e)
        {
            try
            {
                Informe_Ventas informe_Ventas = new Informe_Ventas();
                informe_Ventas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}


