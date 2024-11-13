using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using PruebaForms.Entidades;
using Concesionario_Nov.Entidades;

namespace PruebaForms
{
    public partial class CargarOrdenDeCompra : Form
    {
        private BindingList<Auto> ordenDeCompra; // Lista para mostrar en el DataGridView
        private Auto autoOrdenCompra; // Variable para almacenar los datos del auto cargado de la orden
        private string? rutaAutos = Rutas.DatosAutosXml;

        public CargarOrdenDeCompra()
        {
            InitializeComponent();
            ordenDeCompra = new BindingList<Auto>();
            dataGridViewOrdenCompra.DataSource = ordenDeCompra; // Enlaza el DataGridView con la lista

        }

        // Botón para cargar la orden de compra y mostrarla en el DataGridView
        private void btnCargarOrden_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.Title = "Seleccione el archivo de Orden de Compra";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaOrdenCompra = openFileDialog.FileName;
                    autoOrdenCompra = LeerOrdenDeCompra(rutaOrdenCompra);

                    if (autoOrdenCompra != null)
                    {
                        ordenDeCompra.Clear();
                        ordenDeCompra.Add(autoOrdenCompra); // Muestra el auto cargado en el DataGridView
                        MessageBox.Show("Orden de compra cargada y mostrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo leer la orden de compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Botón para confirmar y aplicar los datos de la orden de compra al archivo de autos
        private void btnConfirmarAplicar_Click(object sender, EventArgs e)
        {
            if (autoOrdenCompra != null)
            {
                ActualizarArchivoAutos(rutaAutos, autoOrdenCompra);
                MessageBox.Show("Archivo de autos actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia la orden de compra para evitar confirmaciones múltiples
                autoOrdenCompra = null;
                ordenDeCompra.Clear();
            }
            else
            {
                MessageBox.Show("Primero debe cargar una orden de compra.", "Orden de Compra no Cargada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para leer los datos de la orden de compra
        private Auto LeerOrdenDeCompra(string rutaOrdenCompra)
        {
            if (!File.Exists(rutaOrdenCompra))
            {
                MessageBox.Show("El archivo de orden de compra no se encontró.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            XDocument ordenDoc = XDocument.Load(rutaOrdenCompra);
            var elementoAuto = ordenDoc.Descendants("Oc").FirstOrDefault();

            if (elementoAuto != null)
            {
                return new Auto
                {
                    Marca = elementoAuto.Element("Marca")?.Value,
                    Modelo = elementoAuto.Element("Modelo")?.Value,
                    Año = int.Parse(elementoAuto.Element("Año")?.Value ?? "0"),
                    Precio = decimal.Parse(elementoAuto.Element("Precio")?.Value ?? "0"),
                    Stock = int.Parse(elementoAuto.Element("Stock")?.Value ?? "0")
                };
            }

            return null;
        }

        // Método para actualizar el archivo de autos con los datos de la orden de compra
        private void ActualizarArchivoAutos(string rutaAutos, Auto autoOrden)
        {
            XDocument autosDoc = XDocument.Load(rutaAutos);
            var autoExistente = autosDoc.Descendants("Auto")
                .FirstOrDefault(a =>
                    (string)a.Element("Marca") == autoOrden.Marca &&
                    (string)a.Element("Modelo") == autoOrden.Modelo &&
                    (int)a.Element("Año") == autoOrden.Año);

            if (autoExistente != null)
            {
                // Actualiza el stock del auto existente
                int stockActual = int.Parse(autoExistente.Element("Stock")?.Value ?? "0");
                autoExistente.SetElementValue("Stock", stockActual + autoOrden.Stock);
            }
            else
            {
                // Agrega un nuevo auto si no existe
                var nuevoAuto = new XElement("Auto",
                    new XElement("Marca", autoOrden.Marca),
                    new XElement("Modelo", autoOrden.Modelo),
                    new XElement("Año", autoOrden.Año),
                    new XElement("Precio", autoOrden.Precio),
                    new XElement("Stock", autoOrden.Stock)
                );

                autosDoc.Root?.Add(nuevoAuto);
            }

            autosDoc.Save(rutaAutos); // Guarda los cambios en el archivo XML
        }
    }
}
