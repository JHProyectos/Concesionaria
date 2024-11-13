
    public class Clientes
    {
        // Constructor por defecto para deserialización
        public Clientes() { }

        // Constructor con parámetros
        public Clientes(string nombre, string apellido, string cuit, string dni, string telefono, string direccion, string email, decimal cuentaBancariaID, decimal saldo)
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


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PruebaForms.Entidades
//{
//    internal class Clientes
//    {
//        private int idCliente;
//        private string nombreCli;
//        private string apellidoCli;
//        private string emailCli;
//        private string telefonoCli;

//        public Clientes()
//        {

//        }

//        public Clientes(int idCliente, string nombreCli, string apellidoCli, string emailCli, string telefonoCli)
//        {
//            this.idCliente = idCliente;
//            this.nombreCli = nombreCli;
//            this.apellidoCli = apellidoCli;
//            this.emailCli = emailCli;
//            this.telefonoCli = telefonoCli;
//        }

//        private int GetidCliente()
//        {
//            return idCliente;
//        }
//        private string GetNombreCli()
//        {
//            return nombreCli;
//        }
//        private string GetApellidoCli()
//        {
//            return apellidoCli;
//        }
//        private string GetEmailCli()
//        {
//            return emailCli;
//        }
//        private string GetTelefonoCli()
//        {
//            return telefonoCli;
//        }

//        private void SetIdCliente(int idCliente)
//        {
//            this.idCliente = idCliente;
//        }
//        private void SetNombreCli(string nombreCli)
//        {
//            this.nombreCli = nombreCli;
//        }
//        private void SetApellidoCli(string apellidoCli)
//        {
//            this.apellidoCli = apellidoCli;
//        }

//        private void SetEmailCli(string emailCli)
//        {
//            this.emailCli = emailCli;
//        }
//        private void SetTelefonoCli(string telefonoCli)
//        {
//            this.telefonoCli = telefonoCli;
//        }
//    }
//}