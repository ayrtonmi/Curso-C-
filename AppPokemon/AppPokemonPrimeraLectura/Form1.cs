using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPokemonPrimeraLectura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();//Instanciamos un objeto negocio para invocar al metodo Listar
            dgvPokemons.DataSource = negocio.Listar();//A la grilla de datos le asignamos la lista de datos obtenida
                                                       //de la BBDD 
            //DataSource = recibe un origen de datos y lo modela en la tabla, teniendo en cuenta el modelo de la clase de objetos que muestra

        }
    }
}
