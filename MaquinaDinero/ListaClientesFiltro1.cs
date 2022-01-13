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
    public partial class ListaClienteFiltro1 : Form
    {
        

        
    public ListaClienteFiltro1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mostraEnListaAlf();

        }



        public void mostraEnListaAlf()
        {
            List<Cliente> listaClientesOrdenar = Form1.clientesList.OrderBy(c => c.Nombre).ToList();

        }

        public void mostraEnLista()
        {
            List<Cliente> listaClientes = Form1.clientesList.OrderBy(c => c.SaldoCliente).ToList();

        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostraEnListaAlf();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostraEnLista();
        }

        private void ListaClienteFiltro1_Load(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = Form1.clientesList.OrderBy(c => c.Nombre).ToList();


            foreach (Cliente c in listaClientes)
            {
                
                listaClientesOrdenar.Items.Add(c);
            }
        }
    }
}
