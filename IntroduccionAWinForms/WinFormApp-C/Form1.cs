using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;//capturo en una variable el contenido de la propiedad Text del objeto txtElemento
            listElementos.Items.Add(elem);//agrego a la lista de Elementos el elemento capturado
        }

        private void Form1_Load(object sender, EventArgs e)//agrego items al objeto comboBoxColorFav al momento de cargar la ventana
        {
            comboBoxColorFav.Items.Add("Rojo");//este objeto es una coleccion
            comboBoxColorFav.Items.Add("Verde");
            comboBoxColorFav.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;//guardamos el contenido de la propiedad Text del objeto txtNombre (caja de texto)
            DateTime fecha = dateTimePickerFechaNac.Value;//guardamos el contenido de la propiedad Value del objeto tipo DateTime

            //OPERADOR TERNARIO: es un IF de una sola linea ---> condicion ? "verdadero" : "falso";

            string chocolate = checkBoxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";

            string tipo; //convertimos en texto segun se encuentre checkeado o no cada elemento del radioButton
            if (radioButtonMuggle.Checked == true)
            {
                tipo = "Muggle";
                ;
            }
            else if (radioButtonWizard.Checked == true)
            {
                tipo = "Wizard";
            }
            else
                tipo = "Squibs";

            string colorFavorito = comboBoxColorFav.SelectedItem.ToString(); 
            string numeroFav = NumFav.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + numeroFav;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " +fecha +", "+ mensaje);
        }
    }
}
