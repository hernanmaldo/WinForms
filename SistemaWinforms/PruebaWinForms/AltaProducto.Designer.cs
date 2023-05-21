using BibliotecaCLasesWin.Entidades;

namespace PruebaWinForms
{
    partial class AltaProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonGuardar = new Button();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxPrecio = new TextBox();
            labelDescripcion = new Label();
            labelCantidad = new Label();
            labelPrecio = new Label();
            buttonLimpiar = new Button();
            clienteBindingSource2 = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            buttonEliminar = new Button();
            dataGridView1 = new DataGridView();
            ProductoId = new DataGridViewTextBoxColumn();
            productoNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource1 = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(495, 200);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(44, 37);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(145, 37);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(176, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(384, 73);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(316, 90);
            textBoxDescripcion.TabIndex = 4;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(145, 112);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(176, 27);
            textBoxCantidad.TabIndex = 5;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(145, 188);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(176, 27);
            textBoxPrecio.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(384, 37);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 20);
            labelDescripcion.TabIndex = 7;
            labelDescripcion.Text = "Descripcion";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(44, 115);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(88, 20);
            labelCantidad.TabIndex = 8;
            labelCantidad.Text = "Stock inicial";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(44, 188);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 20);
            labelPrecio.TabIndex = 9;
            labelPrecio.Text = "Precio";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.Control;
            buttonLimpiar.Location = new Point(384, 200);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 10;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // clienteBindingSource2
            // 
            clienteBindingSource2.DataSource = typeof(Cliente);
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Cliente);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(606, 200);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 12;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductoId, productoNombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productoBindingSource1;
            dataGridView1.Location = new Point(24, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(676, 188);
            dataGridView1.TabIndex = 14;
            // 
            // ProductoId
            // 
            ProductoId.DataPropertyName = "ProductoId";
            ProductoId.HeaderText = "ProductoId";
            ProductoId.MinimumWidth = 6;
            ProductoId.Name = "ProductoId";
            ProductoId.Width = 125;
            // 
            // productoNombreDataGridViewTextBoxColumn
            // 
            productoNombreDataGridViewTextBoxColumn.DataPropertyName = "ProductoNombre";
            productoNombreDataGridViewTextBoxColumn.HeaderText = "ProductoNombre";
            productoNombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            productoNombreDataGridViewTextBoxColumn.Name = "productoNombreDataGridViewTextBoxColumn";
            productoNombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoBindingSource1
            // 
            productoBindingSource1.DataSource = typeof(Producto);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonLimpiar);
            Controls.Add(labelPrecio);
            Controls.Add(labelCantidad);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(buttonGuardar);
            Name = "AltaProducto";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGuardar;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecio;
        private Label labelDescripcion;
        private Label labelCantidad;
        private Label labelPrecio;
        private Button buttonLimpiar;
        private DataGridViewTextBoxColumn clienteNameDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private BindingSource clienteBindingSource1;
        private BindingSource clienteBindingSource2;
        private Button buttonEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn producosIdDataGridViewTextBoxColumn;
        private BindingSource productoBindingSource;
        private BindingSource productoBindingSource1;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn productoNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}