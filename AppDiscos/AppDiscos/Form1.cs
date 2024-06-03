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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarGrillas();
            cargarImg(listadiscos[0].UrlImagenTapa);
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
           Disco discoSeleccionado =(Disco)dgvDiscos.CurrentRow.DataBoundItem;
           cargarImg(discoSeleccionado.UrlImagenTapa);
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
            EstilosNegocio negocio2 = new EstilosNegocio();
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
    }
}
