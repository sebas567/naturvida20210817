using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naturvida20210817.Modelo;

namespace naturvida20210817.Controlador
{
    public class LoinController
    {
        //Metodo de validación de usuario y contraseña
        public vendedores login(string User, string password)
        {
            string password1 = Encriptacion.GetSHA1(password);
            using (naturvidaclaseEntities db = new naturvidaclaseEntities())
            {
                var registro = db.vendedores.Where(x => x.usuario == User).Where(x => x.contraseña == password1).FirstOrDefault();

                return registro;

            }

        }
    }
}
