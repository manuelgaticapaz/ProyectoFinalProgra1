namespace ProyectoFinal
{
    partial class frmReserva
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
            this.cmbNombreReserva = new System.Windows.Forms.ComboBox();
            this.cmbIDReserva = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdHuesped = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnVerDisponibilidad = new System.Windows.Forms.Button();
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.txtNombrePuerta = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblPrecioEstadia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCantidadNoches = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Reservación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación:";
            // 
            // cmbNombreReserva
            // 
            this.cmbNombreReserva.FormattingEnabled = true;
            this.cmbNombreReserva.Location = new System.Drawing.Point(139, 28);
            this.cmbNombreReserva.Name = "cmbNombreReserva";
            this.cmbNombreReserva.Size = new System.Drawing.Size(203, 21);
            this.cmbNombreReserva.TabIndex = 4;
            // 
            // cmbIDReserva
            // 
            this.cmbIDReserva.FormattingEnabled = true;
            this.cmbIDReserva.Location = new System.Drawing.Point(427, 28);
            this.cmbIDReserva.Name = "cmbIDReserva";
            this.cmbIDReserva.Size = new System.Drawing.Size(203, 21);
            this.cmbIDReserva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id. Huesped:";
            // 
            // cmbIdHuesped
            // 
            this.cmbIdHuesped.FormattingEnabled = true;
            this.cmbIdHuesped.Location = new System.Drawing.Point(139, 68);
            this.cmbIdHuesped.Name = "cmbIdHuesped";
            this.cmbIdHuesped.Size = new System.Drawing.Size(203, 21);
            this.cmbIdHuesped.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad Personas:";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Location = new System.Drawing.Point(454, 68);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(176, 20);
            this.txtCantidadPersonas.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Salida:";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(139, 111);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(203, 20);
            this.dtpIngreso.TabIndex = 16;
            // 
            // dtpSalida
            // 
            this.dtpSalida.CustomFormat = "dd/mm/yyyy";
            this.dtpSalida.Location = new System.Drawing.Point(426, 111);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(203, 20);
            this.dtpSalida.TabIndex = 17;
            // 
            // btnVerDisponibilidad
            // 
            this.btnVerDisponibilidad.Location = new System.Drawing.Point(426, 154);
            this.btnVerDisponibilidad.Name = "btnVerDisponibilidad";
            this.btnVerDisponibilidad.Size = new System.Drawing.Size(123, 23);
            this.btnVerDisponibilidad.TabIndex = 18;
            this.btnVerDisponibilidad.Text = "Ver Disponibilidad";
            this.btnVerDisponibilidad.UseVisualStyleBackColor = true;
            this.btnVerDisponibilidad.Click += new System.EventHandler(this.btnVerDisponibilidad_Click);
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Location = new System.Drawing.Point(26, 195);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.Size = new System.Drawing.Size(604, 150);
            this.dgvReservaciones.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Id Habitación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nivel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Capacidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Identificación Puerta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "Precio Estadía:";
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Location = new System.Drawing.Point(139, 370);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(203, 20);
            this.txtIdHabitacion.TabIndex = 25;
            // 
            // txtNombrePuerta
            // 
            this.txtNombrePuerta.Location = new System.Drawing.Point(139, 412);
            this.txtNombrePuerta.Name = "txtNombrePuerta";
            this.txtNombrePuerta.Size = new System.Drawing.Size(203, 20);
            this.txtNombrePuerta.TabIndex = 26;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(426, 370);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(203, 20);
            this.txtNivel.TabIndex = 27;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(426, 412);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(203, 20);
            this.txtCapacidad.TabIndex = 28;
            // 
            // lblPrecioEstadia
            // 
            this.lblPrecioEstadia.AutoSize = true;
            this.lblPrecioEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEstadia.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioEstadia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrecioEstadia.Location = new System.Drawing.Point(448, 462);
            this.lblPrecioEstadia.Name = "lblPrecioEstadia";
            this.lblPrecioEstadia.Size = new System.Drawing.Size(0, 31);
            this.lblPrecioEstadia.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Cantidad de Noches:";
            // 
            // lblCantidadNoches
            // 
            this.lblCantidadNoches.AutoSize = true;
            this.lblCantidadNoches.Location = new System.Drawing.Point(136, 159);
            this.lblCantidadNoches.Name = "lblCantidadNoches";
            this.lblCantidadNoches.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadNoches.TabIndex = 32;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 566);
            this.Controls.Add(this.lblCantidadNoches);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrecioEstadia);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtNombrePuerta);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvReservaciones);
            this.Controls.Add(this.btnVerDisponibilidad);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidadPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdHuesped);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIDReserva);
            this.Controls.Add(this.cmbNombreReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReserva";
            this.Text = "Reservación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombreReserva;
        private System.Windows.Forms.ComboBox cmbIDReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIdHuesped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Button btnVerDisponibilidad;
        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.TextBox txtNombrePuerta;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblPrecioEstadia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCantidadNoches;
    }
}