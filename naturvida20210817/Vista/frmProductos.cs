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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }


        //Aqui empieza 
        //Instancia del controlador
        productoController ojbClienteController = new productoController();

        //Evento de carga del formulario
        private void frmProductos_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            LimpiarForm();
        }

        //Metodo de llenado de DataGridView
        public void LlenarTabla()
        {
            dgvProductos.DataSource = ojbClienteController.SelectProductos();
        }

        //Metodo de limpiar

        public void LimpiarForm()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtValorUnidad.Clear();
            txtCantidad.Clear();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            LblRestricción.Text = "";
            txtCodigo.Enabled = true;
            txtCodigo.Focus();

        }
        //Evento de boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCodigo.Text == "") || (txtDescripcion.Text == "") || (txtValorUnidad.Text == "") || (txtCantidad.Text == ""))
                {
                    LblRestricción.Text = "Algunos campos no han sido llenados";
                }
                else
                {
                    int result = ojbClienteController.AddProductos(txtCodigo.Text, txtDescripcion.Text, Convert.ToDecimal(txtValorUnidad.Text), Convert.ToInt32(txtCantidad.Text));
                    LblRestricción.Text = "";
                    LlenarTabla();
                    LimpiarForm();

                    if (result != 1)
                    {
                        MessageBox.Show("Algo salio mal.No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LblRestricción.ForeColor = Color.Green;
                        LblRestricción.Text = "Registro guardado con exito";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Algo salio mal.Comunicate con el alministrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Rellenar Cajas de texto

        public void LlenarCajas()
        {
            if (dgvProductos.SelectedRows.Count == 1)
            {
                txtCodigo.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtValorUnidad.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtCodigo.Enabled = false;
            }

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCajas();
            LblRestricción.Text = "";
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult decision = MessageBox.Show("Esta seguro de actualizar el producto " + dgvProductos.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    int result = ojbClienteController.updateProducto(txtCodigo.Text, txtDescripcion.Text, Convert.ToDecimal(txtValorUnidad.Text), Convert.ToInt32(txtCantidad.Text));
                    LlenarTabla();
                    LimpiarForm();

                    if (result != 1)
                    {
                        MessageBox.Show("Algo salio mal.No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LblRestricción.ForeColor = Color.Green;
                        LblRestricción.Text = "Registro guardado con exito";
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Algo salio mal.Comunicate con el alministrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult decision = MessageBox.Show("Esta seguro de eliminar el producto " + dgvProductos.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    int result = ojbClienteController.DelProducto(txtCodigo.Text);
                    LlenarTabla();
                    LimpiarForm();

                    if (result != 1)
                    {
                        MessageBox.Show("Algo salio mal.No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LblRestricción.ForeColor = Color.Green;
                        LblRestricción.Text = "Registro guardado con exito";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Algo salio mal.Comunicate con el alministrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        //Evento para habilitar el boton de guardar
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnGuardar.Enabled = true;
                LblRestricción.Text = "";
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        //evento para la busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvProductos.DataSource = ojbClienteController.buscarProducto(txtBuscar.Text.Trim());
            }
            else
            {
                LlenarTabla();
            }
        }

        //Validacion de las cajas de texto
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloNumeros(e);
        }

        
        private void txtValorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.Decimales(e);
        }
    }
}
