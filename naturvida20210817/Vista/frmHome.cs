using System;
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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmProductos());
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(utilidades.cerrarPrograma);
            lblDocumento.Text = modVariables.documento;
            lblNombre.Text = modVariables.nombre;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {

            abrirfrm(new frmFactura());
            
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmClientes());
        }

        //Metodo para asinar formularios al panel
        public void abrirfrm(object frmX)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);//eliminamos los controles en el interior del panel
            Form cp = frmX as Form;//creamos un formulario  y va a ser igual al objeto que recibe la funcion y lo convertimos con la palabra as
            cp.TopLevel = false;//cambiamos las propiedades del formulario para que no sea de nivel superior
            cp.Dock = DockStyle.Fill;// para que se acople a todo el panel contenedor
            panInfo.Controls.Add(cp);
            cp.Show();

        }

        public void datosVendedor(string documento,string nombre)
        {
            lblDocumento.Text = documento;
            lblNombre.Text = nombre;
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmVendedores());
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            utilidades.cerrarForm = MessageBox.Show("¿Esta seguro de cerrar el programa", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            utilidades.cerrarPrograma(utilidades.cerrarForm,e);
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
