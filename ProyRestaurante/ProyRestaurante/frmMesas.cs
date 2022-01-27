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
    public partial class frmMesas : Form
    {
        clsLogica MANT = new clsLogica();
        public frmMesas()
        {
            InitializeComponent();
        }

        private void llenarCmbSucursal()
        {
            cmbSucur.DataSource = MANT.logica.TBL_SUCURSALES.ToList();
            cmbSucur.ValueMember = "ID_SUCURSAL";
            cmbSucur.DisplayMember = "NOMBRE";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdent.Text == "")
            {
                MessageBox.Show("Ingrese el id del inventario");
            }
            else
            {
                MessageBox.Show(MANT.eliminarMesa(Convert.ToInt32(txtIdent.Text)));

                this.tBL_MESASTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_MESAS);//aqui se actualiza la tabla
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "")
            {
                MessageBox.Show("Ingrese la capacidad de la mesa");
            }
            else
            {
                MessageBox.Show(MANT.insertarMesa(Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(cmbSucur.SelectedValue)));
               
                this.tBL_MESASTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_MESAS);//aqui se actualiza la tabla
            }
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_MESAS' Puede moverla o quitarla según sea necesario.
            this.tBL_MESASTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_MESAS);
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
            else if (txtCapacidad.Text == "")
            {
                MessageBox.Show("Ingrese la capacidad de la mesa");
            }
            else
            {
                MessageBox.Show(MANT.ModificarMesa(Convert.ToInt32(txtIdentificacion.Text), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(cmbSucur.SelectedValue)));
               
                this.tBL_MESASTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_MESAS);//aqui se actualiza la tabla
            }
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
    }
}
