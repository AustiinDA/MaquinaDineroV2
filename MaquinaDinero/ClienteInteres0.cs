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
    public partial class ClienteInteres0 : Form
    {
        int codigo;
        public ClienteInteres0()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void generarCod()
        {


            Random random = new Random();
            lbCod.Text = Convert.ToString(random.Next(1, 9999));
            codigo = Convert.ToInt32(lbCod.Text);

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

                    Form1.clientesList.Add(new Cliente(textNombre.Text.ToString(), Convert.ToInt32(lbCod.Text.ToString())));
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
