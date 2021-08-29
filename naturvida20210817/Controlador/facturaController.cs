using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naturvida20210817.Modelo;

namespace naturvida20210817.Controlador
{
    public class facturaController
    {
        //Metodo para agregar producto al dataGridView
        public productos AgregarProducto(string codigo)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                productos prod = (from d in db.productos
                            where d.Codigo == codigo
                            select d).FirstOrDefault();

                return prod;
            }

        }

        public void addFactura(int numero,DateTime fecha,string cliente,string vendedor)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                db.AddFactura(numero, fecha, cliente, vendedor);
            }
        }

        //Metoodo para seleccionar el documeto del cliente
        public productos selectDocClient(string codigo)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                productos prod = (from d in db.productos
                                  where d.Codigo == codigo
                                  select d).FirstOrDefault();

                return prod;
            }

        }

        public void addFacturaDetalle(int numeroFac, string codProducto, int cantidad, decimal valorUnitario)
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                db.AddFacturaDetalle(numeroFac, codProducto, cantidad, valorUnitario);
            }
        }

        public int numFac()
        {
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                int i = 0;
                var last = (from d in db.factura
                            orderby d.Numero descending
                            select d).FirstOrDefault();
                if(last != null) 
                {
                    i = Convert.ToInt32(last.Numero);
                }
                return i;
            }

        }
    }


}

