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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardarPropiedad = new System.Windows.Forms.Button();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.lblPropiedadVenta = new System.Windows.Forms.Label();
            this.cmbPropiedadDisponible = new System.Windows.Forms.ComboBox();
            this.lblComprador = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.grpPropiedad.SuspendLayout();
            this.grpVenta.SuspendLayout();
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
            this.grpPropiedad.Controls.Add(this.lblTipo);
            this.grpPropiedad.Controls.Add(this.cmbTipo);
            this.grpPropiedad.Controls.Add(this.lblPrecio);
            this.grpPropiedad.Controls.Add(this.txtPrecio);
            this.grpPropiedad.Controls.Add(this.btnGuardarPropiedad);
            this.grpPropiedad.Location = new System.Drawing.Point(12, 12);
            this.grpPropiedad.Name = "grpPropiedad";
            this.grpPropiedad.Size = new System.Drawing.Size(420, 235);
            this.grpPropiedad.TabIndex = 0;
            this.grpPropiedad.TabStop = false;
            this.grpPropiedad.Text = "Registrar propiedad";
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
            this.txtNombre.Location = new System.Drawing.Point(130, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 20);
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
            this.txtDireccion.Location = new System.Drawing.Point(130, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(270, 20);
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
            this.cmbBarrio.Location = new System.Drawing.Point(130, 94);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(270, 21);
            this.cmbBarrio.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 129);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(91, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo de inmueble:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(130, 126);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(270, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 161);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(89, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio publicado:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(130, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(270, 192);
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(130, 30);
            this.btnGuardarPropiedad.TabIndex = 10;
            this.btnGuardarPropiedad.Text = "Guardar propiedad";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            this.btnGuardarPropiedad.Click += new System.EventHandler(this.btnGuardarPropiedad_Click);
            // 
            // grpVenta
            // 
            this.grpVenta.Controls.Add(this.lblPropiedadVenta);
            this.grpVenta.Controls.Add(this.cmbPropiedadDisponible);
            this.grpVenta.Controls.Add(this.lblComprador);
            this.grpVenta.Controls.Add(this.txtComprador);
            this.grpVenta.Controls.Add(this.lblDni);
            this.grpVenta.Controls.Add(this.txtDni);
            this.grpVenta.Controls.Add(this.lblFechaVenta);
            this.grpVenta.Controls.Add(this.dtpFechaVenta);
            this.grpVenta.Controls.Add(this.lblPrecioFinal);
            this.grpVenta.Controls.Add(this.txtPrecioFinal);
            this.grpVenta.Controls.Add(this.btnRegistrarVenta);
            this.grpVenta.Location = new System.Drawing.Point(450, 12);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(420, 235);
            this.grpVenta.TabIndex = 1;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Registrar venta";
            // 
            // lblPropiedadVenta
            // 
            this.lblPropiedadVenta.AutoSize = true;
            this.lblPropiedadVenta.Location = new System.Drawing.Point(15, 33);
            this.lblPropiedadVenta.Name = "lblPropiedadVenta";
            this.lblPropiedadVenta.Size = new System.Drawing.Size(58, 13);
            this.lblPropiedadVenta.TabIndex = 0;
            this.lblPropiedadVenta.Text = "Propiedad:";
            // 
            // cmbPropiedadDisponible
            // 
            this.cmbPropiedadDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropiedadDisponible.FormattingEnabled = true;
            this.cmbPropiedadDisponible.Location = new System.Drawing.Point(130, 30);
            this.cmbPropiedadDisponible.Name = "cmbPropiedadDisponible";
            this.cmbPropiedadDisponible.Size = new System.Drawing.Size(270, 21);
            this.cmbPropiedadDisponible.TabIndex = 1;
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Location = new System.Drawing.Point(15, 65);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(61, 13);
            this.lblComprador.TabIndex = 2;
            this.lblComprador.Text = "Comprador:";
            // 
            // txtComprador
            // 
            this.txtComprador.Location = new System.Drawing.Point(130, 62);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(270, 20);
            this.txtComprador.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(15, 97);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(130, 94);
            this.txtDni.MaxLength = 20;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(150, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(15, 129);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(85, 13);
            this.lblFechaVenta.TabIndex = 6;
            this.lblFechaVenta.Text = "Fecha de venta:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(130, 126);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaVenta.TabIndex = 7;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(15, 161);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.lblPrecioFinal.TabIndex = 8;
            this.lblPrecioFinal.Text = "Precio final:";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(130, 158);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioFinal.TabIndex = 9;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(270, 192);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(130, 30);
            this.btnRegistrarVenta.TabIndex = 10;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(12, 258);
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
            this.dgvPropiedades.Location = new System.Drawing.Point(12, 276);
            this.dgvPropiedades.MultiSelect = false;
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.ReadOnly = true;
            this.dgvPropiedades.RowHeadersVisible = false;
            this.dgvPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropiedades.Size = new System.Drawing.Size(858, 300);
            this.dgvPropiedades.TabIndex = 3;
            this.dgvPropiedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropiedades_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.grpPropiedad);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvPropiedades);
            this.MinimumSize = new System.Drawing.Size(900, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Inmobiliaria";
            this.grpPropiedad.ResumeLayout(false);
            this.grpPropiedad.PerformLayout();
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
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
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardarPropiedad;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.Label lblPropiedadVenta;
        private System.Windows.Forms.ComboBox cmbPropiedadDisponible;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvPropiedades;
    }
}