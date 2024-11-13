using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using PruebaForms.Lógica;
using PruebaForms.Entidades;

namespace PruebaForms.Interfaz
{
    public partial class FormularioNuevoCliente : Form
    {
        private LogicaClientes logicaClientes;
        private datosClientes datosClientes;
        private ErrorProvider errorProvider;

        public FormularioNuevoCliente(LogicaClientes logica, datosClientes parentForm)
        {
            InitializeComponent();
            this.logicaClientes = logica;
            this.datosClientes = parentForm;
            errorProvider = new ErrorProvider();
        }

        private void FNC_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                if (ValidateInputs())
                {
                    // Crear un nuevo cliente
                    Clientes nuevoCliente = new Clientes
                    {
                        Nombre = FNC_Nombre.Text.Trim(),
                        Apellido = FNC_Apellido.Text.Trim(),
                        DNI = FNC_DNI.Text.Trim(),
                        CUIT = FNC_CUIT.Text.Trim(),
                        Telefono = FNC_Telefono.Text.Trim(),
                        Direccion = FNC_Direccion.Text.Trim(),
                        Email = FNC_Email.Text.Trim(),
                        CuentaBancariaID = int.Parse(FNC_CuentaBancaria.Text.Trim())
                    };

                    logicaClientes.AgregarCliente(nuevoCliente);
                    
                    // Actualizar tabla
                    datosClientes.CargarClientes();

                    MessageBox.Show("Cliente agregado exitosamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (!ValidateNameField(FNC_Nombre, "Nombre"))
                isValid = false;

            if (!ValidateNameField(FNC_Apellido, "Apellido"))
                isValid = false;

            if (!ValidateDNI())
                isValid = false;

            if (!ValidateCUIT())
                isValid = false;

            if (!ValidateEmail())
                isValid = false;

            if (!ValidateCuentaBancaria())
                isValid = false;

            return isValid;
        }

        private bool ValidateNameField(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !Regex.IsMatch(textBox.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider.SetError(textBox, $"{fieldName} debe contener solo letras y espacios.");
                return false;
            }
            errorProvider.SetError(textBox, "");
            return true;
        }

        private bool ValidateDNI()
        {
            if (!Regex.IsMatch(FNC_DNI.Text, @"^\d{7,9}$"))
            {
                errorProvider.SetError(FNC_DNI, "DNI debe contener entre 7 y 9 números.");
                return false;
            }
            errorProvider.SetError(FNC_DNI, "");
            return true;
        }

        private bool ValidateCUIT()
        {
            if (string.IsNullOrWhiteSpace(FNC_CUIT.Text))
            {
                errorProvider.SetError(FNC_CUIT, "");
                return true; // CUIT is optional
            }

            if (!Regex.IsMatch(FNC_CUIT.Text, @"^\d{11,12}$"))
            {
                errorProvider.SetError(FNC_CUIT, "CUIT debe contener entre 11 y 12 números.");
                return false;
            }
            errorProvider.SetError(FNC_CUIT, "");
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(FNC_Email.Text))
            {
                errorProvider.SetError(FNC_Email, "");
                return true; // Email is optional
            }

            if (!new EmailAddressAttribute().IsValid(FNC_Email.Text))
            {
                errorProvider.SetError(FNC_Email, "Email no válido. Debe contener '@' y tener un formato válido.");
                return false;
            }
            errorProvider.SetError(FNC_Email, "");
            return true;
        }

        private bool ValidateCuentaBancaria()
        {
            if (string.IsNullOrWhiteSpace(FNC_CuentaBancaria.Text))
            {
                errorProvider.SetError(FNC_CuentaBancaria, "");
                return true; // Account number is optional
            }

            if (!Regex.IsMatch(FNC_CuentaBancaria.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(FNC_CuentaBancaria, "Cuenta bancaria debe contener exactamente 10 números.");
                return false;
            }
            errorProvider.SetError(FNC_CuentaBancaria, "");
            return true;
        }

        private void LimpiarCampos()
        {
            FNC_Nombre.Clear();
            FNC_Apellido.Clear();
            FNC_DNI.Clear();
            FNC_CUIT.Clear();
            FNC_Telefono.Clear();
            FNC_Direccion.Clear();
            FNC_Email.Clear();
            FNC_CuentaBancaria.Clear();
        }

        private void FNC_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
