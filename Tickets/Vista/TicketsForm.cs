using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        private void GenerarTicketbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuariotextBox.Text)
                || string.IsNullOrEmpty(ClientetextBox.Text)
        || string.IsNullOrEmpty(DescripcionStextBox.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los campos
            DateTime fecha = dateTimePicker1.Value;
            string usuario = UsuariotextBox.Text.Trim();
            string cliente = ClientetextBox.Text.Trim();
            string tipoSoporte = comboBox1.Text.Trim();
            string descSolicitud = DescripcionStextBox.Text.Trim();
            string descRespuesta = DescripcionRtextBox.Text.Trim();
            decimal precio = decimal.TryParse(PreciotextBox.Text, out decimal temp) ? temp : 0;
            decimal impuesto = decimal.TryParse(ImpuestotextBox.Text, out temp) ? temp : 0;
            decimal descuento = decimal.TryParse(DescuentpotextBox.Text, out temp) ? temp : 0;

            // Calcular el total
            decimal total = precio + impuesto - descuento;
        }
          
               
    }
}
