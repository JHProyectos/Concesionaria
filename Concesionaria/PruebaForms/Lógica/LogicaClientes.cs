using PruebaForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using Concesionario_Nov.Entidades;

namespace PruebaForms.Lógica
{
    public class LogicaClientes
    {
            private List<Clientes> clientes;
        //private readonly string archivoClientesXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Repositorio", "datosClientes.xml");
        private readonly string? archivoClientesXml = Rutas.ArchivoClientesXml;
        public LogicaClientes()
            {
                clientes = CargarClientes(); // Cargar los clientes desde el archivo XML al iniciar
            }            

            // Método para cargar la lista de clientes desde el archivo XML
          
            public List<Clientes> ObtenerClientes()
            {

                return clientes ?? new List<Clientes>();
            }
        public void AgregarCliente(Clientes nuevoCliente)
        {
            clientes.Add(nuevoCliente);
            GuardarClientes(clientes);
        }

        // Método para guardar la lista de clientes en el archivo XML
        public void GuardarClientes(List<Clientes> clientes)
            {
                try
            {
                //eso asegura que el directorio existe
                Directory.CreateDirectory(archivoClientesXml);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Clientes>));
                using (StreamWriter writer = new StreamWriter(archivoClientesXml))
                {
                    serializer.Serialize(writer, clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar clientes: {ex.Message}");
            }
            }

            public List<Clientes> CargarClientes()
            {
                if (File.Exists(archivoClientesXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Clientes>));
                    using (StreamReader reader = new StreamReader(archivoClientesXml))
                    {
                        try
                        {
                        var result = serializer.Deserialize(reader);
                        if (result is List<Clientes> listaClientes)
                        {
                            Console.WriteLine($"Clientes cargados: {listaClientes.Count}");
                            return listaClientes;
                        }
                          // MessageBox.Show($"Clientes cargados: {listaClientes.Count}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar clientes: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo XML no se encontró.");
                }

                return new List<Clientes>(); // Retorna una lista vacía si hay algún problema
            }

           
            // Método para eliminar un cliente
            public void EliminarCliente(Clientes clienteAEliminar)
            {
                clientes.Remove(clienteAEliminar); // Eliminar el cliente de la lista
                GuardarClientes(clientes);  // Guardar los cambios en el archivo XML
            //    OnClientesChanged();
            }

          

        // Obtener un resumen de cuenta del cliente (puedes personalizar este método)
        public string ObtenerResumenCuenta(Clientes cliente)
            {
                return $"Resumen de cuenta de {cliente.Nombre} {cliente.Apellido}:\n\n" +
                       $"DNI: {cliente.DNI}\n" +
                       $"CUIT: {cliente.CUIT}\n" +
                       $"Teléfono: {cliente.Telefono}\n" +
                       $"Dirección: {cliente.Direccion}\n" +
                       $"Email: {cliente.Email}";
            }
        }
    }
