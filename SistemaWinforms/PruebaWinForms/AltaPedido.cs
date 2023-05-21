using BibliotecaCLasesWin;
using BibliotecaCLasesWin.Entidades;
using Microsoft.EntityFrameworkCore;
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
    public partial class AltaPedido : Form
    {

        private ApplicationDbContext? dbContext;
        public AltaPedido()
        {
            InitializeComponent();
            productosSeleccionados = new List<Producto>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();

            this.dbContext.Database.EnsureCreated();

            this.dbContext.Pedidos.Load();
            this.dbContext.Productos.Load();
            this.dbContext.PedidosProductos.Load();

            //declaro la variable nombres y le asigno una lista de nombres de los productos cargados 
            var nombres = dbContext.Productos.Select(x => x.ProductoNombre).ToList();
            comboBoxAgregarProductos.DataSource = nombres;

            //carga la 
            CargarDataGriViewPedidosProductos();


        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private int ObtenerClienteSeleccionado(String entradaText)

        {
            //este metodo devuelve el CLiente.ClienteId a traves de su CLiente.DNI
            string dniCliente = entradaText;

            Cliente clienteSeleccionado = dbContext.Clientes.FirstOrDefault(c => c.DNI == dniCliente);

            int clienteId = clienteSeleccionado.ClienteId;
            if (clienteSeleccionado != null)
            {
                return clienteId;
            }
            else { return 0; }
        }

        //esta lista es la que contiene los productos que se van agregando para realizar el pedido
        public List<Producto> productosSeleccionados;


        private void CargarDataGriViewPedidosProductos()
        {

            // estoy creando una lista que contiene pedidos, con todas las propiedades incluyendo una lista con obj pedidoProducto que contienen el producto que fue 
            // agregado a al pepido, ademas incluyo clientes para luego obtener su nombre
            List<Pedido> pedidosConProductos = dbContext.Pedidos.Include(p => p.PedidosProductos).ThenInclude(pp => pp.Producto).Include(p => p.Cliente).ToList();
            //declaro lista de pedidos/////tomo el dbcontext, tomo pedidos de el, incluyo la coleccion de pedidos,incluyo los objetos clientes de esos pedidos para obtener su nombre


            var datosDataGridView = pedidosConProductos.SelectMany(p => p.PedidosProductos.Select(pp => new
            {
                PedidoId = p.PedidoId,
                CodPedido = p.CodPedido,
                NombreProducto = pp.Producto.ProductoNombre,
                Cantidad = pp.Cantidad,
                Cliente = p.Cliente.ClienteNombre,
            })).ToList();


            // Asigna los datos al DataGridView
            dataGridView2.DataSource = datosDataGridView;
            this.dataGridView2.Refresh();
        }




        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // falta generar bucle para evitar que se colquen datos erroneos

            //el boton finaliar pedido crea un objeto de tipo pedido y actualiza el datagridview

            Pedido pedido = new Pedido
            {
                Fecha = DateTime.Now,

                Cliente = this.dbContext!.Clientes.Find(ObtenerClienteSeleccionado(textBoxDNICliente.Text)),
                Productos = productosSeleccionados,
                PedidosProductos = new HashSet<PedidoProducto>(),

            };
            // con este bulce asigno una cantidad de cada producto almacenado en la entidad PedidoProducto
            foreach (var producto in productosSeleccionados)
            {
                PedidoProducto pedidoProducto = new PedidoProducto
                {
                    Producto = producto,
                    Cantidad = Convert.ToInt16(textBoxCantidad.Text)
                };

                pedido.PedidosProductos.Add(pedidoProducto);
            }


            dbContext.Pedidos.Add(pedido);
            dbContext.Pedidos.Load();
            dbContext.Productos.Load();
            dbContext.PedidosProductos.Load();
            dbContext.SaveChanges();



            this.dataGridView2.Refresh();
            CargarDataGriViewPedidosProductos();

            MessageBox.Show("El monto total del pedido realizado es: " + pedido.ObtenerTotalPedido() + " $ pesos");

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            productosSeleccionados.Add(dbContext.Productos.Find(Producto.ObtenerProductoSeleccionado(comboBoxAgregarProductos.Text,dbContext)));//Es mejor utulizar el metodo desde la clase o declararlo en el form?
        }


        /*
private void AltaPedido_Load(object sender, EventArgs e)
{

}
*/
    }
}
