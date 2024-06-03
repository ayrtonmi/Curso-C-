using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            listViewElementos.Items.Add(elemento);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxColorFav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColorFav.Items.Add("Rojo");
            comboBoxColorFav.Items.Add("Verde");
            comboBoxColorFav.Items.Add("Azul");
            comboBoxColorFav.Items.Add("Amarillo");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelVerPerfil_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDownFav_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTimePickerNacimiento.Value;
            //operador ternario 
            string chocolate = checkBoxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (radioButtonAmargo.Checked == true)

                tipo = "Amargo";

            else if (radioButtonBlanco.Checked == true)
                tipo = "Blanco";
            else
                tipo = "Negro";

            string colorFav = comboBoxColorFav.SelectedItem.ToString();
            string numFav = numericUpDownFav.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + "Le gusta: " + chocolate + "Color favorito: " + numFav + "Color favorito: " + colorFav);
        }
    }
}
