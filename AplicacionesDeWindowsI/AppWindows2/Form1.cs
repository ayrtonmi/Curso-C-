using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (tbApellido.Text == "" || tbNombre.Text == "" || tbEdad.Text == "" || tbDireccion.Text == "")
            {
                tbApellido.BackColor = Color.Red;
                tbNombre.BackColor = Color.Red;
                tbEdad.BackColor = Color.Red;
                tbDireccion.BackColor = Color.Red;
                MessageBox.Show("Complete todos los campos");

            }
            else if (tbApellido.Text != "" && tbNombre.Text != "" && tbEdad.Text != "" && tbDireccion.Text != "")
            {
                //la propiedad Lines retorna un Array de strings, concatenamos los datos de cada text box para mostrarlos
                //linea por linea. Cada indice del arreglo contiene una linea del text box
                tbApellido.BackColor = Color.LightGreen;
                tbNombre.BackColor = Color.LightGreen;
                tbEdad.BackColor = Color.LightGreen;
                tbDireccion.BackColor = Color.LightGreen;
            }
            

                tbResultado.Lines = new string[] { "Apellido y Nombre: " + tbApellido.Text + " " + tbNombre.Text, "Edad: " + tbEdad.Text, "Dirección: " + tbDireccion.Text };
        }
                
                
        

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
