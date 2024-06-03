using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, cargar sólo números.");
                
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero.");
            }
            finally
            {
                //operacion sensible....
                //instrucciones...
            }
            
        }

        private int calcular()//Este metodo puede devolver el resultado, o devolver una Excepcion
        {
            int a, b, r;
            try
            {
                a = int.Parse(num1.Text);
                b = int.Parse(num2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
