using BibliotecaCLasesWin;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWinForms
{
    public partial class ModificarCliente : Form
    {
        private ApplicationDbContext? dbContext;
        public ModificarCliente()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();

            this.dbContext.Database.EnsureCreated();


            this.dbContext.Clientes.Load();
        }
        //carga
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
        //esto esta raro, servia para poder enviar datos de un metodo a otro
        /// ///////////////////////////
        private string buscador= null!;
        ///////////////////////////////
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniCliente = Interaction.InputBox("Ingrese el DNI del cliente que quiere eliminiar: ", "Modificar Cliente", "", 100);
            var registro = dbContext!.Clientes.FirstOrDefault(c => c.DNI == dniCliente);
            buscador = dniCliente;

            if (registro != null)
            {
                MtextBoxDNI.Text = registro.DNI;    
                MtextBoxNombre.Text = registro.ClienteNombre;
                MtextBoxApellido.Text = registro.ClienteApellido;
                MtextBoxTelefono.Text = registro.Telefono;
            }
            else
            {
                MessageBox.Show("El cliente no existe, ingrese un DNI valido");
                MtextBoxDNI.Clear();
                
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var registro = dbContext!.Clientes.FirstOrDefault(c => c.DNI == buscador);


                registro!.DNI = MtextBoxDNI.Text;
                registro.ClienteNombre = MtextBoxNombre.Text;
                registro.ClienteApellido = MtextBoxApellido.Text;
                registro.Telefono = MtextBoxTelefono.Text;
                

            dbContext.SaveChanges();
            MessageBox.Show("El cliente ha sido modificado con existo");
        }
    }

}

