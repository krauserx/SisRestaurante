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
    public partial class frmMenu : Form
    {
        clsLogica MANT = new clsLogica();
        public frmMenu()
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdent.Text == "")
            {
                MessageBox.Show("Ingrese el id del Producto");
            }
            else
            {
                MessageBox.Show(MANT.eliminarProducto(Convert.ToInt32(txtIdent.Text)));

                this.tBL_PRODUCTOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PRODUCTOS);//aqui se actualiza la tabla
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto");
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio");
            }
            else if (txtDescrip.Text == "")
            {
                MessageBox.Show("Ingrese la descripcion para el producto");
            }
            else
            {
                MessageBox.Show(MANT.insertarProducto(txtNombre.Text, Convert.ToString(cmbTipo.SelectedItem), Convert.ToInt32(txtPrecio.Text), txtDescrip.Text));
                this.tBL_PRODUCTOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PRODUCTOS);//aqui se actualiza la tabla
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
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto");
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio del producto");
            }
            else if (txtDescrip.Text == "")
            {
                MessageBox.Show("Ingrese la descripcion para el producto");
            }
            else
            {
                MessageBox.Show(MANT.ModificarProducto(Convert.ToInt32(txtIdentificacion.Text), txtNombre.Text, Convert.ToString(cmbTipo.SelectedItem), Convert.ToInt32(txtPrecio.Text), txtDescrip.Text));

                this.tBL_PRODUCTOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PRODUCTOS);//aqui se actualiza la tabla
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.tBL_PRODUCTOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_PRODUCTOS);

        }
    }
}
