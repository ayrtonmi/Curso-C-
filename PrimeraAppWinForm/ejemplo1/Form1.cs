using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hola mundillo ");
           string texto = txtNombre.Text;
            labelSaludo.Text =  "Hola " + texto;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  MessageBox.Show("Gracias por usar la app");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
