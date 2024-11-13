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

namespace Concesionario_Nov.Interfaz
{
    public partial class Informe_Ventas : Form
    {
        private readonly string? FacturasXml = Rutas.FacturasXml;
        public Informe_Ventas()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;
            LoadFacturaData();

        }

        private void LoadFacturaData()
        {
            var doc = XDocument.Load(FacturasXml);
            var currentMonth = DateTime.Now.Month;
            var cantidadFacturas = doc.Descendants("Factura")
                                      .Where(f => DateTime.Parse(f.Element("Fecha").Value).Month == currentMonth)
                                      .Count();
            var totalVentas = doc.Descendants("Factura")
             .Where(f => DateTime.TryParse(f.Element("Fecha")?.Value, out var fecha) && fecha.Month == currentMonth)
             .Sum(f => decimal.TryParse(f.Element("Total")?.Value, out var total) ? total : 0);




            Informe_Facturas_Valor.Text = cantidadFacturas.ToString();
            Informe_Monto_Valor.Text = totalVentas.ToString("C");
        }

    }    

}

//// Cargar el XML 
//if (File.Exists(FacturasXml))
//{
//    var doc = XDocument.Load(FacturasXml);
//    var facturasDelMes = doc.Descendants("Factura")
//    .Where(f => DateTime.Parse(f.Element("Fecha").Value).Month == currentMonth &&
//                DateTime.Parse(f.Element("Fecha").Value).Year == currentYear)
//    .ToList();
//    // Calcular el total de ventas
//    decimal totalVentas = facturasDelMes.Sum(f => decimal.Parse(f.Element("Total").Value));

//    // obtener la cantidad de facturas
//    int cantidadFacturas = facturasDelMes.Count;

//    // Pasar esos valores a los labels
//    Informe_Facturas_Valor.Text = cantidadFacturas.ToString();
//    Informe_Monto_Valor.Text = totalVentas.ToString("C");
//}
//else
//{
//    MessageBox.Show("XML file not found.");
//}