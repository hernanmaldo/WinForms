using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BibliotecaCLasesWin.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        public string CodPedido { get; set; } = null!;

        public DateTime Fecha { get; set;} 
        
        public int ClienteId { get; set; }  

        public Cliente Cliente { get; set;}

        public List<Producto> Productos { get; set; }

        public ICollection<PedidoProducto> PedidosProductos { get; set; }

        private static  int  CodSeed = 10000000; // al parecer entity no crea campos con referencia a propiedades que sean estaticas, un golazo jajaj
        public Pedido()
        {

            CodPedido = CodSeed.ToString();
            CodSeed++;
        }

        public double ObtenerTotalPedido()
        {
            List<double> PreciosProductos = new List<double>(); 
            List<int> CantidadProductos = new List<int>();
            double total = 0;

            foreach(var item in Productos)
            {
                PreciosProductos.Add(item.Precio);
            }
            foreach(var item in PedidosProductos)
            {
                CantidadProductos.Add(item.Cantidad);
            }
            for (int i = 0; i< PreciosProductos.Count();i++) {

                total += PreciosProductos[i] * CantidadProductos[i];
            
            }
            return total;   
        }


    }
}
