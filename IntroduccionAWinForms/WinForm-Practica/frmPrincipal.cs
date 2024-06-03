using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Practica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventanaRegistro = new Form1();//instanciamos un objeto de tipo Form1 (form1 contiene nuestro formulario)
            ventanaRegistro.ShowDialog();//con showDialog mostramos en una ventana nuestro formulario
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonPerfilP_Click(object sender, EventArgs e)
        {
            //Validamos si ya se encuentra abierta la ventanaRegistro, asi se evita que se abra otra 
            foreach (var item in Application.OpenForms)
            //Accedemos y recorremos la coleccion de objetos ventana del objeto Application
            //Es decir, el objeto Application tiene una coleccion de objetos Form que están abiertos en ese momento, vivos
                //en memoria
            {
                if (item.GetType() == typeof(Form1))
                   //Evaluo si el tipo de objeto de la coleccion es igual al tipo de objeto que ya se encuentra en memoria
                        //y no quiero que se vuelva a instanciar
                {
                    MessageBox.Show("Termine de trabajar en el formulario abierto.");
                    return;//Return me permite terminar la ejecución del evento click
                }
            }
            Form1 ventanaRegistro = new Form1();
            ventanaRegistro.MdiParent = this;//Con mdi.Parent = this; indico que dicha ventana estará dentro de otra
            ventanaRegistro.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
