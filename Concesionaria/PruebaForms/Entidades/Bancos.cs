using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
    {
        internal class Bancos
        {
            public int Id { get; set; }
            public string Titular { get; set; } // Puede ser cliente, proveedor o empresa
            public decimal Saldo { get; private set; }
            public string Tipo { get; set; }

            // Constructor
            public Bancos(int id, string titular, decimal saldoInicial, string tipo)
            {
                Id = id;
                Titular = titular;
                Saldo = saldoInicial;
                Tipo = tipo;
            }

            // Método para agregar dinero a la cuenta
            public void Depositar(decimal monto)
            {
                if (monto > 0)
                {
                    Saldo += monto;
                }
            }

            // Método para extraer dinero de la cuenta
            public bool Extraer(decimal monto)
            {
                if (monto <= Saldo)
                {
                    Saldo -= monto;
                    return true;
                }
                return false;
            }
        }

    }

