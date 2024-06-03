using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;//Se crea un atributo Pokemon NULO al ejecutar presionar en Agregar
        public frmAltaPokemon()//Se ejecuta al Agregar
        {
            InitializeComponent();
        }

        public frmAltaPokemon(Pokemon pokemon)//Constructor sobrecargado, se ejecuta al presionar Modificar
        {
            InitializeComponent();
            this.pokemon = pokemon;//Al atributo privado de la clase, asignale el pokemon del parametro
            Text = "Modificar Pokemon";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // Pokemon poke = new Pokemon(); Utilizamos el atributo privado que declaramos como nulomon
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if(pokemon == null) //Si el pokemon esta nulo, significa que queremos agregar un pokemon, entonces:
                    pokemon = new Pokemon();//Creamos un objeto pokemon y agregamos datos

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;


                if(pokemon.Id != 0)
                {
                negocio.modificar(pokemon);
                MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                negocio.agregar(pokemon);
                MessageBox.Show("Agregado exitosamente");

                }


                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                //Precargamos los desplegables Elemento y Debilidad
                cboTipo.DataSource = elementoNegocio.listar();

                cboDebilidad.DataSource = elementoNegocio.listar();

                //Al cargar el formulario, Precargamos los datos del pokemon a modificar 
                //Debemos validar si hay un pokemon nulo o un pokemon con datos

                if(pokemon != null)//Si el pokemon es distinto de nulo, significa que hay un pokemon para precargar y modificar
                    //entonces traemos sus datos
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);

                    
                    //Para precargar el tipo y debilidad del pokemon seleccionado:
                    //Indicamos al desplegable cual quiero que sea su clave y cual quiero que sea su valor para despues
                    //decirle que value quiero que este preseleccionado

                    //Clave: del elemento a mostrar
                    cboTipo.ValueMember = "Id"; //Propiedad de la clase elemento
                    //Valor: qué vamos a mostrar
                    cboTipo.DisplayMember = "Descripcion";//Propiedad de la clase elemento

                    cboDebilidad.ValueMember = "Id";
                    cboDebilidad.DisplayMember = "Descripcion";

                    //Indicamos los values del pokemon seleccionado
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void txtUrlImagen_Leave(object sender, EventArgs e)
        //{
        //    cargarImagen(txtUrlImagen.Text);
        //}

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception )
            {
                pbxPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
