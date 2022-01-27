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
    public partial class frmInventario : Form
    {
        clsLogica MANT = new clsLogica();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void llenarCmbSucursal()
        {
            cmbProveedor.DataSource = MANT.logica.TBL_PROVEEDORES.ToList();
            cmbProveedor.ValueMember = "ID_PROVEEDOR";
            cmbProveedor.DisplayMember = "PROVEEDOR";
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
                MessageBox.Show("Ingrese el id del inventario");
            }
            else
            {
                MessageBox.Show(MANT.eliminarInventario(Convert.ToInt32(txtIdent.Text)));

                this.tBL_INVENTARIOTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_INVENTARIO);//aqui se actualiza la tabla
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtInventario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del registro");
            }
            else
            {
                MessageBox.Show(MANT.insertarRegistro(txtInventario.Text, Convert.ToDateTime(txtVencimiento.Text), txtMarca.Text, Convert.ToInt32(cmbProveedor.SelectedValue)));
                dataGridView2.CurrentRow.Selected = false;
                this.tBL_INVENTARIOTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_INVENTARIO);//aqui se actualiza la tabla
            }
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_INVENTARIO' Puede moverla o quitarla según sea necesario.
            this.tBL_INVENTARIOTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_INVENTARIO);
            llenarCmbSucursal();
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
            else if (txtInventario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del registro");
            }
            else if (txtVencimiento.Text == "")
            {
                MessageBox.Show("Ingrese el vencimiento");
            }
            else if (txtMarca.Text == "")
            {
                MessageBox.Show("Ingrese la marca para el registro");
            }
            else
            {
                MessageBox.Show(MANT.ModificarInventario(Convert.ToInt32(txtIdentificacion.Text), txtInventario.Text, Convert.ToDateTime(txtVencimiento.Text), txtMarca.Text, Convert.ToInt32(cmbProveedor.SelectedValue)));
                dataGridView2.CurrentRow.Selected = false;
                this.tBL_INVENTARIOTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_INVENTARIO);//aqui se actualiza la tabla
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
    }
}
