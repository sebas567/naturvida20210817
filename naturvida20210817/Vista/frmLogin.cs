using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using naturvida20210817.Controlador;

namespace naturvida20210817.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       LoinController ingresar = new LoinController();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var verificado = ingresar.login(txtUser.Text, txtPassword.Text);
            if (verificado != null)
            {
                modVariables.documento = verificado.documento;
                modVariables.nombre = verificado.nombre;
                frmHome objfrmhome = new frmHome();
                  this.Hide();
                  objfrmhome.Show(); 
            }
            else
            {
                MessageBox.Show("Credenciales erradas");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (utilidades.cerrarForm == DialogResult.OK)
            {
            utilidades.cerrarPrograma(utilidades.cerrarForm, e);
            }
            else
            {
                utilidades.cerrarForm = MessageBox.Show("¿Esta seguro de cerrar el programa", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                utilidades.cerrarPrograma(utilidades.cerrarForm, e);
            }
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "   Sistema de Información\nTienda Naturista Naturvida";
        }
    }
}
