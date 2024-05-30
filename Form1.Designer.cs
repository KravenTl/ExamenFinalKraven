namespace ExamenFinalProgramaciónIKraven
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelFechadeIngreso = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.checkBoxDisponibles = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFechadeIngreso = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 52);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(135, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del Producto";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(12, 84);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(124, 16);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca del Producto";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(13, 156);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(61, 16);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelFechadeIngreso
            // 
            this.labelFechadeIngreso.AutoSize = true;
            this.labelFechadeIngreso.Location = new System.Drawing.Point(13, 121);
            this.labelFechadeIngreso.Name = "labelFechadeIngreso";
            this.labelFechadeIngreso.Size = new System.Drawing.Size(112, 16);
            this.labelFechadeIngreso.TabIndex = 4;
            this.labelFechadeIngreso.Text = "Fecha de Ingreso";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(13, 194);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio";
            // 
            // checkBoxDisponibles
            // 
            this.checkBoxDisponibles.AutoSize = true;
            this.checkBoxDisponibles.Location = new System.Drawing.Point(16, 222);
            this.checkBoxDisponibles.Name = "checkBoxDisponibles";
            this.checkBoxDisponibles.Size = new System.Drawing.Size(101, 20);
            this.checkBoxDisponibles.TabIndex = 6;
            this.checkBoxDisponibles.Text = "Disponibles";
            this.checkBoxDisponibles.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechadeIngreso
            // 
            this.dateTimePickerFechadeIngreso.Location = new System.Drawing.Point(171, 115);
            this.dateTimePickerFechadeIngreso.Name = "dateTimePickerFechadeIngreso";
            this.dateTimePickerFechadeIngreso.Size = new System.Drawing.Size(250, 22);
            this.dateTimePickerFechadeIngreso.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(171, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(250, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(171, 49);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(250, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(171, 81);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(250, 22);
            this.textBoxMarca.TabIndex = 10;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(171, 156);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(250, 22);
            this.textBoxCantidad.TabIndex = 11;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(171, 194);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(250, 22);
            this.textBoxPrecio.TabIndex = 12;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(455, 79);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(271, 24);
            this.comboBoxMarca.TabIndex = 14;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(455, 49);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(271, 24);
            this.comboBoxNombre.TabIndex = 15;
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.buttonEliminar);
            this.groupBoxCRUD.Controls.Add(this.buttonActualizar);
            this.groupBoxCRUD.Controls.Add(this.buttonInsertar);
            this.groupBoxCRUD.Controls.Add(this.buttonPrueba);
            this.groupBoxCRUD.Controls.Add(this.buttonCargar);
            this.groupBoxCRUD.Controls.Add(this.buttonBuscar);
            this.groupBoxCRUD.Location = new System.Drawing.Point(455, 222);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(533, 90);
            this.groupBoxCRUD.TabIndex = 17;
            this.groupBoxCRUD.TabStop = false;
            this.groupBoxCRUD.Text = "CRUD";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(421, 39);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 31);
            this.buttonEliminar.TabIndex = 21;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(330, 39);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(85, 31);
            this.buttonActualizar.TabIndex = 21;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(249, 39);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 31);
            this.buttonInsertar.TabIndex = 20;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(6, 39);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(75, 31);
            this.buttonPrueba.TabIndex = 19;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(168, 39);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 31);
            this.buttonCargar.TabIndex = 18;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(87, 39);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 31);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 190);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 536);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dateTimePickerFechadeIngreso);
            this.Controls.Add(this.checkBoxDisponibles);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelFechadeIngreso);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelFechadeIngreso;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.CheckBox checkBoxDisponibles;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechadeIngreso;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

