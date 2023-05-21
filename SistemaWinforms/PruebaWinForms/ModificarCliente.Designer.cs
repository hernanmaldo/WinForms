namespace PruebaWinForms
{
    partial class ModificarCliente
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
            MtextBoxDNI = new TextBox();
            MtextBoxTelefono = new TextBox();
            MtextBoxApellido = new TextBox();
            MtextBoxNombre = new TextBox();
            MLabelDNI = new Label();
            MlabelTelefono = new Label();
            MlabelApellido = new Label();
            MlabelNombre = new Label();
            buttonBuscar = new Button();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // MtextBoxDNI
            // 
            MtextBoxDNI.Location = new Point(97, 38);
            MtextBoxDNI.Name = "MtextBoxDNI";
            MtextBoxDNI.Size = new Size(181, 27);
            MtextBoxDNI.TabIndex = 0;
            // 
            // MtextBoxTelefono
            // 
            MtextBoxTelefono.Location = new Point(97, 200);
            MtextBoxTelefono.Name = "MtextBoxTelefono";
            MtextBoxTelefono.Size = new Size(181, 27);
            MtextBoxTelefono.TabIndex = 2;
            // 
            // MtextBoxApellido
            // 
            MtextBoxApellido.Location = new Point(97, 149);
            MtextBoxApellido.Name = "MtextBoxApellido";
            MtextBoxApellido.Size = new Size(181, 27);
            MtextBoxApellido.TabIndex = 3;
            // 
            // MtextBoxNombre
            // 
            MtextBoxNombre.Location = new Point(97, 99);
            MtextBoxNombre.Name = "MtextBoxNombre";
            MtextBoxNombre.Size = new Size(181, 27);
            MtextBoxNombre.TabIndex = 4;
            // 
            // MLabelDNI
            // 
            MLabelDNI.AutoSize = true;
            MLabelDNI.Location = new Point(20, 41);
            MLabelDNI.Name = "MLabelDNI";
            MLabelDNI.Size = new Size(35, 20);
            MLabelDNI.TabIndex = 5;
            MLabelDNI.Text = "DNI";
            // 
            // MlabelTelefono
            // 
            MlabelTelefono.AutoSize = true;
            MlabelTelefono.Location = new Point(20, 207);
            MlabelTelefono.Name = "MlabelTelefono";
            MlabelTelefono.Size = new Size(67, 20);
            MlabelTelefono.TabIndex = 6;
            MlabelTelefono.Text = "Telefono";
            // 
            // MlabelApellido
            // 
            MlabelApellido.AutoSize = true;
            MlabelApellido.Location = new Point(20, 152);
            MlabelApellido.Name = "MlabelApellido";
            MlabelApellido.Size = new Size(66, 20);
            MlabelApellido.TabIndex = 7;
            MlabelApellido.Text = "Apellido";
            // 
            // MlabelNombre
            // 
            MlabelNombre.AutoSize = true;
            MlabelNombre.Location = new Point(20, 102);
            MlabelNombre.Name = "MlabelNombre";
            MlabelNombre.Size = new Size(64, 20);
            MlabelNombre.TabIndex = 8;
            MlabelNombre.Text = "Nombre";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(320, 36);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(320, 97);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 272);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonBuscar);
            Controls.Add(MlabelNombre);
            Controls.Add(MlabelApellido);
            Controls.Add(MlabelTelefono);
            Controls.Add(MLabelDNI);
            Controls.Add(MtextBoxNombre);
            Controls.Add(MtextBoxApellido);
            Controls.Add(MtextBoxTelefono);
            Controls.Add(MtextBoxDNI);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MtextBoxDNI;
        private TextBox MtextBoxTelefono;
        private TextBox MtextBoxApellido;
        private TextBox MtextBoxNombre;
        private Label MLabelDNI;
        private Label MlabelTelefono;
        private Label MlabelApellido;
        private Label MlabelNombre;
        private Button buttonBuscar;
        private Button buttonGuardar;
    }
}