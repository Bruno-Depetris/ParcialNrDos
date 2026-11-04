namespace ParcialNrDos {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se están usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.grpPropiedad = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.lblIdEliminar = new System.Windows.Forms.Label();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.grpPropiedad.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPropiedad
            // 
            this.grpPropiedad.Controls.Add(this.lblNombre);
            this.grpPropiedad.Controls.Add(this.txtNombre);
            this.grpPropiedad.Controls.Add(this.lblDireccion);
            this.grpPropiedad.Controls.Add(this.txtDireccion);
            this.grpPropiedad.Controls.Add(this.lblBarrio);
            this.grpPropiedad.Controls.Add(this.cmbBarrio);
            this.grpPropiedad.Controls.Add(this.lblPrecio);
            this.grpPropiedad.Controls.Add(this.txtPrecio);
            this.grpPropiedad.Controls.Add(this.btnGuardar);
            this.grpPropiedad.Location = new System.Drawing.Point(12, 12);
            this.grpPropiedad.Name = "grpPropiedad";
            this.grpPropiedad.Size = new System.Drawing.Size(420, 165);
            this.grpPropiedad.TabIndex = 0;
            this.grpPropiedad.TabStop = false;
            this.grpPropiedad.Text = "Registrar propiedad";
            this.grpPropiedad.Enter += new System.EventHandler(this.grpPropiedad_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 30);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 65);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 62);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(290, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(15, 97);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 4;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(110, 94);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(290, 21);
            this.cmbBarrio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 129);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(110, 126);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(270, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.lblIdEliminar);
            this.grpEliminar.Controls.Add(this.txtIdEliminar);
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Location = new System.Drawing.Point(450, 12);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(267, 110);
            this.grpEliminar.TabIndex = 1;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar propiedad";
            // 
            // lblIdEliminar
            // 
            this.lblIdEliminar.AutoSize = true;
            this.lblIdEliminar.Location = new System.Drawing.Point(15, 33);
            this.lblIdEliminar.Name = "lblIdEliminar";
            this.lblIdEliminar.Size = new System.Drawing.Size(84, 13);
            this.lblIdEliminar.TabIndex = 0;
            this.lblIdEliminar.Text = "Id de propiedad:";
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(110, 30);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(150, 20);
            this.txtIdEliminar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(120, 65);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(12, 180);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(66, 13);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Propiedades";
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.AllowUserToAddRows = false;
            this.dgvPropiedades.AllowUserToDeleteRows = false;
            this.dgvPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Location = new System.Drawing.Point(15, 196);
            this.dgvPropiedades.MultiSelect = false;
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.ReadOnly = true;
            this.dgvPropiedades.RowHeadersVisible = false;
            this.dgvPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropiedades.Size = new System.Drawing.Size(705, 330);
            this.dgvPropiedades.TabIndex = 3;
            this.dgvPropiedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropiedades_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.grpPropiedad);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvPropiedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(900, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Inmobiliaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPropiedad.ResumeLayout(false);
            this.grpPropiedad.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPropiedad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Label lblIdEliminar;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvPropiedades;
    }
}