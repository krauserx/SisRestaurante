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
    public partial class frmProveedores : Form
    {
        clsLogica MANT = new clsLogica();

        public frmProveedores()
        {
            InitializeComponent();
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
            btnInsertar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdent.Text == "")
            {
                MessageBox.Show("Ingrese el id del proveedor");
            }
            else
            {
                MessageBox.Show(MANT.eliminarProveedores(Convert.ToInt32(txtIdent.Text)));
                this.tBL_PROVEEDORESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PROVEEDORES);//aqui se actualiza la tabla
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                MessageBox.Show("Ingrese el Proveedor");
            }
            else if (txtNomContacto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del contacto");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el numero de telefono para el proveedor");
            }
            else if (txtWeb.Text == "")
            {
                MessageBox.Show("Ingrese el sitio web para el proveedor");
            }
            else
            {
                MessageBox.Show(MANT.insertarProveedores(txtProveedor.Text, txtNomContacto.Text, Convert.ToInt32(txtTel.Text), txtWeb.Text));
                this.tBL_PROVEEDORESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PROVEEDORES);//aqui se actualiza la tabla
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
            label13.Visible = true;
            txtIdent.Visible = true;
            pictureBox2.Visible = true;
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "")
            {
                MessageBox.Show("Ingrese el id del proveedor");
            }
            else if (txtProveedor.Text == "")
            {
                MessageBox.Show("Ingrese el proveedor");
            }
            else if (txtNomContacto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del contacto");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el telefono para el proveedor");
            }
            else if (txtWeb.Text == "")
            {
                MessageBox.Show("Ingrese el sitio web para el proveedor");
            }
            else
            {
                MessageBox.Show(MANT.ModificarProveedores(Convert.ToInt32(txtIdentificacion.Text), txtProveedor.Text, txtNomContacto.Text, Convert.ToInt32(txtTel.Text), txtWeb.Text));
                this.tBL_PROVEEDORESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PROVEEDORES);//aqui se actualiza la tabla
            }
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
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.tBL_PROVEEDORESTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PROVEEDORES);

        }
    }
}
