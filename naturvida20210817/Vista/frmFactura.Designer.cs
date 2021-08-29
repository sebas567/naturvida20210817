
namespace naturvida20210817.Vista
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotalFac = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTotalFac = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTerminarFac = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(356, 9);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(63, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "FACTURA: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(41, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(61, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "NÚMERO: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(41, 86);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE: ";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(41, 139);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(74, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "PRODUCTO: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(41, 192);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(406, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "FECHA: ";
            // 
            // lblTotalFac
            // 
            this.lblTotalFac.AutoSize = true;
            this.lblTotalFac.Location = new System.Drawing.Point(406, 407);
            this.lblTotalFac.Name = "lblTotalFac";
            this.lblTotalFac.Size = new System.Drawing.Size(101, 13);
            this.lblTotalFac.TabIndex = 6;
            this.lblTotalFac.Text = "TOTAL FACTURA: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(140, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtTotalFac
            // 
            this.txtTotalFac.Enabled = false;
            this.txtTotalFac.Location = new System.Drawing.Point(527, 404);
            this.txtTotalFac.Name = "txtTotalFac";
            this.txtTotalFac.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFac.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(140, 192);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(491, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Items.AddRange(new object[] {
            "--Seleccione un cliente"});
            this.cbCliente.Location = new System.Drawing.Point(140, 86);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(208, 21);
            this.cbCliente.TabIndex = 14;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
            "--Seleccione el producto"});
            this.cbProducto.Location = new System.Drawing.Point(140, 139);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(364, 21);
            this.cbProducto.TabIndex = 15;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.valorUnitario,
            this.cantidad,
            this.subtotal});
            this.dgvFactura.Location = new System.Drawing.Point(44, 235);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(730, 150);
            this.dgvFactura.TabIndex = 16;
            this.dgvFactura.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFactura_RowsAdded);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "VALOR UNITARIO";
            this.valorUnitario.Name = "valorUnitario";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            // 
            // btnTerminarFac
            // 
            this.btnTerminarFac.Enabled = false;
            this.btnTerminarFac.Location = new System.Drawing.Point(44, 402);
            this.btnTerminarFac.Name = "btnTerminarFac";
            this.btnTerminarFac.Size = new System.Drawing.Size(138, 23);
            this.btnTerminarFac.TabIndex = 17;
            this.btnTerminarFac.Text = "TERMINAR FACTURA: ";
            this.btnTerminarFac.UseVisualStyleBackColor = true;
            this.btnTerminarFac.Click += new System.EventHandler(this.btnTerminarFac_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Enabled = false;
            this.btnAgregarProd.Location = new System.Drawing.Point(579, 139);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(138, 38);
            this.btnAgregarProd.TabIndex = 18;
            this.btnAgregarProd.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.btnTerminarFac);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtTotalFac);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTotalFac);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotalFac;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTotalFac;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnTerminarFac;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}