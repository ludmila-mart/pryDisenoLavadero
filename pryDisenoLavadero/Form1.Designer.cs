namespace pryDisenoLavadero
{
    partial class frmLavadero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCliente = new Label();
            lblPatente = new Label();
            lblServicio = new Label();
            lblVehiculo = new Label();
            txtCliente = new TextBox();
            txtPatente = new TextBox();
            cboServicio = new ComboBox();
            cboVehiculo = new ComboBox();
            chkNormal = new CheckBox();
            chkExpress = new CheckBox();
            gbxDatos = new GroupBox();
            btnLimpiar = new Button();
            btnConfirmar = new Button();
            cbxCliente = new CheckBox();
            gbxEntrega = new GroupBox();
            lblSub = new Label();
            lblRecargo = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            gbxImporte = new GroupBox();
            gbxDatos.SuspendLayout();
            gbxEntrega.SuspendLayout();
            gbxImporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 18);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(6, 65);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente:";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(6, 110);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(51, 15);
            lblServicio.TabIndex = 2;
            lblServicio.Text = "Servicio:";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(6, 159);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(83, 15);
            lblVehiculo.TabIndex = 3;
            lblVehiculo.Text = "Vehiculo (1-5):";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.ButtonHighlight;
            txtCliente.Location = new Point(59, 33);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 23);
            txtCliente.TabIndex = 4;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(59, 83);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 5;
            // 
            // cboServicio
            // 
            cboServicio.FormattingEnabled = true;
            cboServicio.Items.AddRange(new object[] { "Lavado exterior ", "Lavado exterior ", "Lavado con encerado " });
            cboServicio.Location = new Point(59, 128);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(151, 23);
            cboServicio.TabIndex = 6;
            // 
            // cboVehiculo
            // 
            cboVehiculo.FormattingEnabled = true;
            cboVehiculo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboVehiculo.Location = new Point(59, 190);
            cboVehiculo.Name = "cboVehiculo";
            cboVehiculo.Size = new Size(53, 23);
            cboVehiculo.TabIndex = 7;
            // 
            // chkNormal
            // 
            chkNormal.AutoSize = true;
            chkNormal.Location = new Point(55, 18);
            chkNormal.Name = "chkNormal";
            chkNormal.Size = new Size(66, 19);
            chkNormal.TabIndex = 8;
            chkNormal.Text = "Normal";
            chkNormal.UseVisualStyleBackColor = true;
            // 
            // chkExpress
            // 
            chkExpress.AutoSize = true;
            chkExpress.Location = new Point(211, 18);
            chkExpress.Name = "chkExpress";
            chkExpress.Size = new Size(97, 19);
            chkExpress.TabIndex = 9;
            chkExpress.Text = "Express (25%)";
            chkExpress.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(btnLimpiar);
            gbxDatos.Controls.Add(cboVehiculo);
            gbxDatos.Controls.Add(btnConfirmar);
            gbxDatos.Controls.Add(cboServicio);
            gbxDatos.Controls.Add(cbxCliente);
            gbxDatos.Controls.Add(txtPatente);
            gbxDatos.Controls.Add(gbxEntrega);
            gbxDatos.Controls.Add(txtCliente);
            gbxDatos.Controls.Add(lblVehiculo);
            gbxDatos.Controls.Add(lblServicio);
            gbxDatos.Controls.Add(lblPatente);
            gbxDatos.Controls.Add(lblCliente);
            gbxDatos.Location = new Point(6, 6);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(377, 371);
            gbxDatos.TabIndex = 10;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos del lavado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(184, 331);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(84, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 23);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // cbxCliente
            // 
            cbxCliente.AutoSize = true;
            cbxCliente.Location = new Point(7, 306);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(171, 19);
            cbxCliente.TabIndex = 12;
            cbxCliente.Text = "Cliente frecuente (5% extra)";
            cbxCliente.UseVisualStyleBackColor = true;
            cbxCliente.CheckedChanged += cbxCliente_CheckedChanged;
            // 
            // gbxEntrega
            // 
            gbxEntrega.Controls.Add(chkExpress);
            gbxEntrega.Controls.Add(chkNormal);
            gbxEntrega.Location = new Point(7, 237);
            gbxEntrega.Name = "gbxEntrega";
            gbxEntrega.Size = new Size(364, 51);
            gbxEntrega.TabIndex = 11;
            gbxEntrega.TabStop = false;
            gbxEntrega.Text = "Entrega";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(1, 14);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(54, 15);
            lblSub.TabIndex = 11;
            lblSub.Text = "Subtotal:";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(1, 49);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(53, 15);
            lblRecargo.TabIndex = 12;
            lblRecargo.Text = "Recargo:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(1, 84);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 13;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(2, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 15);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total a pagar:";
            // 
            // gbxImporte
            // 
            gbxImporte.Controls.Add(lblTotal);
            gbxImporte.Controls.Add(lblDescuento);
            gbxImporte.Controls.Add(lblRecargo);
            gbxImporte.Controls.Add(lblSub);
            gbxImporte.Location = new Point(6, 387);
            gbxImporte.Name = "gbxImporte";
            gbxImporte.Size = new Size(377, 135);
            gbxImporte.TabIndex = 15;
            gbxImporte.TabStop = false;
            gbxImporte.Text = "Importe";
            // 
            // frmLavadero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(427, 534);
            Controls.Add(gbxImporte);
            Controls.Add(gbxDatos);
            ForeColor = Color.DarkBlue;
            Name = "frmLavadero";
            Text = "Lavadeo los Andes - Calculo del Servicio";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            gbxEntrega.ResumeLayout(false);
            gbxEntrega.PerformLayout();
            gbxImporte.ResumeLayout(false);
            gbxImporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCliente;
        private Label lblPatente;
        private Label lblServicio;
        private Label lblVehiculo;
        private TextBox txtCliente;
        private TextBox txtPatente;
        private ComboBox cboServicio;
        private ComboBox cboVehiculo;
        private CheckBox chkNormal;
        private CheckBox chkExpress;
        private GroupBox gbxDatos;
        private GroupBox gbxEntrega;
        private CheckBox cbxCliente;
        private Button btnConfirmar;
        private Button btnLimpiar;
        private Label lblSub;
        private Label lblRecargo;
        private Label lblDescuento;
        private Label lblTotal;
        private GroupBox gbxImporte;
    }
}
