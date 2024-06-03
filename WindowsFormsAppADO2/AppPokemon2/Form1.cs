using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPokemon2
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonDatos datos = new PokemonDatos();//Creo un objeto de datos que se crea al cargar la ventana
            //dgvPokemon.DataSource = datos.Listar();//Al orgigen de datos de la grilla de la ventana le asigno como origen de datos el metodo Listar del objeto
                                                   //datos que se conecta y trae los datos desde la BD
            
            //Para poder manipular la lista obtenida de la BD, creamos un atributo lista que almacene lo que devuelve Listar
            listaPokemons = datos.Listar();
            dgvPokemon.DataSource = listaPokemons; //Luego asignamos ese atributo al origen de datos de la grilla
            cargarImagen(listaPokemons[0].UrlImagen);//Cargamos la URL del primer pokemon de la lista de Pokemons

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {//Cuando cambie el elemento seleccionado de la grilla, se actualiza la imagen para dicho elemento

            Pokemon seleccionado=(Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            //de la grilla (dgvPokemon), de la fila actual (CurrentRow), dame el objeto enlazado (DataBoundItem)
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
            //modularizamos la carga de imagenes para manipular la excepcion en caso de que no se cargue la imagen
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbPokemon.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
                
            }
            
        }
    }
}
