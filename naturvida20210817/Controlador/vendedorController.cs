using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naturvida20210817.Modelo;

namespace naturvida20210817.Controlador
{
    class vendedorController
    {
        //Metodo para mostar vendedor
        public List<vendedores> SelectVendedor()
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                return db.vendedores.ToList();
            }

        }

        //Metodo de ingresar vendedor

        public int AddVendedor(string documento, string usuario, string contraseña, string nombre)
        {
            int result;
            string password = Encriptacion.GetSHA1(contraseña);
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_AddVendedor(documento, usuario, password, nombre);
            }
            return result;
        }

        //Metodo para actualizar

        public int updateVendedor(string documento, string usuario, string contraseña, string nombre)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_updVendedor(documento, usuario, contraseña, nombre);
            }
            return result;
        }

        //Metodo de eliminar

        public int DelProducto(string documento)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_RemVendedor(documento);
            }
            return result;
        }

        //metodo de para el txt de busqueda
        public List<vendedores> buscarVendedor(string nombre)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {

                IEnumerable<vendedores> busqueda = from d in db.vendedores
                                                  where d.nombre.Contains(nombre)
                                                  select d;
                return busqueda.ToList();
            }
        }
    }
}
