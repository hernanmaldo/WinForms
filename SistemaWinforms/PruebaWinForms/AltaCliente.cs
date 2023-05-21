using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.ObjectiveC;
using System.Windows.Forms;
using BibliotecaCLasesWin;
using BibliotecaCLasesWin.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace PruebaWinForms
{
    public partial class AltaCliente : Form
    {
        public string algo = null!;

        private ApplicationDbContext? dbContext;

        private static AltaCliente? Instancia;

        public static AltaCliente getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new AltaCliente();


                return Instancia;
            }else return Instancia;

        }

        private AltaCliente()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
           // this.dbContext.Database.EnsureDeleted();

            this.dbContext.Database.EnsureCreated();


            this.dbContext.Clientes.Load();
            clienteBindingSource2.DataSource = dbContext.Clientes.Local.ToBindingList();//carga

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void elpepe(object sender, EventArgs e)
        {

            string DNI = textBoxDNI.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string telefono = textBoxTelefono.Text;


            //using (var context = new ApplicationDbContext())
            //{
            var cliente = new Cliente
            {
                DNI = DNI,
                ClienteNombre = nombre,
                ClienteApellido = apellido,
                Telefono = telefono,
                FechaNacimiento = DateTime.Now,

            };

            this.dbContext!.Clientes.Add(cliente);

            this.dbContext.Clientes.Load();
            this.dbContext.SaveChanges();

            // }//

            this.dataGridView1.Refresh();
            MessageBox.Show("Los datos se guardaron correctamente.");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            // exepcion si no se ingresa un dato
            int idcliente = Convert.ToInt16(Interaction.InputBox("Ingrese el ID del cliente que quiere eliminiar: ", "Eliminar Cliente", "0", 100));

            //Error de interfaz, el datagridView no se actualiza al momento de eliminar

            this.dbContext!.Clientes.Where(b => b.ClienteId == idcliente).ExecuteDelete();
            this.dbContext.Clientes.Load();
            this.clienteBindingSource2.DataSource = dbContext.Clientes.Local.ToBindingList();
            this.dbContext.SaveChanges();

            this.dataGridView1.Refresh();
         
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.dbContext!.Clientes.Load();
            this.clienteBindingSource2.DataSource = dbContext.Clientes.Local.ToBindingList();
            this.dbContext.SaveChanges();

            this.dataGridView1.Refresh();
        }
    }
}
