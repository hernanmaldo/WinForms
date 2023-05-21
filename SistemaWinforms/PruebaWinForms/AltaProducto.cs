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
    public partial class AltaProducto : Form
    {


        private ApplicationDbContext? dbContext;

        private static AltaProducto? Instancia;

        public static AltaProducto getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new AltaProducto();


                return Instancia;
            }
            else return Instancia;

        }

        private AltaProducto()
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


            this.dbContext.Productos.Load();
            this.productoBindingSource1.DataSource = this.dbContext.Productos.Local.ToBindingList();
            ;//carga

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }




        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxCantidad.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();

        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {


            string productoNombre = Interaction.InputBox("Ingrese el Nombre del Producto que quiere eliminiar: ", "Eliminar Producto", "0", 100);

            //Error de interfaz, el datagridView no se actualiza al momento de eliminar

            this.dbContext!.Productos.Where(b => b.ProductoNombre == productoNombre).ExecuteDelete();
            this.dbContext.Productos.Load();
            ;
            this.dbContext.SaveChanges();

            MessageBox.Show("El producto a sido eliminado con exito");

        }

       
        

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string descripcion = textBoxDescripcion.Text;
            double precio = Convert.ToDouble(textBoxPrecio.Text);
            int cantidad = Convert.ToInt16(textBoxCantidad.Text);

            Producto producto = new Producto
            {
                Cantidad = cantidad,
                Descripcion = descripcion,
                Precio = precio,
                ProductoNombre = nombre
            };
            this.dbContext!.Productos.Add(producto);
            this.dbContext.Productos.Load();
            this.dbContext.SaveChanges();

        }
    }
}
