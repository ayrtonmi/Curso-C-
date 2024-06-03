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
        private Pokemon pokemon = null;
        public frmAltaPokemon()//Al agregar pokemon, se ejecuta este constructor
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon pokemon)//Al modificar pokemon, se ejecuta este constructor sobrecargado
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar pokemon";//Cambiamos el titulo de la ventana modificar
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {//Cargamos los elementos desplegables al abrir la ventana
            ElementoNegocio elementoNegocio = new ElementoNegocio();//Necesitamos un objeto ElementoNegocio para traer datos
                                                                    //de elementos (tipo y debilidad)

            try
            {
                comboBoxTipo.DataSource = elementoNegocio.listar();//Asignamos origen de datos al desplegable

                //Necesario para precargar desplegables en laventana modificar
                //Id y Descripcion son los nombres de las props de la clase Elemento
                comboBoxTipo.ValueMember = "Id";//Clave
                comboBoxTipo.DisplayMember = "Descripcion";//Valor


                comboBoxDebilidad.DataSource = elementoNegocio.listar();
                comboBoxDebilidad.ValueMember = "Id";
                comboBoxDebilidad.DisplayMember = "Descripcion";

                //Precargamos los datos del pokemon seleccionado cuando queremos modificar
                if(pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    tbxImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);

                    comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)//Evento click para cargar los datos del formulario
        {
           // Pokemon poke = new Pokemon();//Necesitamos un nuevo objeto pokemon que se agregará a la DB
            PokemonNegocio negocio = new PokemonNegocio();//Necesitamos objeto negocio para conectarnos a la DB
            try
            {
                //Utilizamos el atributo privado de la clase tanto para alta como para modificar

                if(pokemon == null)//Esto evalua si presionamos sobre agregar o modificar en la ventana frmAlta
                                   //(es la misma para ambos)
                    //Si es nulo, al aceptar previamente tocamos agregar, si no lo es, habremos tocado modificar
                    //Si es nulo entonces se genera instancia del nuevo pokemon y se asignan los datos
                    //Si no es nulo, los datos a modificar se "pisan"
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtNumero.Text);//Cargamos objeto pokemon asignando los datos del formulario
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;
                pokemon.UrlImagen = tbxImagen.Text;
                
                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);//Llamamos al metodo agregar para que agregue nuestro nuevo pokemon
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();//Cerramos  ventana
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbxPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void tbxImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(tbxImagen.Text);
        }
    }
}
