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
    public partial class AgregarDinero : Form
    {
        List<Cliente> clientes = Form1.clientesList.ToList();

        public AgregarDinero()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mostraEnLista();
        }
        public void mostraEnLista()
        {

            foreach (Cliente c in clientes)
            {
                listBox.Items.Add(c);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            listBox.Refresh();

            try
            {
                int swap;

                if (int.TryParse(textDinero.Text, out swap)) {
                    foreach (Cliente cliente in clientes)
                    {
                        listBox.Items.Remove(cliente);
                        cliente.SaldoCliente = swap;
                        listBox.Items.Add(cliente);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la introducción de datos");
            }
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textDinero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
