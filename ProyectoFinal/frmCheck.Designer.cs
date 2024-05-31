namespace ProyectoFinal
{
    partial class frmCheck
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
            this.cmbNombreHuesped = new System.Windows.Forms.ComboBox();
            this.cmbIdHuesped = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdReservacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCheckIn = new System.Windows.Forms.CheckBox();
            this.btnEjecutarCheckIn = new System.Windows.Forms.Button();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.dgvCheckOut = new System.Windows.Forms.DataGridView();
            this.btnEjecutarCheckOut = new System.Windows.Forms.Button();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.cmbIdReservacionOut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIdHuespedOut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNombreHuespedOut = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservaciones disponibles para Check In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Huesped:";
            // 
            // cmbNombreHuesped
            // 
            this.cmbNombreHuesped.FormattingEnabled = true;
            this.cmbNombreHuesped.Location = new System.Drawing.Point(119, 45);
            this.cmbNombreHuesped.Name = "cmbNombreHuesped";
            this.cmbNombreHuesped.Size = new System.Drawing.Size(193, 21);
            this.cmbNombreHuesped.TabIndex = 2;
            // 
            // cmbIdHuesped
            // 
            this.cmbIdHuesped.FormattingEnabled = true;
            this.cmbIdHuesped.Location = new System.Drawing.Point(454, 45);
            this.cmbIdHuesped.Name = "cmbIdHuesped";
            this.cmbIdHuesped.Size = new System.Drawing.Size(193, 21);
            this.cmbIdHuesped.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificación Huesped:";
            // 
            // cmbIdReservacion
            // 
            this.cmbIdReservacion.FormattingEnabled = true;
            this.cmbIdReservacion.Location = new System.Drawing.Point(783, 45);
            this.cmbIdReservacion.Name = "cmbIdReservacion";
            this.cmbIdReservacion.Size = new System.Drawing.Size(193, 21);
            this.cmbIdReservacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo Reservación:";
            // 
            // chkCheckIn
            // 
            this.chkCheckIn.AutoSize = true;
            this.chkCheckIn.Location = new System.Drawing.Point(341, 88);
            this.chkCheckIn.Name = "chkCheckIn";
            this.chkCheckIn.Size = new System.Drawing.Size(180, 17);
            this.chkCheckIn.TabIndex = 7;
            this.chkCheckIn.Text = "Registrar Check In del Huesped.";
            this.chkCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnEjecutarCheckIn
            // 
            this.btnEjecutarCheckIn.Location = new System.Drawing.Point(634, 84);
            this.btnEjecutarCheckIn.Name = "btnEjecutarCheckIn";
            this.btnEjecutarCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutarCheckIn.TabIndex = 8;
            this.btnEjecutarCheckIn.Text = "Ejecutar";
            this.btnEjecutarCheckIn.UseVisualStyleBackColor = true;
            this.btnEjecutarCheckIn.Click += new System.EventHandler(this.btnEjecutarCheckIn_Click);
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Location = new System.Drawing.Point(23, 115);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.Size = new System.Drawing.Size(953, 150);
            this.dgvCheckIn.TabIndex = 9;
            // 
            // dgvCheckOut
            // 
            this.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOut.Location = new System.Drawing.Point(23, 440);
            this.dgvCheckOut.Name = "dgvCheckOut";
            this.dgvCheckOut.ReadOnly = true;
            this.dgvCheckOut.Size = new System.Drawing.Size(953, 150);
            this.dgvCheckOut.TabIndex = 19;
            // 
            // btnEjecutarCheckOut
            // 
            this.btnEjecutarCheckOut.Location = new System.Drawing.Point(634, 409);
            this.btnEjecutarCheckOut.Name = "btnEjecutarCheckOut";
            this.btnEjecutarCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutarCheckOut.TabIndex = 18;
            this.btnEjecutarCheckOut.Text = "Ejecutar";
            this.btnEjecutarCheckOut.UseVisualStyleBackColor = true;
            this.btnEjecutarCheckOut.Click += new System.EventHandler(this.btnEjecutarCheckOut_Click);
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(341, 413);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(180, 17);
            this.chkCheckOut.TabIndex = 17;
            this.chkCheckOut.Text = "Registrar Check In del Huesped.";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // cmbIdReservacionOut
            // 
            this.cmbIdReservacionOut.FormattingEnabled = true;
            this.cmbIdReservacionOut.Location = new System.Drawing.Point(783, 370);
            this.cmbIdReservacionOut.Name = "cmbIdReservacionOut";
            this.cmbIdReservacionOut.Size = new System.Drawing.Size(193, 21);
            this.cmbIdReservacionOut.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo Reservación:";
            // 
            // cmbIdHuespedOut
            // 
            this.cmbIdHuespedOut.FormattingEnabled = true;
            this.cmbIdHuespedOut.Location = new System.Drawing.Point(454, 370);
            this.cmbIdHuespedOut.Name = "cmbIdHuespedOut";
            this.cmbIdHuespedOut.Size = new System.Drawing.Size(193, 21);
            this.cmbIdHuespedOut.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Identificación Huesped:";
            // 
            // cmbNombreHuespedOut
            // 
            this.cmbNombreHuespedOut.FormattingEnabled = true;
            this.cmbNombreHuespedOut.Location = new System.Drawing.Point(119, 370);
            this.cmbNombreHuespedOut.Name = "cmbNombreHuespedOut";
            this.cmbNombreHuespedOut.Size = new System.Drawing.Size(193, 21);
            this.cmbNombreHuespedOut.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre Huesped:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Reservaciones disponibles para Check Out:";
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 636);
            this.Controls.Add(this.dgvCheckOut);
            this.Controls.Add(this.btnEjecutarCheckOut);
            this.Controls.Add(this.chkCheckOut);
            this.Controls.Add(this.cmbIdReservacionOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdHuespedOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbNombreHuespedOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCheckIn);
            this.Controls.Add(this.btnEjecutarCheckIn);
            this.Controls.Add(this.chkCheckIn);
            this.Controls.Add(this.cmbIdReservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdHuesped);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNombreHuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCheck";
            this.Text = "Check In/Out";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombreHuesped;
        private System.Windows.Forms.ComboBox cmbIdHuesped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdReservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCheckIn;
        private System.Windows.Forms.Button btnEjecutarCheckIn;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridView dgvCheckOut;
        private System.Windows.Forms.Button btnEjecutarCheckOut;
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.ComboBox cmbIdReservacionOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIdHuespedOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNombreHuespedOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}