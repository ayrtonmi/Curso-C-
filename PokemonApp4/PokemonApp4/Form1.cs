using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonApp4
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
            //Invocamos el metodo de conexion a la DB y listado de datos 
            PokemonNegocio negocio= new PokemonNegocio();
            //dgvPokemons.DataSource = negocio.listar();//negocio.listar se conecta a la DB y trae una lista de datos
                                                      //DataSource recibe un origen de datos y lo modela en la tabla
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaPokemon[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado=(Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            //de la grilla pokemon, en la fila actual dame el item(objeto) enlazado
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

                pbxPokemon.Load("https://www.russorizio.com/wp-content/uploads/2016/07/ef3-placeholder-image.jpg");
            }
        }
    }
}
