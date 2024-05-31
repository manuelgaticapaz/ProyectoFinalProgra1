namespace ProyectoFinal
{
    partial class frmFacturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.cmbIdReservacion = new System.Windows.Forms.ComboBox();
            this.cmbNombreHuesped = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdentificacionHuesped = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerGastos = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.chkCSV = new System.Windows.Forms.CheckBox();
            this.chkNuevosDatosFacturacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione su Reservación:";
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Location = new System.Drawing.Point(15, 92);
            this.dgvFacturacion.MultiSelect = false;
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.ReadOnly = true;
            this.dgvFacturacion.Size = new System.Drawing.Size(898, 296);
            this.dgvFacturacion.TabIndex = 6;
            // 
            // cmbIdReservacion
            // 
            this.cmbIdReservacion.FormattingEnabled = true;
            this.cmbIdReservacion.Location = new System.Drawing.Point(158, 6);
            this.cmbIdReservacion.Name = "cmbIdReservacion";
            this.cmbIdReservacion.Size = new System.Drawing.Size(176, 21);
            this.cmbIdReservacion.TabIndex = 7;
            // 
            // cmbNombreHuesped
            // 
            this.cmbNombreHuesped.FormattingEnabled = true;
            this.cmbNombreHuesped.Location = new System.Drawing.Point(439, 6);
            this.cmbNombreHuesped.Name = "cmbNombreHuesped";
            this.cmbNombreHuesped.Size = new System.Drawing.Size(176, 21);
            this.cmbNombreHuesped.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre Huesped:";
            // 
            // cmbIdentificacionHuesped
            // 
            this.cmbIdentificacionHuesped.FormattingEnabled = true;
            this.cmbIdentificacionHuesped.Location = new System.Drawing.Point(733, 6);
            this.cmbIdentificacionHuesped.Name = "cmbIdentificacionHuesped";
            this.cmbIdentificacionHuesped.Size = new System.Drawing.Size(176, 21);
            this.cmbIdentificacionHuesped.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Ident. Huesped:";
            // 
            // btnVerGastos
            // 
            this.btnVerGastos.Location = new System.Drawing.Point(364, 51);
            this.btnVerGastos.Name = "btnVerGastos";
            this.btnVerGastos.Size = new System.Drawing.Size(164, 23);
            this.btnVerGastos.TabIndex = 12;
            this.btnVerGastos.Text = "Ver Gastos";
            this.btnVerGastos.UseVisualStyleBackColor = true;
            this.btnVerGastos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(613, 473);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(164, 23);
            this.btnGenerarFactura.TabIndex = 13;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(838, 473);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre Factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número Nit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 424);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(409, 424);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(219, 20);
            this.txtNit.TabIndex = 19;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(695, 424);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(218, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // chkCSV
            // 
            this.chkCSV.AutoSize = true;
            this.chkCSV.Location = new System.Drawing.Point(409, 477);
            this.chkCSV.Name = "chkCSV";
            this.chkCSV.Size = new System.Drawing.Size(88, 17);
            this.chkCSV.TabIndex = 21;
            this.chkCSV.Text = "Generar CSV";
            this.chkCSV.UseVisualStyleBackColor = true;
            // 
            // chkNuevosDatosFacturacion
            // 
            this.chkNuevosDatosFacturacion.AutoSize = true;
            this.chkNuevosDatosFacturacion.Location = new System.Drawing.Point(15, 395);
            this.chkNuevosDatosFacturacion.Name = "chkNuevosDatosFacturacion";
            this.chkNuevosDatosFacturacion.Size = new System.Drawing.Size(164, 17);
            this.chkNuevosDatosFacturacion.TabIndex = 22;
            this.chkNuevosDatosFacturacion.Text = "Cambiar datos de facturación";
            this.chkNuevosDatosFacturacion.UseVisualStyleBackColor = true;
            this.chkNuevosDatosFacturacion.CheckedChanged += new System.EventHandler(this.chkNuevosDatosFacturacion_CheckedChanged);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 510);
            this.Controls.Add(this.chkNuevosDatosFacturacion);
            this.Controls.Add(this.chkCSV);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnVerGastos);
            this.Controls.Add(this.cmbIdentificacionHuesped);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNombreHuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIdReservacion);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturacion";
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.ComboBox cmbIdReservacion;
        private System.Windows.Forms.ComboBox cmbNombreHuesped;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdentificacionHuesped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerGastos;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.CheckBox chkCSV;
        private System.Windows.Forms.CheckBox chkNuevosDatosFacturacion;
    }
}