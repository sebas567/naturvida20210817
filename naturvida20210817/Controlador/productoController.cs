using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naturvida20210817.Modelo;

namespace naturvida20210817.Controlador
{
    class productoController
    {
        //Metodo para mostar productos
        public List<productos> SelectProductos()
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                return db.productos.ToList();
            }

        }

        //Metodo de ingresar productos

        public int AddProductos(string codigo, string descripcion, decimal valor_unidad, int cantidad)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_AddProducto (codigo, descripcion, valor_unidad, cantidad);
            }
            return result;
        }

        //Metodo para actualizar

        public int updateProducto(string codigo, string descripcion, decimal valor_unidad, int cantidad)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_updProducto(codigo, descripcion, valor_unidad, cantidad);
            }
            return result;
        }

        //Metodo de eliminar

        public int DelProducto(string codigo)
        {
            int result;
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                result = db.sp_RemProducto(codigo);
            }
            return result;
        }

        //metodo de para el txt de busqueda
        public List<productos> buscarProducto(string descrip)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {

              List<productos> busqueda = (from d in db.productos
                                                where d.Descripción.Contains(descrip)
                                                select d).ToList();
                return busqueda.ToList();
            }
        }
        public List<productos> AgregarProducto(string codigo)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {

                return db.productos.ToList();
            }

        }

    }
}
