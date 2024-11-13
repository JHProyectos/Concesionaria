using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    public class Factura
    {
        public string? NombreCliente {  get; set; }
        public string? Producto { get; set; }
        public decimal Costo { get; set; }
        public DateTime Fecha { get; set; }
        public List<Factura>? ListaFacturas { get; set; }
    }
}
