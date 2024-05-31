namespace ProyectoFinal
{
    partial class frmCargarServicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHuesped = new System.Windows.Forms.ComboBox();
            this.cmbIdHuesped = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdReservacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIdServicio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescuentoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkDescuentoTotal = new System.Windows.Forms.CheckBox();
            this.chkDescuentoUnitario = new System.Windows.Forms.CheckBox();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.lblPrecioSinDescuento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPrecioUnitario = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCargarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione datos para cargar servicios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Huesped:";
            // 
            // cmbHuesped
            // 
            this.cmbHuesped.FormattingEnabled = true;
            this.cmbHuesped.Location = new System.Drawing.Point(112, 41);
            this.cmbHuesped.Name = "cmbHuesped";
            this.cmbHuesped.Size = new System.Drawing.Size(179, 21);
            this.cmbHuesped.TabIndex = 2;
            // 
            // cmbIdHuesped
            // 
            this.cmbIdHuesped.FormattingEnabled = true;
            this.cmbIdHuesped.Location = new System.Drawing.Point(441, 41);
            this.cmbIdHuesped.Name = "cmbIdHuesped";
            this.cmbIdHuesped.Size = new System.Drawing.Size(179, 21);
            this.cmbIdHuesped.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Huesped:";
            // 
            // cmbIdReservacion
            // 
            this.cmbIdReservacion.FormattingEnabled = true;
            this.cmbIdReservacion.Location = new System.Drawing.Point(773, 41);
            this.cmbIdReservacion.Name = "cmbIdReservacion";
            this.cmbIdReservacion.Size = new System.Drawing.Size(179, 21);
            this.cmbIdReservacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id. Reservación:";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(16, 79);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.Size = new System.Drawing.Size(936, 150);
            this.dgvHabitaciones.TabIndex = 7;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(877, 246);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(886, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 317);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(179, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 365);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 106);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Servicio:";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(441, 316);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(179, 21);
            this.cmbServicio.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id. Servicio:";
            // 
            // cmbIdServicio
            // 
            this.cmbIdServicio.FormattingEnabled = true;
            this.cmbIdServicio.Location = new System.Drawing.Point(773, 316);
            this.cmbIdServicio.Name = "cmbIdServicio";
            this.cmbIdServicio.Size = new System.Drawing.Size(179, 21);
            this.cmbIdServicio.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Precio Unitario:";
            // 
            // txtDescuentoUnitario
            // 
            this.txtDescuentoUnitario.Location = new System.Drawing.Point(441, 405);
            this.txtDescuentoUnitario.Name = "txtDescuentoUnitario";
            this.txtDescuentoUnitario.Size = new System.Drawing.Size(179, 20);
            this.txtDescuentoUnitario.TabIndex = 19;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblPrecioTotal.Location = new System.Drawing.Point(864, 457);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 25);
            this.lblPrecioTotal.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Precio Total:";
            // 
            // chkDescuentoTotal
            // 
            this.chkDescuentoTotal.AutoSize = true;
            this.chkDescuentoTotal.Location = new System.Drawing.Point(319, 453);
            this.chkDescuentoTotal.Name = "chkDescuentoTotal";
            this.chkDescuentoTotal.Size = new System.Drawing.Size(121, 17);
            this.chkDescuentoTotal.TabIndex = 24;
            this.chkDescuentoTotal.Text = "Descuento General:";
            this.chkDescuentoTotal.UseVisualStyleBackColor = true;
            this.chkDescuentoTotal.CheckedChanged += new System.EventHandler(this.chkDescuentoTotal_CheckedChanged);
            // 
            // chkDescuentoUnitario
            // 
            this.chkDescuentoUnitario.AutoSize = true;
            this.chkDescuentoUnitario.Location = new System.Drawing.Point(319, 407);
            this.chkDescuentoUnitario.Name = "chkDescuentoUnitario";
            this.chkDescuentoUnitario.Size = new System.Drawing.Size(120, 17);
            this.chkDescuentoUnitario.TabIndex = 25;
            this.chkDescuentoUnitario.Text = "Descuento Unitario:";
            this.chkDescuentoUnitario.UseVisualStyleBackColor = true;
            this.chkDescuentoUnitario.CheckedChanged += new System.EventHandler(this.chkDescuentoUnitario_CheckedChanged);
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Location = new System.Drawing.Point(441, 451);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.Size = new System.Drawing.Size(179, 20);
            this.txtDescuentoTotal.TabIndex = 26;
            // 
            // lblPrecioSinDescuento
            // 
            this.lblPrecioSinDescuento.AutoSize = true;
            this.lblPrecioSinDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSinDescuento.Location = new System.Drawing.Point(864, 368);
            this.lblPrecioSinDescuento.Name = "lblPrecioSinDescuento";
            this.lblPrecioSinDescuento.Size = new System.Drawing.Size(0, 25);
            this.lblPrecioSinDescuento.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(674, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Precio sin Descuento:";
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuento.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDescuento.Location = new System.Drawing.Point(864, 408);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(0, 25);
            this.lblTotalDescuento.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(674, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total Descuento:";
            // 
            // cmbPrecioUnitario
            // 
            this.cmbPrecioUnitario.FormattingEnabled = true;
            this.cmbPrecioUnitario.Location = new System.Drawing.Point(441, 365);
            this.cmbPrecioUnitario.Name = "cmbPrecioUnitario";
            this.cmbPrecioUnitario.Size = new System.Drawing.Size(179, 21);
            this.cmbPrecioUnitario.TabIndex = 31;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 510);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCargarServicio
            // 
            this.btnCargarServicio.Location = new System.Drawing.Point(393, 510);
            this.btnCargarServicio.Name = "btnCargarServicio";
            this.btnCargarServicio.Size = new System.Drawing.Size(123, 23);
            this.btnCargarServicio.TabIndex = 33;
            this.btnCargarServicio.Text = "Cargar Servicio";
            this.btnCargarServicio.UseVisualStyleBackColor = true;
            this.btnCargarServicio.Click += new System.EventHandler(this.btnCargarServicio_Click);
            // 
            // frmCargarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 545);
            this.Controls.Add(this.btnCargarServicio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbPrecioUnitario);
            this.Controls.Add(this.lblTotalDescuento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblPrecioSinDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuentoTotal);
            this.Controls.Add(this.chkDescuentoUnitario);
            this.Controls.Add(this.chkDescuentoTotal);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescuentoUnitario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbIdServicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.cmbIdReservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdHuesped);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCargarServicio";
            this.Text = "Cargar Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHuesped;
        private System.Windows.Forms.ComboBox cmbIdHuesped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdReservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbIdServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescuentoUnitario;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkDescuentoTotal;
        private System.Windows.Forms.CheckBox chkDescuentoUnitario;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.Label lblPrecioSinDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPrecioUnitario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCargarServicio;
    }
}