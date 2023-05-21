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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Falta agregar un patron singleton para que solo se abra una ventana
        private void buttonAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente.getInstancia().Show();

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarCliente = new ModificarCliente();
            modificarCliente.Show();

        }

        private void buttonAltaProducto_Click(object sender, EventArgs e)
        {
            AltaProducto.getInstancia().Show();

        }



        private void buttonGenerarPedido_Click(object sender, EventArgs e)
        {
            AltaPedido altapedido = new AltaPedido();

            altapedido.Show();
        }
    }
}
