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
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            cargarGrilla();//Llamamos al metodo para cargar la grilla
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");

        }
        private void cargarGrilla() 
        {//Metodo para cargar la grilla
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
                dgvPokemons.Columns["Id"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);

        }

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

        private void btnAgregar_Click(object sender, EventArgs e)//Evento click para abrir la ventana de alta
        {
            frmAltaPokemon alta = new frmAltaPokemon();//Se crea un objeto ventana para el alta
            alta.ShowDialog();
            cargarGrilla();//Al cerrar la ventana de dialogo luego de agregar pokemon, se recarga la grilla
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //La ventana es igual al alta, pero buscamos precargar los datos de un pokemon seleccionado
            

            //Buscamos pasar por parametro el pokemon a modificar
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;//Obtenemos el pokemon seleccionado

            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);//Lo pasamos como parametro del constructor de frmAlta
            modificar.ShowDialog();
            cargarGrilla();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
            
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);//Establecemos el valor booleano en true para que el metodo eliminar evalue y ejecute eliminacion logica
        }

        private void eliminar(bool logico = false)//El valor booleano al ser false, es opcional
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if(logico)//Si yo no mando por parametro el boolean, quedara en false: ejecuta eliminacion fisica
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminarFisico(seleccionado.Id);

                    cargarGrilla();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar.");
                return true;

            }
            if (cboCampo.SelectedItem.ToString() == "Número")//Si el campo es Numero
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))//No puede estar vacio
                {
                    MessageBox.Show("El cuadro de Filtro no puede estar vacío.");
                    return true;
                }
                
                if (!(soloNumeros(txtFiltroAvanzado.Text)))//Si no esta vacio, tampoco puede ser texto
                {
                    MessageBox.Show("Ingrese sólo números.");
                    return true;
                }

            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (var caracter in cadena)//Se evalua la cadena en forma de vector
            {
                if (!(char.IsNumber(caracter)))//Se evalua si cada caracter de la cadena es numero
                    return false;
            }
            return true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;

                }
            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string filtro = txtFiltroAvanzado.Text;
                dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaPokemon;
            }



            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");


            }
        }
    }
}
