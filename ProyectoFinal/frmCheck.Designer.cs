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
            this.cmbIdReservación = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCheckIn = new System.Windows.Forms.CheckBox();
            this.btnEjecutarCheckIn = new System.Windows.Forms.Button();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
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
            // cmbIdReservación
            // 
            this.cmbIdReservación.FormattingEnabled = true;
            this.cmbIdReservación.Location = new System.Drawing.Point(783, 45);
            this.cmbIdReservación.Name = "cmbIdReservación";
            this.cmbIdReservación.Size = new System.Drawing.Size(193, 21);
            this.cmbIdReservación.TabIndex = 6;
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
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Location = new System.Drawing.Point(23, 115);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.Size = new System.Drawing.Size(953, 150);
            this.dgvCheckIn.TabIndex = 9;
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 636);
            this.Controls.Add(this.dgvCheckIn);
            this.Controls.Add(this.btnEjecutarCheckIn);
            this.Controls.Add(this.chkCheckIn);
            this.Controls.Add(this.cmbIdReservación);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdHuesped);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNombreHuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCheck";
            this.Text = "Check In/Out";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombreHuesped;
        private System.Windows.Forms.ComboBox cmbIdHuesped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdReservación;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCheckIn;
        private System.Windows.Forms.Button btnEjecutarCheckIn;
        private System.Windows.Forms.DataGridView dgvCheckIn;
    }
}