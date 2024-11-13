using Concesionario_Nov.Entidades;
using PruebaForms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PruebaForms
{
    public partial class Autos : Form
    {
        private BindingList<Auto> autos;
        private FileSystemWatcher fileWatcher;
        private string rutaArchivo = Rutas.DatosAutosXml; 
        public Autos()
        {
            InitializeComponent();
            autos = new BindingList<Auto>();
            dataGridView1.DataSource = autos;

            // Configura el observador de archivos
            ConfigurarFileWatcher();

            // Carga los datos inicialmente
            CargarDatos();
        }

        private void ConfigurarFileWatcher()
        {
            fileWatcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(rutaArchivo),
                Filter = Path.GetFileName(rutaArchivo),
                NotifyFilter = NotifyFilters.LastWrite
            };

            // Suscribirse al evento Changed
            fileWatcher.Changed += (sender, e) =>
            {
                // Actualiza el DataGridView en el hilo principal
                Invoke(new Action(CargarDatos));
            };

            // Inicia la observación
            fileWatcher.EnableRaisingEvents = true;
        }

        private void CargarDatos()
        {
            autos.Clear();

            if (File.Exists(rutaArchivo))
            {
                // Cargar datos desde el archivo XML
                XDocument xmlDoc = XDocument.Load(rutaArchivo);
                foreach (var elemento in xmlDoc.Descendants("Auto"))
                {
                    autos.Add(new Auto
                    {
                        Marca = elemento.Element("Marca")?.Value,
                        Modelo = elemento.Element("Modelo")?.Value,
                        Año = int.Parse(elemento.Element("Año")?.Value ?? "0"),
                        Precio = decimal.Parse(elemento.Element("Precio")?.Value ?? "0"),
                        Stock = int.Parse(elemento.Element("Stock")?.Value ?? "0")
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarOrdenDeCompra cargarOrdenDeCompra = new CargarOrdenDeCompra();
            cargarOrdenDeCompra.Show();
        }
    }
}
