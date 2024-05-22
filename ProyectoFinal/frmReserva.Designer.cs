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
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 597);
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
    }
}