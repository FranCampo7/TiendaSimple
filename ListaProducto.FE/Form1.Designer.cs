namespace ListaProducto.FE
{
    partial class frmProductos
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnMed = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnMed = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPRactual = new System.Windows.Forms.Label();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.lbltablatexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(145, 311);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(225, 311);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 2;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(317, 59);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(145, 61);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(166, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btBorrar
            // 
            this.btBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(225, 340);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(18, 171);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(18, 208);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 19);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblUnMed
            // 
            this.lblUnMed.AutoSize = true;
            this.lblUnMed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnMed.Location = new System.Drawing.Point(18, 247);
            this.lblUnMed.Name = "lblUnMed";
            this.lblUnMed.Size = new System.Drawing.Size(117, 19);
            this.lblUnMed.TabIndex = 9;
            this.lblUnMed.Text = "Un. De Medida:";
            this.lblUnMed.Click += new System.EventHandler(this.lblUnMed_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(18, 285);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(145, 170);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 20);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(145, 207);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(155, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // txtUnMed
            // 
            this.txtUnMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnMed.Location = new System.Drawing.Point(145, 246);
            this.txtUnMed.Name = "txtUnMed";
            this.txtUnMed.Size = new System.Drawing.Size(155, 20);
            this.txtUnMed.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(145, 285);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(155, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // lblPRactual
            // 
            this.lblPRactual.AutoSize = true;
            this.lblPRactual.Location = new System.Drawing.Point(463, 55);
            this.lblPRactual.Name = "lblPRactual";
            this.lblPRactual.Size = new System.Drawing.Size(0, 13);
            this.lblPRactual.TabIndex = 16;
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVProductos.Location = new System.Drawing.Point(327, 122);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.Size = new System.Drawing.Size(461, 304);
            this.DGVProductos.TabIndex = 19;
            this.DGVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellContentClick);
            this.DGVProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellEnter);
            // 
            // lbltablatexto
            // 
            this.lbltablatexto.AutoSize = true;
            this.lbltablatexto.BackColor = System.Drawing.Color.White;
            this.lbltablatexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltablatexto.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltablatexto.Location = new System.Drawing.Point(327, 95);
            this.lbltablatexto.Name = "lbltablatexto";
            this.lbltablatexto.Size = new System.Drawing.Size(174, 24);
            this.lbltablatexto.TabIndex = 20;
            this.lbltablatexto.Text = "Tabla De Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo a buscar:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ListaProducto.FE.Properties.Resources.fondo_programa;
            this.ClientSize = new System.Drawing.Size(1015, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltablatexto);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.lblPRactual);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtUnMed);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUnMed);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btAgregar);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnMed;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUnMed;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPRactual;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Label lbltablatexto;
        private System.Windows.Forms.Label label1;
    }
}

