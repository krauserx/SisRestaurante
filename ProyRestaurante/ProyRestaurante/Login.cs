using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyRestaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string log;
        public static int IDUSUARIO;

        SqlConnection con = new SqlConnection(@"Data Source=YALIXA-PC\SQLEXPRESS;Initial Catalog=BDRestaurantes;Integrated Security=True"); //string de conexion

        public void LOGEAR(string usuario, string contrasena) //metodo que valida el usuario y la contraseña, tambien identifica el tipo de usuario
        {
            try
            {
                con.Open();// se abre la conexion
                SqlCommand cmd = new SqlCommand("Select NOMBRE, TIPO_USUARIO, ID_EMPLEADO FROM TBL_EMPLEADOS WHERE USUARIO = @usuario and CONTRASEÑA = @contra", con);// se realiza una consulta de la tabla usuarios comparando que el usuario y la contraseña coincidan con los datos guardados en base de datos
                cmd.Parameters.AddWithValue("usuario", usuario); //se agrega los parametros al cmd y se asigna las variables
                cmd.Parameters.AddWithValue("contra", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);//se agrega la consulta al dataAdapter
                DataTable dt = new DataTable();//se crea un dataTable
                sda.Fill(dt);//se llena el datatable con el dataAdapter


                if (dt.Rows.Count == 1)//se compara si el dataTable contiene filas, quiere decir que encontró datos
                {
                    this.Hide();//se oculta el formulario actual
                    if (dt.Rows[0][1].ToString() == "Administrador")//si las filas y columnas del dataAdapter coindicen con el tipo de Usuario Administrador
                    {
                        log = "Administrador";
                        new frmAdministradores(dt.Rows[0][0].ToString()).Show();

                    }


                    else if (dt.Rows[0][1].ToString() == "Ordinario")//si las filas y columnas del dataAdapter coindicen con el tipo de Usuario Ordinario
                    {
                        log = "Ordinario";
                        new frmPrincipal(dt.Rows[0][0].ToString()).Show();
                    }
                    IDUSUARIO = Convert.ToInt32(dt.Rows[0][2]);
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta"); //no encontro filas, entonces envia el mensaje de que los datos son incorrectos
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LOGEAR(txtUsuario.Text, txtContraseña.Text);
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Introduce un Usuario...");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                epError.SetError(txtContraseña, "Introduce una Contraseña...");
                txtContraseña.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

       
    }
}
