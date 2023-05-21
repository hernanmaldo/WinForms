using BibliotecaCLasesWin.Entidades;

namespace PruebaWinForms
{
    partial class AltaCliente
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
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxTelefono = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelTelefono = new Label();
            buttonLimpiar = new Button();
            dataGridView1 = new DataGridView();
            clienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ClienteNombre = new DataGridViewTextBoxColumn();
            ClienteApellido = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource2 = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(726, 188);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += elpepe;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(44, 37);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(35, 20);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "DNI";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(145, 37);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(176, 27);
            textBoxDNI.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(145, 84);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(176, 27);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(145, 131);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(176, 27);
            textBoxApellido.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(145, 188);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(176, 27);
            textBoxTelefono.TabIndex = 6;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(44, 87);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 7;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(44, 131);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 20);
            labelApellido.TabIndex = 8;
            labelApellido.Text = "Apellido";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(44, 188);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 9;
            labelTelefono.Text = "Telefono";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.Control;
            buttonLimpiar.Location = new Point(726, 153);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 10;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clienteIdDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, ClienteNombre, ClienteApellido, telefonoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource2;
            dataGridView1.Location = new Point(21, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(676, 188);
            dataGridView1.TabIndex = 11;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            dNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // ClienteNombre
            // 
            ClienteNombre.DataPropertyName = "ClienteNombre";
            ClienteNombre.HeaderText = "ClienteNombre";
            ClienteNombre.MinimumWidth = 6;
            ClienteNombre.Name = "ClienteNombre";
            ClienteNombre.ReadOnly = true;
            ClienteNombre.Width = 125;
            // 
            // ClienteApellido
            // 
            ClienteApellido.DataPropertyName = "ClienteApellido";
            ClienteApellido.HeaderText = "ClienteApellido";
            ClienteApellido.MinimumWidth = 6;
            ClienteApellido.Name = "ClienteApellido";
            ClienteApellido.ReadOnly = true;
            ClienteApellido.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
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
            buttonEliminar.Location = new Point(726, 106);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(94, 29);
            buttonEliminar.TabIndex = 12;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(727, 276);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(94, 29);
            buttonActualizar.TabIndex = 13;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(buttonLimpiar);
            Controls.Add(labelTelefono);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Controls.Add(labelDNI);
            Controls.Add(buttonGuardar);
            Name = "AltaCliente";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGuardar;
        private Label labelDNI;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxTelefono;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelTelefono;
        private Button buttonLimpiar;
        private DataGridView dataGridView1;
       
        private BindingSource clienteBindingSource;
        private BindingSource clienteBindingSource1;
        private BindingSource clienteBindingSource2;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ClienteNombre;
        private DataGridViewTextBoxColumn ClienteApellido;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private Button buttonEliminar;
        private Button buttonActualizar;
    }
}