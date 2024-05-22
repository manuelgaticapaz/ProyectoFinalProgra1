namespace ProyectoFinal
{
    partial class frmHabitacionCatalogo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.txtIDHabitacion = new System.Windows.Forms.TextBox();
            this.txtNivelHabitacion = new System.Windows.Forms.TextBox();
            this.txtEntradaHabitacion = new System.Windows.Forms.TextBox();
            this.txtTipoHabitacion = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.dgvCatalogoHabitacion = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cmbIDTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.chbDisponibilidad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Entrada Habitación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nivel Habitación:";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(13, 91);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(73, 13);
            this.lblDisponibilidad.TabIndex = 4;
            this.lblDisponibilidad.Text = "Disponibiidad:";
            // 
            // txtIDHabitacion
            // 
            this.txtIDHabitacion.Location = new System.Drawing.Point(102, 10);
            this.txtIDHabitacion.Name = "txtIDHabitacion";
            this.txtIDHabitacion.Size = new System.Drawing.Size(173, 20);
            this.txtIDHabitacion.TabIndex = 5;
            // 
            // txtNivelHabitacion
            // 
            this.txtNivelHabitacion.Location = new System.Drawing.Point(102, 47);
            this.txtNivelHabitacion.Name = "txtNivelHabitacion";
            this.txtNivelHabitacion.Size = new System.Drawing.Size(173, 20);
            this.txtNivelHabitacion.TabIndex = 6;
            // 
            // txtEntradaHabitacion
            // 
            this.txtEntradaHabitacion.Location = new System.Drawing.Point(389, 47);
            this.txtEntradaHabitacion.Name = "txtEntradaHabitacion";
            this.txtEntradaHabitacion.Size = new System.Drawing.Size(173, 20);
            this.txtEntradaHabitacion.TabIndex = 7;
            // 
            // txtTipoHabitacion
            // 
            this.txtTipoHabitacion.Location = new System.Drawing.Point(389, 10);
            this.txtTipoHabitacion.Name = "txtTipoHabitacion";
            this.txtTipoHabitacion.Size = new System.Drawing.Size(173, 20);
            this.txtTipoHabitacion.TabIndex = 8;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(102, 88);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(173, 20);
            this.txtDisponibilidad.TabIndex = 9;
            // 
            // dgvCatalogoHabitacion
            // 
            this.dgvCatalogoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoHabitacion.Location = new System.Drawing.Point(16, 180);
            this.dgvCatalogoHabitacion.Name = "dgvCatalogoHabitacion";
            this.dgvCatalogoHabitacion.Size = new System.Drawing.Size(546, 197);
            this.dgvCatalogoHabitacion.TabIndex = 10;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 134);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(16, 134);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(56, 19);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(389, 10);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(173, 21);
            this.cmbTipoHabitacion.TabIndex = 17;
            // 
            // cmbIDTipoHabitacion
            // 
            this.cmbIDTipoHabitacion.FormattingEnabled = true;
            this.cmbIDTipoHabitacion.Location = new System.Drawing.Point(389, 87);
            this.cmbIDTipoHabitacion.Name = "cmbIDTipoHabitacion";
            this.cmbIDTipoHabitacion.Size = new System.Drawing.Size(173, 21);
            this.cmbIDTipoHabitacion.TabIndex = 18;
            // 
            // chbDisponibilidad
            // 
            this.chbDisponibilidad.AutoSize = true;
            this.chbDisponibilidad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbDisponibilidad.Location = new System.Drawing.Point(12, 89);
            this.chbDisponibilidad.Name = "chbDisponibilidad";
            this.chbDisponibilidad.Size = new System.Drawing.Size(94, 17);
            this.chbDisponibilidad.TabIndex = 19;
            this.chbDisponibilidad.Text = "Disponibilidad:";
            this.chbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // frmHabitacionCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.chbDisponibilidad);
            this.Controls.Add(this.cmbIDTipoHabitacion);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.dgvCatalogoHabitacion);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.txtTipoHabitacion);
            this.Controls.Add(this.txtEntradaHabitacion);
            this.Controls.Add(this.txtNivelHabitacion);
            this.Controls.Add(this.txtIDHabitacion);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmHabitacionCatalogo";
            this.Text = "Catalogo Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.TextBox txtIDHabitacion;
        private System.Windows.Forms.TextBox txtNivelHabitacion;
        private System.Windows.Forms.TextBox txtEntradaHabitacion;
        private System.Windows.Forms.TextBox txtTipoHabitacion;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.DataGridView dgvCatalogoHabitacion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.ComboBox cmbIDTipoHabitacion;
        private System.Windows.Forms.CheckBox chbDisponibilidad;
    }
}