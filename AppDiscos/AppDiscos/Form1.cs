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
namespace AppDiscos
{
    public partial class Form1 : Form
    {
        private List<Disco> listadiscos;
        public Form1()
        {
            InitializeComponent();
            Text = "Discos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarGrillas();
            cargarImg(listadiscos[0].UrlImagenTapa);
            ocultarColumnas();
        }

        public void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)//Evaluacion para evitar excepcion al actualizar la lista luego de quitar el filtro
            {
           Disco discoSeleccionado =(Disco)dgvDiscos.CurrentRow.DataBoundItem;
           cargarImg(discoSeleccionado.UrlImagenTapa);

            }
        }

        private void cargarImg(string imagen)
        {
            try
            {
                pictureBoxDisco.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBoxDisco.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargarGrillas();
        }

        private void cargarGrillas()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            //EstilosNegocio negocio2 = new EstilosNegocio();
            try
            {
                listadiscos = negocio.listar();
                //dgvEstilos.DataSource = negocio2.listar();
                dgvDiscos.DataSource = listadiscos;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado; //
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem; //Objeto disco seleccionado para modificar
           
            frmAltaDisco modificar = new frmAltaDisco(seleccionado);//Pasamos por parametro el disco seleccionado
            modificar.ShowDialog();
            cargarGrillas();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico=false)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Disco seleccionado;


            try
            {
                //El metodo messageBox.Show esta sobrecargado y devuelve un DialogResult, un resultado, el cual puede almacenarse en una variable
                DialogResult respuesta = MessageBox.Show("¿Desea elimnar?", "Eliminar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminarFisico(seleccionado.Id);

                    cargarGrillas();
                    MessageBox.Show("Disco eliminado");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                //METODO FINDALL DE UNA LISTA BUSCA COINCIDENCIAS EN TODOS LOS ELEMENTOS, COMO SI FUERA UN FOREACH
                //El metodo necesita como parametro una expresion LAMBDA

                //Metodo Contains de los strings, devuelve V o F si lo que viene del filtro está dentro del Titulo que esta analizando
                listaFiltrada = listadiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listadiscos;
            }

            //Una vez filtrada la lista, se asigna al dataSource
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
