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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!textNombre.Text.Equals(""))
                {

                    Form1.clientesList.Add(new Cliente(textNombre.Text.ToString(), Convert.ToInt32(textCodigo.Text)));
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
