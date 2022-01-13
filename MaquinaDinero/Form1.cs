using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MaquinaDinero
{
    public partial class Form1 : Form {

        private IconButton btnActual;
        private Panel btnPanelIzq;
        private Form formActual;
        public static List<Cliente> clientesList = new List<Cliente>();


        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();


            btnPanelIzq = new Panel();
            btnPanelIzq.Size = new Size(7, 60);

            panelMenu.Controls.Add(btnPanelIzq);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 177);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeshabilitarBoton();

                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;


                btnPanelIzq.BackColor = color;
                btnPanelIzq.Location = new Point(0, btnActual.Location.Y);
                btnPanelIzq.Visible = true;
                btnPanelIzq.BringToFront();

                iconoItemActual.IconChar = btnActual.IconChar;
                iconoItemActual.IconColor = color;
            }
        }

        private void DeshabilitarBoton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(31, 30, 68);
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbirFormHijo(Form formHijo)
        {
            if (formActual != null)
            { 
               formActual.Close();
            }
            formActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;    
            formHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formHijo);
            panelPrincipal.Tag = formHijo; 
            formHijo.BringToFront(); 
            formHijo.Show();
            lblTitulo.Text = formHijo.Text;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            
        }

        private void porCódigoAutomáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conSaldoEInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteInteres0 clientesInteres = new ClienteInteres0(); 
            clientesInteres.Show();
            clientesInteres.generarCod();

        }

        private void porCódigoAutomáticoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClientesAuto clientesAuto = new ClientesAuto();
            clientesAuto.Show();
            clientesAuto.generarCod();
        }

        private void gdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void conPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteConPropiedades clientesPropiedades = new ClienteConPropiedades();
            clientesPropiedades.Show();
        }

        private void mostrarOrdenAlfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClienteFiltro1 l1 = new ListaClienteFiltro1();
            l1.ShowDialog();
        }

        private void mostrarPorSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientesF2 l2 = new ListaClientesF2();
            l2.ShowDialog();

        }

        private void dineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDinero ad = new AgregarDinero();
            ad.ShowDialog();

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color1);
            AbirFormHijo(new ClienteConPropiedades());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color2);
            AbirFormHijo(new AgregarDinero());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColores.color3);
            AbirFormHijo(new ListaClienteFiltro1());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DeshabilitarBoton();
            btnPanelIzq.Visible = false;
            iconoItemActual.IconChar = IconChar.Home;
            iconoItemActual.IconColor = Color.FromArgb(41, 169, 220);
            lblTitulo.Text = "Inicio";
        }
       
        //Mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
