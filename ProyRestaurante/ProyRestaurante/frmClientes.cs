using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyRestaurante
{
    public partial class frmClientes : Form
    {
        clsLogica MANT = new clsLogica();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView2.Visible = false;
            btnEliminar.Visible = false;
            btnAgregarNu.Visible = false;
            pictureBox2.Visible = false;
            txtIdent.Visible = false;
            label13.Visible = false;
            btnAct.Visible = false;
            btnInsertar.Visible = false;
            btnActualizar.Visible = true;
            pictureBox1.Visible = true;
            txtIdentificacion.Visible = true;
            label5.Visible = true;
            btnInsertar.Visible = true;
        }

        private void btnAgregarNu_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView2.Visible = false;
            btnEliminar.Visible = false;
            btnAgregarNu.Visible = false;
            pictureBox2.Visible = false;
            txtIdent.Visible = false;
            label13.Visible = false;
            btnActualizar.Visible = false;
            btnAct.Visible = false;
            pictureBox1.Visible = false;
            txtIdentificacion.Visible = false;
            label5.Visible = false;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tBL_CLIENTESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_CLIENTES);//aqui se actualiza la tabla

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             if (txtIdent.Text == "")
            {
                MessageBox.Show("Ingrese el id del Usuario");
            }
            else
            {
                MessageBox.Show(MANT.eliminarClientes(Convert.ToInt32(txtIdent.Text)));

                this.tBL_CLIENTESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_CLIENTES);//aqui se actualiza la tabla
            }
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
            }
            else if (txtApellido1.Text == "")
            {
                MessageBox.Show("Ingrese el primer Apellido");
            }
            else if (txtApellido2.Text == "")
            {
                MessageBox.Show("Ingrese el segundo apellido para el cliente");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el telefono para el cliente");
            }
            else
            {
                MessageBox.Show(MANT.insertarClientes(txtNombreUsuario.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text)));

                this.tBL_CLIENTESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_CLIENTES);//aqui se actualiza la tabla
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dataGridView2.Refresh();
            groupBox1.Visible = false;
            dataGridView2.Visible = true;
            btnAgregarNu.Visible = true;
            btnAct.Visible = true;
            btnEliminar.Visible = true;
            pictureBox2.Visible = true;
            txtIdent.Visible = true;
            label13.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Ingrese el id del Usuario");
            }
            else if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del Usuario");
            }
            else if (txtApellido1.Text == "")
            {
                MessageBox.Show("Ingrese el primer Apellido");
            }
            else if (txtApellido2.Text == "")
            {
                MessageBox.Show("Ingrese el segundo apellido para el usuario");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el telefono para el usuario");
            }
            else
            {
                MessageBox.Show(MANT.ModificarClientes(Convert.ToInt32(txtIdentificacion.Text), txtNombreUsuario.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text)));

                this.tBL_CLIENTESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_CLIENTES);//aqui se actualiza la tabla
            }
        }
    }
}
