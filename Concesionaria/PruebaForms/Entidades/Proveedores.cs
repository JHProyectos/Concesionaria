using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    public class Proveedores
    {
       public Proveedores(){
            }
       
        public Proveedores(string nombre, string apellido, string cuit, string dni, string telefono, string direccion, string email, decimal cuentaBancariaID, decimal saldo)
        {
            Nombre = nombre;
            Apellido = apellido;
            CUIT = cuit;
            DNI = dni;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            CuentaBancariaID = cuentaBancariaID;
            Saldo = saldo;

        }
        public string? Nombre { get; set; } //El "?" al final de la declaración de tipo se pone por el error CS8618 que the avisa de la nulidad de una propiedad
        public string? Apellido { get; set; }
        public string? CUIT { get; set; }
        public string? DNI { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public decimal CuentaBancariaID { get; set; } // Relación con Banco
        public decimal Saldo { get; set; }
    }
}




