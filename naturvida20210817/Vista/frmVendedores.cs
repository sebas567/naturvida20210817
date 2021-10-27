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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        //Aqui empieza 
        //Instancia del controlador
        vendedorController ojbClienteController = new vendedorController();


        private void frmVendedores_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            LimpiarForm();
        }

        //Metodo de llenado de DataGridView
        public void LlenarTabla()
        {
            dgvVendedores.DataSource = ojbClienteController.SelectVendedor();
            dgvVendedores.Columns[2].Visible = false;
        }

        //Metodo de limpiar

        public void LimpiarForm()
        {
            txtDocumento.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            LblRestricción.Text = "";
            txtDocumento.Enabled = true;
            txtDocumento.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtDocumento.Text == "") || (txtUsuario.Text == "") || (txtNombre.Text == ""))
                {
                    LblRestricción.Text = "Algunos campos no han sido llenados";
                }
                else
                {
                   int result = ojbClienteController.AddVendedor(txtDocumento.Text, txtUsuario.Text, txtUsuario.Text, txtNombre.Text);
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
            if (dgvVendedores.SelectedRows.Count == 1)
            {
                txtDocumento.Text = dgvVendedores.CurrentRow.Cells[0].Value.ToString();
                txtUsuario.Text = dgvVendedores.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvVendedores.CurrentRow.Cells[3].Value.ToString();
                txtDocumento.Enabled = false;
            }

        }
        //Evento de cambio del datagridview
        private void dgvVendedores_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCajas();
            LblRestricción.Text = "";
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }
        //Evento para actualizar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                LblRestricción.Text = "No ha escogido ningun vendedor\n          para actualizar";
            }
            else
            {
                DialogResult decision = MessageBox.Show("Esta seguro de actualizar el vendedor " + dgvVendedores.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    int result = ojbClienteController.updateVendedor(txtDocumento.Text, txtUsuario.Text, txtNombre.Text);
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
        }

        //Evento del boton
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
                    DialogResult decision = MessageBox.Show("Esta seguro de eliminar el vendedor " + dgvVendedores.CurrentRow.Cells[1].Value.ToString() + ".Esta es acción es irreversible", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (decision == DialogResult.Yes)
                    {
                        int result = ojbClienteController.DelProducto(txtDocumento.Text);
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
            }
            catch
            {
                MessageBox.Show("Algo salio mal.Comunicate con el alministrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text != "")
            {
                btnGuardar.Enabled = true;
                LblRestricción.Text = "";
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        //Evento para buscar producto
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvVendedores.DataSource = ojbClienteController.buscarVendedor(txtBuscar.Text.Trim());
            }
            else
            {
                LlenarTabla();
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.soloLetras(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
