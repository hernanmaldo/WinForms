namespace PruebaWinForms
{
    partial class AltaPedido
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
            components = new System.ComponentModel.Container();
            textBoxDNICliente = new TextBox();
            labelDNICLiente = new Label();
            label2 = new Label();
            textBoxCantidad = new TextBox();
            button1 = new Button();
            buttonAgregarProducto = new Button();
            label1 = new Label();
            pedidoProductoBindingSource = new BindingSource(components);
            pedidoProductoBindingSource1 = new BindingSource(components);
            pedidoBindingSource = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            comboBoxAgregarProductos = new ComboBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pedidoProductoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidoProductoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBoxDNICliente
            // 
            textBoxDNICliente.Location = new Point(233, 61);
            textBoxDNICliente.Name = "textBoxDNICliente";
            textBoxDNICliente.Size = new Size(215, 27);
            textBoxDNICliente.TabIndex = 0;
            // 
            // labelDNICLiente
            // 
            labelDNICLiente.AutoSize = true;
            labelDNICLiente.Location = new Point(51, 68);
            labelDNICLiente.Name = "labelDNICLiente";
            labelDNICLiente.Size = new Size(176, 20);
            labelDNICLiente.TabIndex = 1;
            labelDNICLiente.Text = "Ingrese el DNI del cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 135);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "agregarProductos";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(233, 192);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(215, 27);
            textBoxCantidad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(489, 192);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 4;
            button1.Text = "Finalizar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonGuardar_Click;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Location = new Point(489, 126);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(191, 29);
            buttonAgregarProducto.TabIndex = 5;
            buttonAgregarProducto.Text = "Agregar Producto";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 192);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingresar Cantidad";
            // 
            // pedidoProductoBindingSource
            // 
            pedidoProductoBindingSource.DataSource = typeof(BibliotecaCLasesWin.Entidades.PedidoProducto);
            // 
            // pedidoProductoBindingSource1
            // 
            pedidoProductoBindingSource1.DataSource = typeof(BibliotecaCLasesWin.Entidades.PedidoProducto);
            // 
            // pedidoBindingSource
            // 
            pedidoBindingSource.DataSource = typeof(BibliotecaCLasesWin.Entidades.Pedido);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(BibliotecaCLasesWin.Entidades.Producto);
            // 
            // comboBoxAgregarProductos
            // 
            comboBoxAgregarProductos.FormattingEnabled = true;
            comboBoxAgregarProductos.Location = new Point(233, 126);
            comboBoxAgregarProductos.Name = "comboBoxAgregarProductos";
            comboBoxAgregarProductos.Size = new Size(215, 28);
            comboBoxAgregarProductos.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(33, 245);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(707, 241);
            dataGridView2.TabIndex = 10;
            // 
            // AltaPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 498);
            Controls.Add(dataGridView2);
            Controls.Add(comboBoxAgregarProductos);
            Controls.Add(label1);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(button1);
            Controls.Add(textBoxCantidad);
            Controls.Add(label2);
            Controls.Add(labelDNICLiente);
            Controls.Add(textBoxDNICliente);
            Name = "AltaPedido";
            Text = "AltaPedido";
            ((System.ComponentModel.ISupportInitialize)pedidoProductoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidoProductoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDNICliente;
        private Label labelDNICLiente;
        private Label label2;
        private TextBox textBoxCantidad;
        private Button button1;
        private Button buttonAgregarProducto;
        private Label label1;
        private BindingSource pedidoProductoBindingSource;
        private BindingSource pedidoProductoBindingSource1;
        private BindingSource pedidoBindingSource;
        private BindingSource productoBindingSource;
        private ComboBox comboBoxAgregarProductos;
        private DataGridView dataGridView2;
    }
}