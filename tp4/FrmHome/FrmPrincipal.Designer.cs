﻿
namespace FrmHome
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.rchTxtBoxClientes = new System.Windows.Forms.RichTextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnConfirmarId = new System.Windows.Forms.Button();
            this.lblListadoClientes = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusCambiando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxtBoxClientes
            // 
            this.rchTxtBoxClientes.BackColor = System.Drawing.SystemColors.Window;
            this.rchTxtBoxClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchTxtBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBoxClientes.Location = new System.Drawing.Point(609, 55);
            this.rchTxtBoxClientes.Name = "rchTxtBoxClientes";
            this.rchTxtBoxClientes.ReadOnly = true;
            this.rchTxtBoxClientes.Size = new System.Drawing.Size(355, 400);
            this.rchTxtBoxClientes.TabIndex = 0;
            this.rchTxtBoxClientes.Text = "";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(62, 55);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(478, 41);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido a la Fábrica Galáctica";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(222, 131);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(156, 32);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Eres cliente?";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Yellow;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.Location = new System.Drawing.Point(48, 206);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(235, 61);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.Yellow;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.Black;
            this.btnSi.Location = new System.Drawing.Point(330, 206);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(235, 61);
            this.btnSi.TabIndex = 4;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(38, 386);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(147, 25);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Indícanos tu ID ";
            this.lblId.Visible = false;
            // 
            // txtBoxId
            // 
            this.txtBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(218, 382);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(172, 32);
            this.txtBoxId.TabIndex = 6;
            this.txtBoxId.Visible = false;
            // 
            // btnConfirmarId
            // 
            this.btnConfirmarId.BackColor = System.Drawing.Color.Yellow;
            this.btnConfirmarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarId.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarId.Location = new System.Drawing.Point(431, 382);
            this.btnConfirmarId.Name = "btnConfirmarId";
            this.btnConfirmarId.Size = new System.Drawing.Size(148, 36);
            this.btnConfirmarId.TabIndex = 7;
            this.btnConfirmarId.Text = "Confirmar ID";
            this.btnConfirmarId.UseVisualStyleBackColor = false;
            this.btnConfirmarId.Visible = false;
            this.btnConfirmarId.Click += new System.EventHandler(this.btnConfirmarId_Click);
            // 
            // lblListadoClientes
            // 
            this.lblListadoClientes.AutoSize = true;
            this.lblListadoClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblListadoClientes.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoClientes.Location = new System.Drawing.Point(722, 9);
            this.lblListadoClientes.Name = "lblListadoClientes";
            this.lblListadoClientes.Size = new System.Drawing.Size(153, 41);
            this.lblListadoClientes.TabIndex = 8;
            this.lblListadoClientes.Text = "CLIENTES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(727, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.Color.Yellow;
            this.btnFabricar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.ForeColor = System.Drawing.Color.Black;
            this.btnFabricar.Location = new System.Drawing.Point(91, 285);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(192, 58);
            this.btnFabricar.TabIndex = 10;
            this.btnFabricar.Text = "Quiero Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Visible = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.Color.Red;
            this.btnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarBaja.Location = new System.Drawing.Point(330, 285);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(192, 58);
            this.btnDarBaja.TabIndex = 11;
            this.btnDarBaja.Text = "Quiero darme de baja";
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Visible = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(214, 461);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 25);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusCambiando
            // 
            this.lblStatusCambiando.AutoSize = true;
            this.lblStatusCambiando.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusCambiando.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCambiando.Location = new System.Drawing.Point(289, 461);
            this.lblStatusCambiando.Name = "lblStatusCambiando";
            this.lblStatusCambiando.Size = new System.Drawing.Size(0, 25);
            this.lblStatusCambiando.TabIndex = 13;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 501);
            this.Controls.Add(this.lblStatusCambiando);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblListadoClientes);
            this.Controls.Add(this.btnConfirmarId);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.rchTxtBoxClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fábrica Galáctica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBoxClientes;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnConfirmarId;
        private System.Windows.Forms.Label lblListadoClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusCambiando;
    }
}

