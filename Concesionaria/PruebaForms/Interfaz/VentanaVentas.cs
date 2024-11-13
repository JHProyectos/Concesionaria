using Concesionario_Nov.Entidades;
using PruebaForms.Entidades;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PruebaForms.Interfaz
{
    public partial class VentanaVentas : Form
    {
        private readonly string? FacturasXml = Rutas.FacturasXml; 
        private readonly string? DatosAutosXml = Rutas.DatosAutosXml;
        public VentanaVentas()
        {
            InitializeComponent();
            V_V_Guardar.Click += V_V_Guardar_Click;
        }

        private void VentanaVentas_Load(object sender, EventArgs e)
        {
             CargarXmlEnCheckedListBox2(DatosAutosXml);
        }
        private void V_V_Guardar_Click(object? sender, EventArgs e)
        {
            try
            {
                string nombreCliente = Ventas_Cliente.Text;
                string? producto = checkedListBox2.CheckedItems[0].ToString(); 
                decimal costo = 00; 

                Factura nuevaFactura = new Factura
                {
                    NombreCliente = nombreCliente,
                    Producto = producto,
                    Costo = costo,
                    Fecha = DateTime.Now
                };

                GuardarFactura(nuevaFactura, FacturasXml);
                ActualizarInventario(producto);

                MessageBox.Show("Venta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void GuardarFactura(Factura nuevaFactura, string rutaFacturas)
            {
                XDocument facturasDoc = XDocument.Load(rutaFacturas);

                // Check if an existing invoice with the same client name and product exists
                var facturaExistente = facturasDoc.Descendants("Factura")
                    .FirstOrDefault(f =>
                        (string)f.Element("NombreCliente") == nuevaFactura.NombreCliente &&
                        (string)f.Element("Producto") == nuevaFactura.Producto &&
                        (DateTime)f.Element("Fecha") == nuevaFactura.Fecha);

                if (facturaExistente != null)
                {
                    // Update the cost if the invoice already exists
                    facturaExistente.SetElementValue("Costo", nuevaFactura.Costo);
                }
                else
                {
                    // Add a new invoice if it doesn't exist
                    var nuevaFacturaElement = new XElement("Factura",
                        new XElement("NombreCliente", nuevaFactura.NombreCliente),
                        new XElement("Producto", nuevaFactura.Producto),
                        new XElement("Costo", nuevaFactura.Costo),
                        new XElement("Fecha", nuevaFactura.Fecha)
                    );

                    facturasDoc.Root?.Add(nuevaFacturaElement);
                }

                // Save the changes to the XML file
                facturasDoc.Save(rutaFacturas);
        }

            private void ActualizarInventario(string productoVendido)
            {
            string[] partes = productoVendido.Split(' ');
            string modelo = partes.Length > 1 ? partes[1] : productoVendido; // Extract Modelo

            XDocument doc = XDocument.Load(DatosAutosXml);

            var producto = doc.Descendants("Auto")
                              .FirstOrDefault(a => a.Element("Modelo")?.Value == modelo);

            if (producto != null)
            {
                var stockElement = producto.Element("Stock");
                if (stockElement != null)
                {
                    int stockActual = int.Parse(stockElement.Value);
                    if (stockActual > 0)
                    {
                        stockElement.Value = (stockActual - 1).ToString();
                        doc.Save(DatosAutosXml);
                    }
                    else
                    {
                        throw new Exception($"No hay stock disponible para {modelo}");
                    }
                }
                else
                {
                    throw new Exception($"El elemento Stock no existe para {modelo}");
                }
            }
            else
            {
                throw new Exception($"Producto {modelo} no encontrado en el inventario");
            }
        }
        
        private void CargarXmlEnCheckedListBox2(string DatosAutosXml)
        {
            // Limpia el contenido previo del CheckedListBox
            checkedListBox2.Items.Clear();

            // Cargar el archivo XML en un XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load(DatosAutosXml);

            // Seleccionar todos los nodos <Auto> en el XML
            XmlNodeList autos = doc.SelectNodes("//Auto");

            // Iterar sobre cada nodo <Auto>
            foreach (XmlNode auto in autos)
            {
                // Extraer los valores de Marca, Modelo, Año y Precio
                string marca = auto.SelectSingleNode("Marca")?.InnerText.Trim() ?? "Desconocido";
                string modelo = auto.SelectSingleNode("Modelo")?.InnerText.Trim() ?? "Desconocido";
                string año = auto.SelectSingleNode("Año")?.InnerText.Trim() ?? "Desconocido";
                string precio = auto.SelectSingleNode("Precio")?.InnerText.Trim() ?? "Desconocido";

                // Combinar la información en el formato deseado
                string textoCombinado = $"{marca} {modelo} ({año}) - ${precio}";

                // Agregar la cadena combinada como un ítem en el CheckedListBox
                checkedListBox2.Items.Add(textoCombinado);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                Title = "Selecciona un archivo XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                CargarXmlEnCheckedListBox2(rutaArchivo);
            }
        }

        private void BtnCargarCliente_Click(object sender, EventArgs e)
        {
            var seleccionarClienteForm = new V_V_SeleccionarCliente();
            seleccionarClienteForm.ClienteSeleccionado += SeleccionarClienteForm_ClienteSeleccionado;
            seleccionarClienteForm.ShowDialog();
        }

        private void SeleccionarClienteForm_ClienteSeleccionado(object sender, string cliente)
        {
            // Update the Ventas_Cliente ListBox with the selected client
            Ventas_Cliente.Items.Clear();
            Ventas_Cliente.Items.Add(cliente);
        }
    }
}