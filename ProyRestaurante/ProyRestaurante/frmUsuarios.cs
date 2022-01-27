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
    public partial class frmUsuarios : Form
    {
       

        clsLogica MANT = new clsLogica();

        public frmUsuarios()
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'bDRestaurantesDataSet.TBL_EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.tBL_EMPLEADOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_EMPLEADOS);
            llenarCmbSucursal();

        }

        private void llenarCmbSucursal()
        {
            cmbSucursal.DataSource = MANT.logica.TBL_SUCURSALES.ToList();
            cmbSucursal.ValueMember = "ID_SUCURSAL";
            cmbSucursal.DisplayMember = "NOMBRE";
        }

   




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdent.Text == "")
            {
                MessageBox.Show("Ingrese el id del Usuario");
            }
            else
            {
                MessageBox.Show(MANT.eliminarUsuario(Convert.ToInt32(txtIdent.Text)));
                //dataGridView2.CurrentRow.Selected = false;
                this.tBL_EMPLEADOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_EMPLEADOS);
                txtIdent.Text = "";//se vacia el txt.
            }
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
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
            //else if (cmbSucursal.Text == "")
            //{
            //    MessageBox.Show("Ingrese el numero de la sucursal");
            //}
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el usuario o nickname");
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña para el usuario");
            }
            else if (txtSalario.Text == "")
            {
                MessageBox.Show("Ingrese el salario del usuario");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el telefono para el usuario");
            }
            else if (txtDirección.Text == "")
            {
                MessageBox.Show("Ingrese la direccion para el usuario");
            }
            else if (txtTiempoServ.Text == "")
            {
                MessageBox.Show("Ingrese el tiempo de servicio para el usuario");
            }
            //else if (cmbTipoUsuario.Text == "")
            //{
            //    MessageBox.Show("Ingrese el tipo de usuario para el usuario");
            //}
            else
            {
                MessageBox.Show(MANT.insertarUsuarios(txtNombreUsuario.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(cmbSucursal.SelectedValue), txtUsuario.Text, txtContraseña.Text, Convert.ToInt32(txtSalario.Text), Convert.ToInt32(txtTel.Text), txtDirección.Text, txtTiempoServ.Text, Convert.ToString(cmbTipoUsuario.SelectedItem)));
                dataGridView2.CurrentRow.Selected = false;
                this.tBL_EMPLEADOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_EMPLEADOS);
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
            //else if (cmbSucursal.Text == "")
            //{
            //    MessageBox.Show("Ingrese el numero de la sucursal");
            //}
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el usuario o nickname");
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña para el usuario");
            }
            else if (txtSalario.Text == "")
            {
                MessageBox.Show("Ingrese el salario del usuario");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Ingrese el telefono para el usuario");
            }
            else if (txtDirección.Text == "")
            {
                MessageBox.Show("Ingrese la direccion para el usuario");
            }
            else if (txtTiempoServ.Text == "")
            {
                MessageBox.Show("Ingrese el tiempo de servicio para el usuario");
            }
            //else if (cmbTipoUsuario.Text == "")
            //{
            //    MessageBox.Show("Ingrese el tipo de usuario para el usuario");
            //}
            else
            {
                MessageBox.Show(MANT.ModificarUsuario(Convert.ToInt32(txtIdentificacion.Text),txtNombreUsuario.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(cmbSucursal.SelectedValue), txtUsuario.Text, txtContraseña.Text, Convert.ToInt32(txtSalario.Text), Convert.ToInt32(txtTel.Text), txtDirección.Text, txtTiempoServ.Text, Convert.ToString(cmbTipoUsuario.SelectedItem)));
                dataGridView2.CurrentRow.Selected = false;
                this.tBL_EMPLEADOSTableAdapter.Fill(this.bDRestaurantesDataSet.TBL_EMPLEADOS);
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
