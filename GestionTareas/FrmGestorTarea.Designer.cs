namespace GestionTareas
{
    partial class FrmGestorTarea
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombreTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.BtnEliminarTarea = new System.Windows.Forms.Button();
            this.BtnAgregaTarea = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarTareaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.TxtDescripcion);
            this.groupBox1.Controls.Add(this.TxtNombreTarea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Tarea";
            // 
            // DtpFechaVencimiento
            // 
            this.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimiento.Location = new System.Drawing.Point(186, 178);
            this.DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            this.DtpFechaVencimiento.Size = new System.Drawing.Size(172, 22);
            this.DtpFechaVencimiento.TabIndex = 5;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(186, 93);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescripcion.Size = new System.Drawing.Size(377, 75);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // TxtNombreTarea
            // 
            this.TxtNombreTarea.Location = new System.Drawing.Point(186, 51);
            this.TxtNombreTarea.Name = "TxtNombreTarea";
            this.TxtNombreTarea.Size = new System.Drawing.Size(377, 22);
            this.TxtNombreTarea.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Vencimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Tarea:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLimpiarCampos);
            this.panel1.Controls.Add(this.BtnEliminarTarea);
            this.panel1.Controls.Add(this.BtnAgregaTarea);
            this.panel1.Location = new System.Drawing.Point(25, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 94);
            this.panel1.TabIndex = 1;
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(355, 3);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(115, 83);
            this.BtnLimpiarCampos.TabIndex = 2;
            this.BtnLimpiarCampos.Text = "Limpiar Campos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = true;
            this.BtnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // BtnEliminarTarea
            // 
            this.BtnEliminarTarea.Location = new System.Drawing.Point(226, 3);
            this.BtnEliminarTarea.Name = "BtnEliminarTarea";
            this.BtnEliminarTarea.Size = new System.Drawing.Size(115, 83);
            this.BtnEliminarTarea.TabIndex = 1;
            this.BtnEliminarTarea.Text = "Eliminar Tarea";
            this.BtnEliminarTarea.UseVisualStyleBackColor = true;
            this.BtnEliminarTarea.Click += new System.EventHandler(this.BtnEliminarTarea_Click);
            // 
            // BtnAgregaTarea
            // 
            this.BtnAgregaTarea.Location = new System.Drawing.Point(97, 3);
            this.BtnAgregaTarea.Name = "BtnAgregaTarea";
            this.BtnAgregaTarea.Size = new System.Drawing.Size(115, 83);
            this.BtnAgregaTarea.TabIndex = 0;
            this.BtnAgregaTarea.Text = "Agregar Tarea";
            this.BtnAgregaTarea.UseVisualStyleBackColor = true;
            this.BtnAgregaTarea.Click += new System.EventHandler(this.BtnAgregaTarea_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 422);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 305);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Tareas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.descripcion,
            this.fechavenc});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre tarea";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // fechavenc
            // 
            this.fechavenc.HeaderText = "Fecha de Vencimiento";
            this.fechavenc.MinimumWidth = 6;
            this.fechavenc.Name = "fechavenc";
            this.fechavenc.ReadOnly = true;
            this.fechavenc.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarTareaToolStripMenuItem1,
            this.eliminarTareaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 52);
            // 
            // editarTareaToolStripMenuItem1
            // 
            this.editarTareaToolStripMenuItem1.Name = "editarTareaToolStripMenuItem1";
            this.editarTareaToolStripMenuItem1.Size = new System.Drawing.Size(171, 24);
            this.editarTareaToolStripMenuItem1.Text = "Editar Tarea";
            // 
            // eliminarTareaToolStripMenuItem
            // 
            this.eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            this.eliminarTareaToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resumen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(20, 88);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 60);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(628, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarTareaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarTareaToolStripMenuItem
            // 
            this.guardarTareaToolStripMenuItem.Name = "guardarTareaToolStripMenuItem";
            this.guardarTareaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.guardarTareaToolStripMenuItem.Text = "Guardar Tarea";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTareaToolStripMenuItem,
            this.editarTareaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarTareaToolStripMenuItem
            // 
            this.agregarTareaToolStripMenuItem.Name = "agregarTareaToolStripMenuItem";
            this.agregarTareaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.agregarTareaToolStripMenuItem.Text = "Agregar Tarea";
            // 
            // editarTareaToolStripMenuItem
            // 
            this.editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            this.editarTareaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.editarTareaToolStripMenuItem.Text = "Editar Tarea";
            // 
            // FrmGestorTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 724);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGestorTarea";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestión de Tareas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaVencimiento;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombreTarea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Button BtnEliminarTarea;
        private System.Windows.Forms.Button BtnAgregaTarea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavenc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarTareaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarTareaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarTareaToolStripMenuItem;
    }
}

