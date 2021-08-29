using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naturvida20210817.Modelo;


namespace naturvida20210817.Controlador
{
    class ClientesController
    {
        //Metodo para mostar clientes
        public List<cliente> SelectClientes()
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities()) 
            {
                return db.cliente.ToList(); 
            }
            
        }

        //Metodo de ingresar Clientes

        public int AddCliente(string documento, string nombre, string direccion, string telefono, string correo) 
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
             result = db.sp_Addcliente(documento,nombre,direccion,telefono,correo);
            }
            return result;
        }

        //Metodo para actualizar

        public int updateCliente (string documento, string nombre, string direccion, string telefono, string correo)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_updCliente(documento, nombre, direccion, telefono, correo);
            }
            return result;
        }

        //Metodo de eliminar

        public int DelCliente (string documento)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_remCliente(documento);
            }
            return result;
        }

        //metodo de para el txt de busqueda
        public List<cliente> buscarCliente(string nombre)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {

                IEnumerable<cliente> busqueda = from d in db.cliente
                                                where d.nombre.Contains(nombre)
                                                select d;
                return busqueda.ToList();
            }
        }
    }
}
