using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naturvida20210817.Vista
{
    //Clase para generar algunas herramientas necesarias en los forms
    public class utilidades
    {
        //Metodos de validación de las cajas

        //solo numeros

        public static DialogResult cerrarForm;
        public static void soloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //solo Letras

        public static void soloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar >= 238) || (e.KeyChar >= 240 && e.KeyChar >= 248) || (e.KeyChar >= 250 && e.KeyChar >= 255))
            {
                e.Handled = true;
            }
        }


        //validar correo electronico

        public static Boolean validarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //validar solo decimales

        public static void Decimales(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //Evento para cerrar el programa
        public static void cerrarPrograma( DialogResult cerrar ,FormClosingEventArgs e)
        {
            if (cerrar == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
