namespace PruebaWinForms
{
    partial class Menu
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
            buttonAltaCliente = new Button();
            buttonBuscar = new Button();
            buttonAltaProducto = new Button();
            buttonGenerarPedido = new Button();
            SuspendLayout();
            // 
            // buttonAltaCliente
            // 
            buttonAltaCliente.Location = new Point(596, 45);
            buttonAltaCliente.Name = "buttonAltaCliente";
            buttonAltaCliente.Size = new Size(192, 29);
            buttonAltaCliente.TabIndex = 0;
            buttonAltaCliente.Text = "Añadir Cliente";
            buttonAltaCliente.UseVisualStyleBackColor = true;
            buttonAltaCliente.Click += buttonAltaCliente_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(598, 90);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(190, 29);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar Cliente";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonAltaProducto
            // 
            buttonAltaProducto.Location = new Point(596, 140);
            buttonAltaProducto.Name = "buttonAltaProducto";
            buttonAltaProducto.Size = new Size(192, 30);
            buttonAltaProducto.TabIndex = 2;
            buttonAltaProducto.Text = "Añadir Producto";
            buttonAltaProducto.UseVisualStyleBackColor = true;
            buttonAltaProducto.Click += buttonAltaProducto_Click;
            // 
            // buttonGenerarPedido
            // 
            buttonGenerarPedido.Location = new Point(318, 45);
            buttonGenerarPedido.Name = "buttonGenerarPedido";
            buttonGenerarPedido.Size = new Size(239, 63);
            buttonGenerarPedido.TabIndex = 3;
            buttonGenerarPedido.Text = "Generar Pedido Nuevo";
            buttonGenerarPedido.UseVisualStyleBackColor = true;
            buttonGenerarPedido.Click += buttonGenerarPedido_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGenerarPedido);
            Controls.Add(buttonAltaProducto);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonAltaCliente);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAltaCliente;
        private Button buttonBuscar;
        private Button buttonAltaProducto;
        private Button buttonGenerarPedido;
    }
}