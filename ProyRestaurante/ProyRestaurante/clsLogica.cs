using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProyRestaurante
{
    class clsLogica
    {
        
        public  BDRestaurantesEntities logica = new BDRestaurantesEntities(); //instancia de modelo de la base de datos

        public string insertarUsuarios(String Nombre, String Apellido1, String Apellido2, int idSucursal, String usu, String Contra, int salario, int telefono, String direccion, String tiempoServ, String tipoUsu) //metodo que inserta los datos de un estudiante
        {
            var insertar = new TBL_EMPLEADOS(); //variable que se utiliza para agregar datos a la tabla en especifica de empleados

            insertar.NOMBRE = Nombre;//inserta el nombre en la base de datos
            insertar.APELLIDO1 = Apellido1;//inserta el apellido1 en la base de datos
            insertar.APELLIDO2 = Apellido2;//inserta el apellido2 en la base de datos
            insertar.ID_SUCURSAL = idSucursal;//inserta el id de la sucursal en la base de datos
            insertar.USUARIO = usu;//inserta el usuario en la base de datos
            insertar.CONTRASEÑA = Contra;//inserta la contraseña en la base de datos
            insertar.SALARIO = salario;//inserta el salario en la base de datos
            insertar.TELEFONO = telefono;//inserta el telefono en la base de datos
            insertar.DIRECCION = direccion; //inserta la direccion en la base de datos
            insertar.TIEMPO_SERVICIO = tiempoServ; //inserta el tiempo de servicio en la base de datos
            insertar.TIPO_USUARIO = tipoUsu; //inserta el tipo de usuario en la base de datos

            logica.TBL_EMPLEADOS.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito el Empleado"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarUsuario(int cod, String Nombre, String Apellido1, String Apellido2, int idSucursal, String usu, String Contra, int salario, int telefono, String direccion, String tiempoServ, String tipoUsu)//metodo que mofifica los datos de un empleado
        {
            var modificar = (from dato in logica.TBL_EMPLEADOS where dato.ID_EMPLEADO == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de empleados segun la identificacion del empleado

            modificar.NOMBRE = Nombre;//actualiza el nuevo nombre en la base de datos
            modificar.APELLIDO1 = Apellido1;//actualizar el nuevo valor de apellido1 en la base de datos
            modificar.APELLIDO2 = Apellido2;//actualiza el nuevo valor de apellido2 en la base de datos
            modificar.ID_SUCURSAL = idSucursal;//actualiza el numero de la sucursal en la base de datos
            modificar.USUARIO = usu;//actualiza el usuario en la base de datos
            modificar.CONTRASEÑA = Contra;//actualiza la contraseña en la base de datos
            modificar.SALARIO = salario;//actualiza el salario en la base de datos
            modificar.TELEFONO = telefono; //actualiza el telefono en la base de datos
            modificar.DIRECCION = direccion;//actualiza la direccion en la base de datos
            modificar.TIEMPO_SERVICIO = tiempoServ;//actualiza el tiempo de servicio en la base de datos
            modificar.TIPO_USUARIO = tipoUsu; //actualiza el tipo de usuario en la base de datos

            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito el Empleado";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarUsuario(int cod)//metodo que elimina los datos de un empleado
        {
            var eliminar = (from dato in logica.TBL_EMPLEADOS where dato.ID_EMPLEADO == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de empleados segun la identificacion del empleado

            logica.TBL_EMPLEADOS.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito el Empleado";//envia el mensaje de que se elimino con exito
        }

        public string insertarClientes(String Nombre, String Apellido1, String Apellido2, int telefono) //metodo que inserta los datos de un cliente
        {
            var insertar = new TBL_CLIENTES(); //variable que se utiliza para agregar datos a la tabla en especifica de clientes

            insertar.NOMBRE = Nombre;//inserta el nombre en la base de datos
            insertar.APELLIDO1 = Apellido1;//inserta el apellido1 en la base de datos
            insertar.APELLIDO2 = Apellido2;//inserta el apellido2 en la base de datos
            insertar.TELEFONO = telefono;//inserta el telefono en la base de datos
            
            logica.TBL_CLIENTES.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito el cliente"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarClientes(int cod, String Nombre, String Apellido1, String Apellido2, int telefono)//metodo que mofifica los datos de un cliente
        {
            var modificar = (from dato in logica.TBL_CLIENTES where dato.ID_CLIENTE == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de empleados segun la identificacion del empleado

            modificar.NOMBRE = Nombre;//actualiza el nuevo nombre en la base de datos
            modificar.APELLIDO1 = Apellido1;//actualizar el nuevo valor de apellido1 en la base de datos
            modificar.APELLIDO2 = Apellido2;//actualiza el nuevo valor de apellido2 en la base de datos
            modificar.TELEFONO = telefono; //actualiza el telefono en la base de datos
           
            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito el cliente";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarClientes(int cod)//metodo que elimina los datos de un cliente
        {
            var eliminar = (from dato in logica.TBL_CLIENTES where dato.ID_CLIENTE == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de clientes segun la identificacion del cliente

            logica.TBL_CLIENTES.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito el Cliente";//envia el mensaje de que se elimino con exito
        }

        public string insertarProveedores(String proveedor, String nombreContacto, int telefonos, String sitioWeb) //metodo que inserta los datos de un proveedor
        {
            var insertar = new TBL_PROVEEDORES(); //variable que se utiliza para agregar datos a la tabla en especifica de proveedores

            insertar.PROVEEDOR = proveedor;//inserta el proveedor en la base de datos
            insertar.NOMBRE_CONTACTO = nombreContacto;//inserta el contacto en la base de datos
            insertar.TELEFONO = telefonos;//inserta el telefono en la base de datos
            insertar.SITIO_WEB = sitioWeb;//inserta el sitio web en la base de datos

            logica.TBL_PROVEEDORES.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito el proveedor"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarProveedores(int cod, String proveedor, String nombreContacto, int telefonos, String sitioWeb)//metodo que mofifica los datos de un cliente
        {
            var modificar = (from dato in logica.TBL_PROVEEDORES where dato.ID_PROVEEDOR == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de empleados segun la identificacion del proveedor

            modificar.PROVEEDOR = proveedor;//actualiza el nuevo nombre de proveedor en la base de datos
            modificar.NOMBRE_CONTACTO = nombreContacto;//actualizar el nuevo valor de nombre del contacto en la base de datos
            modificar.TELEFONO = telefonos;//actualiza el nuevo valor de telefono en la base de datos
            modificar.SITIO_WEB = sitioWeb; //actualiza el sitio web en la base de datos

            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito el proveedor";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarProveedores(int cod)//metodo que elimina los datos de un cliente
        {
            var eliminar = (from dato in logica.TBL_PROVEEDORES where dato.ID_PROVEEDOR == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de clientes segun la identificacion del proveedor

            logica.TBL_PROVEEDORES.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito el proveedor";//envia el mensaje de que se elimino con exito
        }


        public string insertarProducto(String nombre, String tipo, int precio, String descripcion) //metodo que inserta los datos de un producto
        {
            var insertar = new TBL_PRODUCTOS(); //variable que se utiliza para agregar datos a la tabla en especifica de producto

            insertar.NOMBRE = nombre;//inserta el nombre del producto en la base de datos
            insertar.TIPO = tipo;//inserta el tipo de producto en la base de datos
            insertar.PRECIO = precio;//inserta el precio en la base de datos
            insertar.DESCRIPCION = descripcion;//inserta la descripcion web en la base de datos

            logica.TBL_PRODUCTOS.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito el producto"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarProducto(int cod, String nombre, String tipo, int precio, String descripcion)//metodo que mofifica los datos de un producto
        {
            var modificar = (from dato in logica.TBL_PRODUCTOS where dato.ID_PRODUCTO == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de empleados segun la identificacion del producto

            modificar.NOMBRE = nombre;//actualiza el nuevo nombre de producto en la base de datos
            modificar.TIPO = tipo;//actualizar el nuevo valor de tipo en la base de datos
            modificar.PRECIO = precio;//actualiza el nuevo valor de precio en la base de datos
            modificar.DESCRIPCION = descripcion; //actualiza la descripcion en la base de datos

            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito el producto";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarProducto(int cod)//metodo que elimina los datos de un cliente
        {
            var eliminar = (from dato in logica.TBL_PRODUCTOS where dato.ID_PRODUCTO == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de clientes segun la identificacion del producto

            logica.TBL_PRODUCTOS.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito el producto";//envia el mensaje de que se elimino con exito
        }

        public string insertarRegistro(String ingrediente, DateTime vencimiento, String marca, int idProveedor) //metodo que inserta los datos de un ingrediente
        {
            var insertar = new TBL_INVENTARIO(); //variable que se utiliza para agregar datos a la tabla en especifica de inventario

            insertar.INGREDIENTE = ingrediente;//inserta el nombre del ingrediente en la base de datos
            insertar.VENCIMIENTO = vencimiento;//inserta el vencimiento en la base de datos
            insertar.MARCA = marca;//inserta la marca en la base de datos
            insertar.ID_PROVEEDOR = idProveedor;//inserta el identificador del proveedor en la base de datos

            logica.TBL_INVENTARIO.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito el registro"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarInventario(int cod, String ingrediente, DateTime vencimiento, String marca, int idProveedor)//metodo que mofifica los datos de un producto
        {
            var modificar = (from dato in logica.TBL_INVENTARIO where dato.ID_INVENTARIO == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de empleados segun la identificacion del registro

            modificar.INGREDIENTE = ingrediente;//actualiza el nuevo nombre de registro en la base de datos
            modificar.VENCIMIENTO = vencimiento;//actualizar el nuevo valor de vencimiento en la base de datos
            modificar.MARCA = marca;//actualiza el nuevo valor de marca en la base de datos
            modificar.ID_PROVEEDOR = idProveedor; //actualiza el id del proveedor en la base de datos

            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito el inventario";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarInventario(int cod)//metodo que elimina los datos de un registro
        {
            var eliminar = (from dato in logica.TBL_INVENTARIO where dato.ID_INVENTARIO == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de clientes segun la identificacion del registro

            logica.TBL_INVENTARIO.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito el registro";//envia el mensaje de que se elimino con exito
        }

        public string insertarMesa(int idSucursal, int capacidad) //metodo que inserta los datos de una mesa
        {
            var insertar = new TBL_MESAS(); //variable que se utiliza para agregar datos a la tabla en especifica de mesas

            insertar.ID_SUCURSAL= idSucursal;//inserta el id de la sucursal en la base de datos
            insertar.CAPACIDAD = capacidad;//inserta la capacidad de la mesa en la base de datos

            logica.TBL_MESAS.Add(insertar);//inserta todos los datos que se pasaron como parametros y se guardaron en insertar, de esta forma se guardan en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se guardo con exito la mesa"; //envia el mensaje de que se guardo con exito

        }

        public string ModificarMesa(int cod, int idSucursal, int capacidad)//metodo que mofifica los datos de un producto
        {
            var modificar = (from dato in logica.TBL_MESAS where dato.ID_MESA == cod select dato).FirstOrDefault();//variable que se utiliza para actualizar datos a la tabla en especifica de mesas

            modificar.ID_SUCURSAL = idSucursal;//actualiza el nuevo id de sucursal en la base de datos
            modificar.CAPACIDAD = capacidad;//actualizar el nuevo valor de capacidad en la base de datos
         

            logica.SaveChanges();// se guardan los cambios

            return "Se actualizo con exito la mesa";//retorna un mensaje avisando que se actualizo con exito
        }

        public string eliminarMesa(int cod)//metodo que elimina los datos de un registro
        {
            var eliminar = (from dato in logica.TBL_MESAS where dato.ID_MESA == cod select dato).FirstOrDefault();//variable que se utiliza para eliminar datos a la tabla en especifica de mesas

            logica.TBL_MESAS.Remove(eliminar);//elimina todos los datos que se pasaron como parametros y se guardaron en eliminar, de esta forma se borran en la base de datos
            logica.SaveChanges();//guarda los cambios hechos

            return "Se elimino con exito la mesa";//envia el mensaje de que se elimino con exito
        }




        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

     
   
        
    }
}
