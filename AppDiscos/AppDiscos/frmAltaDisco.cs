using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace AppDiscos
{
    public partial class frmAltaDisco : Form
    {
        private Disco disk = null;//Se crea un objeto disco nulo al crear una instancia de la ventana de alta
        public frmAltaDisco()//Se ejecuta al agregar
        {
            InitializeComponent();
        }
        public frmAltaDisco(Disco disk)//Se ejecuta al modificar, recibe como parametro el elemento seleccionado de la grilla
        {
            InitializeComponent();
            this.disk = disk;//Asigno al atributo nulo el objeto que recibe como parametro de la grilla (disco seleccionado)
            Text = "Modificar Disco";
        }

        private void btnAceptar_Click(object sender, EventArgs e)//Funcion para capturar datos del formulario y
                                                                 //convertirlo en un objeto Disco
        { 
            //Disco disk = new Disco(); //Utilizamos el atributo privado 
            //Estilo estilo = new Estilo();
            //TipoEdicion edicion = new TipoEdicion();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (disk == null)//Evalua si el disco esta nulo para determinar si es un alta o un update
                
                    disk = new Disco();
                //Cargamos el objeto Disco
                    
                    disk.Titulo = txtbTitulo.Text;
                    disk.FechaLanzamiento = dateDisco.Value;
                    disk.CantidadCanciones = int.Parse(txtbCanciones.Text);
                    disk.UrlImagenTapa = txtUrl.Text;

                    disk.Estilo = (Estilo)cboEstilo.SelectedItem;

                    disk.Edicion = (TipoEdicion)cboEdicion.SelectedItem;

                
                if (disk.Id != 0)
                {
                negocio.modificar(disk);//Se ejecuta la modificacion
                MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                negocio.agregar(disk);//Agregamos el objeto disk a la db
                MessageBox.Show("Agregado exitosamente");

                }

                Close();

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstilosNegocio estilonegocio = new EstilosNegocio();
            EdicionNegocio edicionnegocio = new EdicionNegocio();
            try
            {
                cboEstilo.DataSource = estilonegocio.listar();
                //Indicamos al desplegable una clave y un valor para despues indicar que value quiero que este preseleccionado
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";

                cboEdicion.DataSource = edicionnegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
              
                if (disk != null)//Si el atributo privado es distinto de nulo, precargamos los datos del disco seleccionado a modificar
                {
                    txtbTitulo.Text = disk.Titulo;
                    txtbCanciones.Text =disk.CantidadCanciones.ToString();
                    txtUrl.Text = disk.UrlImagenTapa;

                    cboEstilo.SelectedValue = disk.Estilo.Id;
                    cboEdicion.SelectedValue = disk.Edicion.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImg(txtUrl.Text);

        }
        private void cargarImg(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);

            }
            catch (Exception ex)
            {

                pbxDisco.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
