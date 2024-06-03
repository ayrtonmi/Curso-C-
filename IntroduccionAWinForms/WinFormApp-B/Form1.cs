using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)//--->EVENTO SOBRE UN OBJETO
        {
            //MessageBox.Show("HOLA MUNDO");
            //string texto = txtNombre.Text; ---> a una variable le asignamos la propiedad de un objeto
            lblSaludo.Text = "HOLA " + txtNombre.Text; //---> a la propiedad de un objeto le asignamos texto + propiedad de otro obj
        }

       
    }
}
