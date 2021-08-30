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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        ClientesController objclienteController = new ClientesController();
        productoController objproductoController = new productoController();
        facturaController objfacturaController = new facturaController();
        string[,] detalleProducto = new string[500, 5];
        int fila;

        private void recargar()
        {
            txtNumero.Text = Convert.ToString(objfacturaController.numFac() + 1);
            llenarComboCliente();
            llenarComboProducto();
            txtCantidad.Text = "";
            dgvFactura.Rows.Clear();
            txtTotalFac.Text = "";
        }


        private void frmFactura_Load(object sender, EventArgs e)
        {
          recargar();
        }

        public void llenarComboCliente()
        {
            cbCliente.DataSource = objclienteController.SelectClientes();
            cbCliente.DisplayMember = "nombre";
            cbCliente.ValueMember = "documento";
        }
        public void llenarComboProducto()
        {
            cbProducto.DataSource = objproductoController.SelectProductos();
            cbProducto.DisplayMember = "Descripción";
            cbProducto.ValueMember = "Codigo";
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text != "" && cbCliente.SelectedItem.ToString() != "" && cbProducto.SelectedItem.ToString() != "") 
            {
                var producto = objfacturaController.AgregarProducto(cbProducto.SelectedValue.ToString());

                detalleProducto[fila, 0] = producto.Codigo;
                detalleProducto[fila, 1] = producto.Descripción;
                detalleProducto[fila, 2] = producto.Valor_Unidad.ToString();
                detalleProducto[fila, 3] = txtCantidad.Text;
                detalleProducto[fila, 4] = Convert.ToString(producto.Valor_Unidad * Convert.ToInt32(txtCantidad.Text));

                dgvFactura.Rows.Add(detalleProducto[fila, 0], detalleProducto[fila, 1], detalleProducto[fila, 2], detalleProducto[fila, 3], detalleProducto[fila, 4]);

                fila++;

                txtTotalFac.Text = calTotal();
            }
            else
            {
                MessageBox.Show("Algunos campos no han sido ingresados","Error");
            }

        }

        public string calTotal()
        {
            float total = 0;
            for (int i = 0; i < fila;i++)
            {
                total = total + float.Parse(dgvFactura.Rows[i].Cells[4].Value.ToString());
            }
            return total.ToString();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if(txtCantidad.Text != "")
            {
                btnAgregarProd.Enabled = true;
            }
            else
            {
                btnAgregarProd.Enabled = false;
            }
        }

        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(dgvFactura.RowCount != 0)
            {
                btnTerminarFac.Enabled = true;
            }
            else
            {
                btnTerminarFac.Enabled = false;
            }
           
        }

        private void btnTerminarFac_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("Confima terminar factura "+txtNumero.Text+" por valor total de: "+txtTotalFac.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cerrar == DialogResult.Yes)
            {
                objfacturaController.addFactura(Convert.ToInt32(txtNumero.Text), dtpFecha.Value, cbCliente.SelectedValue.ToString(), modVariables.documento);

                for (int i = 0; i < fila; i++)
                {
                    objfacturaController.addFacturaDetalle(Convert.ToInt32(txtNumero.Text), dgvFactura.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(txtCantidad.Text), decimal.Parse(dgvFactura.Rows[i].Cells[2].Value.ToString()));

                    var producto = objfacturaController.AgregarProducto(dgvFactura.Rows[i].Cells[0].Value.ToString());

                    

                    objproductoController.updateProducto(producto.Codigo, producto.Descripción, Convert.ToDecimal(producto.Valor_Unidad)
                        ,Convert.ToInt32(producto.Cantidad) - Convert.ToInt32( dgvFactura.Rows[i].Cells[3].Value));
                }

                fila = 0;

                MessageBox.Show("Factura generada","Venta exitosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargar();
            }
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloNumeros(e);
        }
    }
}
