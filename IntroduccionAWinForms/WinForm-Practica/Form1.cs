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
    public partial class Form1 : Form
    {
        Persona persona = new Persona();//se crea la instancia del objeto persona para que persista en todos los eventos del
                                        //formulario

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
            persona.Apellido = txtbApellido.Text;
            persona.Nombre = txtbNombre.Text;
            persona.Email = txtbEmail.Text;

            if (rbCasado.Checked == true)
                persona.EstadoCivil = "Casado";

            else if (rbSoltero.Checked == true)
            {
                persona.EstadoCivil = "Soltero";
            }
            else persona.EstadoCivil = "N/C";

            persona.Fecha = dtpFecha.Value.ToString();

            persona.Nacionalidad = cmbNacionalidad.SelectedItem.ToString();


            if (ckbPerro.Checked == true)
            {
                persona.Mascotas.Add(ckbPerro.Text);
            }
            if (ckbGato.Checked == true)
            {
                persona.Mascotas.Add(ckbGato.Text);
            }
            if (ckbHuron.Checked == true)
            {
                persona.Mascotas.Add (ckbHuron.Text);
            }
            if (ckbLoro.Checked == true)
            {
                persona.Mascotas.Add(ckbLoro.Text);
            }
            if (ckbNinguna.Checked == true)
            {
                persona.Mascotas.Add(ckbNinguna.Text);
                
                    ckbPerro.Checked = false;     
                    ckbGato.Checked = false;
                    ckbLoro.Checked = false;
                    ckbHuron.Checked = false;
            }


           string mascotasListado = string.Join(",", persona.Mascotas); // JOIN permite concatenar elementos de una colleccion
                                                                         // en una sola cadena
           string heladosFavoritos = string.Join(",",persona.HeladoFav); 
           

            MessageBox.Show(persona.Fecha+" "+persona.Nombre+" "+persona.Apellido+" "+persona.Email+" "+persona.Nacionalidad+" "+persona.EstadoCivil+" "
                +mascotasListado+" "+ heladosFavoritos);
        }

        private void btnOkHelado_Click(object sender, EventArgs e)
        {
           
           listViewHelados.Items.Add(txtbHelado.Text);

           persona.HeladoFav.Add(txtbHelado.Text);
           txtbHelado.Clear();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNacionalidad.Items.Add("Argentina");
            cmbNacionalidad.Items.Add("Chile");
            cmbNacionalidad.Items.Add("Colombia");
            cmbNacionalidad.Items.Add("Uruguay");
            cmbNacionalidad.Items.Add("Venezuela");

        }
    }
}
