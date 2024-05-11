namespace ProyectoFinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llegadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.huespedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEditarHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tiposDeHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promociónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem1,
            this.toolStripSeparator5,
            this.checkToolStripMenuItem,
            this.toolStripSeparator6,
            this.huespedToolStripMenuItem1});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // reservacionesToolStripMenuItem1
            // 
            this.reservacionesToolStripMenuItem1.Name = "reservacionesToolStripMenuItem1";
            this.reservacionesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.reservacionesToolStripMenuItem1.Text = "Reservaciones";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llegadaToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // llegadaToolStripMenuItem
            // 
            this.llegadaToolStripMenuItem.Name = "llegadaToolStripMenuItem";
            this.llegadaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.llegadaToolStripMenuItem.Text = "Llegada";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // huespedToolStripMenuItem1
            // 
            this.huespedToolStripMenuItem1.Name = "huespedToolStripMenuItem1";
            this.huespedToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.huespedToolStripMenuItem1.Text = "Huesped";
            this.huespedToolStripMenuItem1.Click += new System.EventHandler(this.huespedToolStripMenuItem1_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEditarHabitaciónToolStripMenuItem,
            this.todasLasHabitacionesToolStripMenuItem,
            this.toolStripSeparator4,
            this.disponibilidadToolStripMenuItem,
            this.toolStripSeparator3,
            this.tiposDeHabitaciónToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // agregarEditarHabitaciónToolStripMenuItem
            // 
            this.agregarEditarHabitaciónToolStripMenuItem.Name = "agregarEditarHabitaciónToolStripMenuItem";
            this.agregarEditarHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.agregarEditarHabitaciónToolStripMenuItem.Text = "Agregar/Editar Habitación";
            // 
            // todasLasHabitacionesToolStripMenuItem
            // 
            this.todasLasHabitacionesToolStripMenuItem.Name = "todasLasHabitacionesToolStripMenuItem";
            this.todasLasHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.todasLasHabitacionesToolStripMenuItem.Text = "Todas las Habitaciones";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarToolStripMenuItem,
            this.deshabilitarToolStripMenuItem});
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar ";
            // 
            // deshabilitarToolStripMenuItem
            // 
            this.deshabilitarToolStripMenuItem.Name = "deshabilitarToolStripMenuItem";
            this.deshabilitarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deshabilitarToolStripMenuItem.Text = "Deshabilitar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // tiposDeHabitaciónToolStripMenuItem
            // 
            this.tiposDeHabitaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEditarToolStripMenuItem,
            this.verTodoToolStripMenuItem});
            this.tiposDeHabitaciónToolStripMenuItem.Name = "tiposDeHabitaciónToolStripMenuItem";
            this.tiposDeHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tiposDeHabitaciónToolStripMenuItem.Text = "Tipos de Habitación";
            // 
            // agregarEditarToolStripMenuItem
            // 
            this.agregarEditarToolStripMenuItem.Name = "agregarEditarToolStripMenuItem";
            this.agregarEditarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.agregarEditarToolStripMenuItem.Text = "Agregar/Editar";
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.verTodoToolStripMenuItem.Text = "Ver Todo";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEditarToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cargarToolStripMenuItem,
            this.promociónToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // nuevoEditarToolStripMenuItem
            // 
            this.nuevoEditarToolStripMenuItem.Name = "nuevoEditarToolStripMenuItem";
            this.nuevoEditarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nuevoEditarToolStripMenuItem.Text = "Nuevo/Editar";
            this.nuevoEditarToolStripMenuItem.Click += new System.EventHandler(this.nuevoEditarToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // promociónToolStripMenuItem
            // 
            this.promociónToolStripMenuItem.Name = "promociónToolStripMenuItem";
            this.promociónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.promociónToolStripMenuItem.Text = "Promoción";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Hotel App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHabitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llegadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem huespedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarEditarHabitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promociónToolStripMenuItem;
    }
}

