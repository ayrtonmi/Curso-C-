using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAppWindowsI
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chaus...");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atencion");
            //this.BackColor = Color.Aquamarine;
            if (txbCaja.Text == " ")
                txbCaja.BackColor = Color.Red;
            else
                txbCaja.BackColor = System.Drawing.SystemColors.Control;
        }

        //private void frmInicial_Click(object sender, EventArgs e)
        //{
        //    MouseEventArgs click = (MouseEventArgs)e;
        //    if (click.Button == MouseButtons.Left)
        //    {
        //        MessageBox.Show("Presiono el boton Izquierdo", "Atencion");

        //    }
        //    else if (click.Button == MouseButtons.Right)
        //        MessageBox.Show("Presiono el boton derecho", "Atencion");
        //    else if (click.Button == MouseButtons.Middle)
        //        MessageBox.Show("Presiono el boton del medio", "Atencion");
        //}

        private void frmInicial_MouseMove(object sender, MouseEventArgs e)
        {
            lblButton1.BackColor = Color.Blue;
            lblButton1.Cursor = Cursors.Hand;
        }

        private void lblButton1_MouseLeave(object sender, EventArgs e)
        {
            lblButton1.BackColor = System.Drawing.SystemColors.Control;
            lblButton1.Cursor = Cursors.Arrow;
        }

        private void txbCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbCaja2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene "+ txbCaja2.Text.Length + " caracteres");
        }
    }
}
