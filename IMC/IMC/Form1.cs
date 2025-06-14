using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        private clsIMC imc;
        public Form1()
        {
            imc = new clsIMC();
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            //Esta validado con un try catch en caso de que falte ingrsar algun valor
            try
            {
                //Lleva los valores de las cajas de texto a los atributos.
                imc.Peso = float.Parse(txtPeso.Text);
                imc.Estatura = float.Parse(txtEstatura.Text);
                imc.Pasos = int.Parse(txtPasos.Text);
                imc.Sancada = float.Parse(txtSancada.Text);

                //Manda a llamar los métodos para calcular el IMC, la clasificación y los pasos faltantes, y mostrarlos
                txtIMC.Text = "IMC: " + imc.CalcularIMC().ToString();
                txtClasificacion.Text = imc.Clasificacion();
                txtPasosFaltantes.Text = imc.CalcularPasos().ToString();
            }   
            catch 
            { 
                MessageBox.Show("Por favor, ingrese los valores.");
            }
        }

        //Validaciones para que solo se ingresen números en los campos de texto y que acepte punto decimal y borrar.
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

            }
        }

        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

            }
        }

        private void txtSancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

            }
        }

        //Botón para limpiar los campos de texto.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtEstatura.Clear();
            txtPasos.Clear();
            txtSancada.Clear();
            txtIMC.Clear();
            txtClasificacion.Clear();
            txtPasosFaltantes.Clear();
        }
    }
}
