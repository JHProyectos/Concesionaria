using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms
{
    public partial class datosProveedores : Form
    {
        public datosProveedores()
        {
            InitializeComponent();
        }

        private void datosProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\Users\nat_1\OneDrive\Documentos\Universidad\PdP\C #\Proyecto_PdP_2024-main\Proyecto_PdP_2024-main\PruebaForms\PruebaForms\Repositorio\\datosProveedores.xml");
                // Establecer el DataSource del DataGridView
                dgvProveedores.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar archivo XML de Proveedores: " + ex.Message);
            }
        }   


    }
}
