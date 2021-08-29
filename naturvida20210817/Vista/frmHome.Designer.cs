
namespace naturvida20210817.Vista
{
    partial class frmHome
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panInfo = new System.Windows.Forms.Panel();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.Green;
            this.panMenu.Controls.Add(this.btnVendedores);
            this.panMenu.Controls.Add(this.lblDocumento);
            this.panMenu.Controls.Add(this.lblNombre);
            this.panMenu.Controls.Add(this.btnSecond);
            this.panMenu.Controls.Add(this.btnThird);
            this.panMenu.Controls.Add(this.btnFirst);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(200, 446);
            this.panMenu.TabIndex = 0;
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.White;
            this.btnVendedores.Location = new System.Drawing.Point(0, 370);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(200, 76);
            this.btnVendedores.TabIndex = 5;
            this.btnVendedores.Text = "VENDEDORES";
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(57, 33);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // btnSecond
            // 
            this.btnSecond.BackColor = System.Drawing.Color.White;
            this.btnSecond.Location = new System.Drawing.Point(0, 190);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(200, 76);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "CLIENTES";
            this.btnSecond.UseVisualStyleBackColor = false;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.Color.White;
            this.btnThird.Location = new System.Drawing.Point(0, 281);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(200, 76);
            this.btnThird.TabIndex = 2;
            this.btnThird.Text = "FACTURA";
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(0, 98);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(200, 76);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "INVENTARIO";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.Color.White;
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInfo.Location = new System.Drawing.Point(200, 0);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(783, 446);
            this.panInfo.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 446);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panMenu);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NATURVIDA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVendedores;
    }
}