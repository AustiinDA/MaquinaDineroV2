using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDinero
{
    public partial class ClienteConPropiedades : Form
    {
        int codigo;

        public ClienteConPropiedades()

        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            generarCod();

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void generarCod()
        {


            Random random = new Random();
            textCodigoAut.Text = Convert.ToString(random.Next(1, 9999));
            lblCodAut.Text = Convert.ToString(random.Next(1, 9999));
            codigo = Convert.ToInt32(textCodigoAut.Text);
            codigo = Convert.ToInt32(lblCodAut.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textNombre.Text.Equals(""))
                {

                    Form1.clientesList.Add(new Cliente(textNombre.Text.ToString(), Convert.ToInt32(textCodigoManual.Text), Convert.ToDouble(textSaldo.Text), Convert.ToDouble(barraInteres.Value.ToString())));
                    MessageBox.Show("Cliente creado");
                }
                else
                {
                    MessageBox.Show("Los campos no deben ser erroneos o vacíos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la introducción de datos");
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            generarCod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (!textBox2.Text.Equals(""))
                {

                    Form1.clientesList.Add(new Cliente(textBox2.Text.ToString(), Convert.ToInt32(textCodigoManual.Text)));
                    MessageBox.Show("Cliente creado");
                }
                else
                {
                    MessageBox.Show("Los campos no deben ser erroneos o vacíos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la introducción de datos");
            }
        }

        private void button3Conf_Click(object sender, EventArgs e)
        {
            try
            {

                if (!textBox3.Text.Equals(""))
                {

                    Form1.clientesList.Add(new Cliente(textBox3.Text.ToString(), Convert.ToInt32(lblCodAut.Text.ToString())));
                    MessageBox.Show("Cliente creado");
                }
                else
                {
                    MessageBox.Show("Los campos no deben ser erroneos o vacíos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la introducción de datos");
            }
        }
    }
}
