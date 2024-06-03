using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPokemon5
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Invocamos la lectura a DB al cargar la ventana
            
            PokemonNegocio negocio = new PokemonNegocio();//Creamos un objeto para invocar a su metodo de acceso a datos
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;//Asignamos como origen de datos de la grilla el metodo listar, que
                                                  // se conecta a la DB y devuelve una lista de Pokemon
            dgvPokemons.Columns["UrlImagen"].Visible = false;//Ocultamos una columna de la grilla
            cargarImagen(listaPokemon[0].UrlImagen);//Al cargar la picture box, se carga la url del elemento del indice
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            //De la grilla Pokemon, de la fila actual dame el objeto (transformado en pokemon)enlazado 
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
            pbxPokemon.Load(imagen);

            }
            catch (Exception ex)
            {

                pbxPokemon.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
    }
}
