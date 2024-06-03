using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppADO3
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();//Creamos instancia de la clase que se conecta a la BD
            
            dgvPokemons.DataSource = negocio.listar();//DataSource recibe un origen de datos y lo modela en la
                                                      //tabla dgvPokemons

            //Mostrar imagen de pokemon
            pokemonList = negocio.listar();//Almacenamos la lista de pokemons en un objeto para manipularlo
            pictureBoxPoke.Load(pokemonList[0].UrlImagen);//Indicamos que muestre la propiedad de la imagen de un objeto 
                                                            //pokemon al cargar la pictureBox

        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {//Cuando cambie el item seleccionado, muestra la propiedad Imagen
         //de dicho item
           
            Pokemon seleccionado =(Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            //De la grilla Pokemons, en la fila actual dame el Objeto enlazado y transformalo en tipo Pokemon para
            // almacenarlo en una variable 
            cargarImagen(seleccionado.UrlImagen); //Recarga la pictureBox con la URLimagen del objeto seleccionado
        }

        private void cargarImagen(string imagen)//Modularizamos en una funcion la carga de la Imagen
        {
            try //Intenta cargar la imagen del objeto
            {
                pictureBoxPoke.Load(imagen);
            }
            catch (Exception e)
            {   //Si no puede cargarla, muestra una imagen por defecto

                pictureBoxPoke.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
