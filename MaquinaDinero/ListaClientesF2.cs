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
    public partial class ListaClientesF2 : Form
    {
        public ListaClientesF2()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mostraEnLista();

        }

        public void mostraEnLista()
        {
            List<Cliente> listaClientes = Form1.clientesList.OrderBy(c => c.SaldoCliente).ToList();

            foreach (Cliente c in listaClientes)
            {
                listClientesSaldo.Items.Add(c);
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
    }
}
