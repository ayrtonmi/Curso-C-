using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPokemon7;
using dominio;
using negocio;

namespace AppPokemon
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
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listar();
            dgvPokemon.DataSource = listaPokemons;
            dgvPokemon.Columns["UrlImagen"].Visible = false;    
            cargarImagen(listaPokemons[0].UrlImagen);

            ElementoNegocio elementos = new ElementoNegocio();
            dgvElementos.DataSource = elementos.listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
           Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
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

                pbxPokemon.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
        }
    }
}
