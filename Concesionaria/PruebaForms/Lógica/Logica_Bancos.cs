using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Concesionario_Nov.Entidades;
using PruebaForms.Entidades;

namespace PruebaForms.Lógica
{
    public class LogicaBancos
    {
        private List<Clientes>? clientes;
        private List<Proveedores>? proveedores;
        private Bancos? cuentaEmpresa;
        private readonly string? archivoClientesXml = Rutas.ArchivoClientesXml; 
        private readonly string? archivoProveedoresXml = Rutas.ArchivoProveedoresXml; 
        private readonly string? archivoCuentaEmpresaXml = Rutas.ArchivoCuentaEmpresaXml;
        public LogicaBancos()
        {
            Console.WriteLine("DIRECTORIO: " + AppDomain.CurrentDomain.BaseDirectory);
            CargarDatos();
        }

        private void CargarDatos()
        {
            clientes = CargarClientes();
            proveedores = CargarProveedores();
            cuentaEmpresa = CargarCuentaEmpresa();
        }

        private List<Clientes> CargarClientes()
        {
            if (File.Exists(archivoClientesXml))
            {
                XDocument doc = XDocument.Load(archivoClientesXml);
                return doc.Descendants("Clientes")
                    .Select(c => new Clientes
                    {
                        Nombre = c.Element("Nombre")?.Value ?? string.Empty,
                        Apellido = c.Element("Apellido")?.Value ?? string.Empty,
                        CUIT = c.Element("CUIT")?.Value ?? string.Empty,
                        DNI = c.Element("DNI")?.Value ?? string.Empty,
                        Telefono = c.Element("Telefono")?.Value ?? string.Empty,
                        Direccion = c.Element("Direccion")?.Value ?? string.Empty,
                        Email = c.Element("Email")?.Value ?? string.Empty,
                        CuentaBancariaID = int.Parse(c.Element("CuentaBancariaID")?.Value ?? "0"),
                        Saldo = decimal.Parse(c.Element("Saldo")?.Value ?? "0")
                        
                    }).ToList();
            }
            return new List<Clientes>();
        }

        private List<Proveedores> CargarProveedores()
        {
            if (File.Exists(archivoProveedoresXml))
            {
                XDocument doc = XDocument.Load(archivoProveedoresXml);
                return doc.Descendants("Proveedores")
                    .Select(p => new Proveedores
                    {
                        Nombre = p.Element("Nombre")?.Value ?? string.Empty,
                        Apellido = p.Element("Apellido")?.Value ?? string.Empty,
                        CUIT = p.Element("CUIT")?.Value ?? string.Empty,
                        DNI = p.Element("DNI")?.Value ?? string.Empty,
                        Telefono = p.Element("Telefono")?.Value ?? string.Empty,
                        Direccion = p.Element("Direccion")?.Value ?? string.Empty,
                        Email = p.Element("Email")?.Value ?? string.Empty,
                        CuentaBancariaID = int.Parse(p.Element("CuentaBancariaID")?.Value ?? "0"),
                        Saldo = decimal.Parse(p.Element("Saldo")?.Value ?? "0")
                    }).ToList();
            }
            return new List<Proveedores>();
        }

        private Bancos CargarCuentaEmpresa()
        {
            if (File.Exists(archivoCuentaEmpresaXml))
            {
                XDocument doc = XDocument.Load(archivoCuentaEmpresaXml);
                var cuentaElement = doc.Element("CuentaEmpresa");
                return new Bancos(
                    int.Parse(cuentaElement.Element("Id")?.Value ?? "0"),
                    cuentaElement.Element("Titular")?.Value?? string.Empty,
                    decimal.Parse(cuentaElement.Element("Saldo")?.Value?? "0"),
                    "Empresa"
                );
            }
            return new Bancos(1, "Empresa", 0, "Empresa"); // Default account if not found
        }

        public bool RecibirPagoDeCliente(int cuentaClienteID, decimal monto)
        {
            var cliente = clientes.FirstOrDefault(c => c.CuentaBancariaID == cuentaClienteID);
            if (cliente != null && cliente.Saldo >= monto)
            {
                cliente.Saldo -= monto;
                cuentaEmpresa.Depositar(monto);
                GuardarCambios();
                return true;
            }
            return false;
        }

        public bool PagarAProveedor(int cuentaProveedorID, decimal monto)
        {
            var proveedor = proveedores.FirstOrDefault(p => p.CuentaBancariaID == cuentaProveedorID);
            if (proveedor != null && cuentaEmpresa.Saldo >= monto)
            {
                cuentaEmpresa.Extraer(monto);
                proveedor.Saldo += monto;
                GuardarCambios();
                return true;
            }
            return false;
        }

        private void GuardarCambios()
        {
            GuardarClientes();
            GuardarProveedores();
            GuardarCuentaEmpresa();
        }

        private void GuardarClientes()
        {
            XDocument doc = new XDocument(
                new XElement("ArrayOfClientes",
                    clientes.Select(c => new XElement("Clientes",
                        new XElement("Nombre", c.Nombre),
                        new XElement("Apellido", c.Apellido),
                        new XElement("CUIT", c.CUIT),
                        new XElement("DNI", c.DNI),
                        new XElement("Telefono", c.Telefono),
                        new XElement("Direccion", c.Direccion),
                        new XElement("Email", c.Email),
                        new XElement("CuentaBancariaID", c.CuentaBancariaID),
                        new XElement("Saldo", c.Saldo)
                    ))
                )
            );
            doc.Save(archivoClientesXml);
        }

        private void GuardarProveedores()
        {
            XDocument doc = new XDocument(
                new XElement("ArrayOfProveedores",
                    proveedores.Select(p => new XElement("Proveedores",
                        new XElement("Nombre", p.Nombre),
                        new XElement("Apellido", p.Apellido),
                        new XElement("CUIT", p.CUIT),
                        new XElement("DNI", p.DNI),
                        new XElement("Telefono", p.Telefono),
                        new XElement("Direccion", p.Direccion),
                        new XElement("Email", p.Email),
                        new XElement("CuentaBancariaID", p.CuentaBancariaID),
                        new XElement("Saldo", p.Saldo)
                    ))
                )
            );
            doc.Save(archivoProveedoresXml);
        }

        private void GuardarCuentaEmpresa()
        {
            XDocument doc = new XDocument(
                new XElement("CuentaEmpresa",
                    new XElement("Id", cuentaEmpresa.Id),
                    new XElement("Titular", cuentaEmpresa.Titular),
                    new XElement("Saldo", cuentaEmpresa.Saldo)
                )
            );
            doc.Save(archivoCuentaEmpresaXml);
        }
    }
}