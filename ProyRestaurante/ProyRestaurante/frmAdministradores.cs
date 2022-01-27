using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyRestaurante
{
    public partial class frmAdministradores : Form
    {
        public frmAdministradores(string nombre)
        {
            InitializeComponent();
            lblAdmin.Text = nombre;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmClientes().Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaxim.Visible = true;
        }

        private void btnMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxim.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Quieres cerrar Sesion?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Adios!");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hklnd, int wMsg, int wParams, int lParams);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmUsuarios().Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmProveedores().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmMenu().Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmInventario().Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmBitacora().Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            new frmMesas().Show();
        }
    }
}
