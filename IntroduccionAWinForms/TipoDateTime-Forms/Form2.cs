using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoDateTime_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFechadtp_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dddd MM/yyyy"));
        }

        private void btnCalFecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("dd/MM/yyyy"));
        }
    }
}
