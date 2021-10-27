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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        //Aqui empizan los metodos

        //Instancia del controlador de clientes
        ClientesController ojbClienteController = new ClientesController();


        //Metodo de llenado de DataGridView
        public void LlenarTabla()
        {
            dgvClientes.DataSource = ojbClienteController.SelectClientes();
        }

        //Metodo de limpiar

        public void LimpiarForm()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            LblRestricción.Text = "";
            txtDocumento.Enabled = true;
            txtDocumento.Focus();

        }

        //Evento load del formulario
        private void frmClientes_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            LimpiarForm();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtDocumento.Text == "") || (txtNombre.Text == "") || (txtDireccion.Text == "") || (txtTelefono.Text == "") || (txtCorreo.Text == ""))
                {
                    LblRestricción.Text = "Algunos campos no han sido llenados";
                }
                else
                {
                    if (utilidades.validarEmail(txtCorreo.Text) == true)
                    {
                        int result = ojbClienteController.AddCliente(txtDocumento.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
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
                    else
                    {
                        MessageBox.Show("Correo invalido.No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvClientes.SelectedRows.Count == 1)
            {
                txtDocumento.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtDocumento.Enabled = false;
            }

        }

        //Evento para llenar cajas
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCajas();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            LblRestricción.Text = "";
        }

        //Evento del boton actualizar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumento.Text == "")
                {
                    LblRestricción.Text = "No ha escogido ningun vendedor\n          para actualizar";
                }
                else
                {
                    DialogResult decision = MessageBox.Show("Esta seguro de actualizar el cliente " + dgvClientes.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (decision == DialogResult.Yes)
                    {
                        if (utilidades.validarEmail(txtCorreo.Text) == true)
                        {
                            int result = ojbClienteController.updateCliente(txtDocumento.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                            LlenarTabla();
                            LimpiarForm();
                            if (result != 1)
                            {
                                MessageBox.Show("Algo salio mal.No se pudo actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                LblRestricción.ForeColor = Color.Green;
                                LblRestricción.Text = "Registro actualizado con exito";
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo es invalido.No se pudo actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch
            {
               MessageBox.Show("Algo salio mal.Comunicate con el alministrador","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //Evento para eliminar cliente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumento.Text == "")
                {
                    LblRestricción.Text = "No ha escogido ningun vendedor\n          para actualizar";
                }
                else
                {
                    DialogResult decision = MessageBox.Show("Esta seguro de eliminar el cliente " + dgvClientes.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (decision == DialogResult.Yes)
                    {
                        int result = ojbClienteController.DelCliente(txtDocumento.Text);
                        LlenarTabla();
                        LimpiarForm();

                        if (result != 1)
                        {
                            MessageBox.Show("Algo salio mal.No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            LblRestricción.ForeColor = Color.Green;
                            LblRestricción.Text = "Registro eliminado con exito";
                        }


                    }
                }
            }
            catch
            {
                MessageBox.Show("Algo salio mal.Comunicate con el alministrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Evento para limpiar cajas
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        //Evento para activar y desactivar los botones
        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if(txtDocumento.Text != "")
            {
                btnGuardar.Enabled = true;
                LblRestricción.Text = "";
            }
            else
            {
                btnGuardar.Enabled = false;
            }

        }


        //Evento del txt para buscar a medida que se escribe
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "") 
            { 
                dgvClientes.DataSource = ojbClienteController.buscarCliente(txtBuscar.Text.Trim());
            }
            else
            {
                LlenarTabla();
            }
                
        }

        //eventos de utilización de las validaciones
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloNumeros(e);
        }

        //Validacion instantanea del correo
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(utilidades.validarEmail(txtCorreo.Text) == false)
            {
                LblRestricción.Text = "Este correo no es valido";
                LblRestricción.ForeColor = Color.Red;
            }
            else
            {
                LblRestricción.Text = "";
            }
        }
    }
}
