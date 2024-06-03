using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Hola mundo");
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;
        }

        

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Gracias por usar la app");
        }

        private void segundaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentanaDos ventana = new frmVentanaDos();
            ventana.ShowDialog();
        }

        private void toolVentanaDos_Click(object sender, EventArgs e)
        {
            frmVentanaDos ventana = new frmVentanaDos();
            ventana.ShowDialog();
        }

       
        
    }
}
