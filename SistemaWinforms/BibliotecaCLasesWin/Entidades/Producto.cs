using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLasesWin.Entidades
{
    public class Producto
    {
        
         public int ProductoId { get; set; } 

        public string ProductoNombre { get; set; } = null!; 

        public string Descripcion { get; set; } = null!;

        public double Precio { get; set; }  

        public int Cantidad { get; set; }

        public ICollection<PedidoProducto> PedidosProductos { get; set; }

        public static int ObtenerProductoSeleccionado(String entradaText, ApplicationDbContext applicationDbContext)
        {
            //este metodo devuelve Producto.ProductoId a traves de su Pedido.ProductoNombre
            string nombreProducto = entradaText;
            ;

            Producto productoSeleccionado = applicationDbContext.Productos.FirstOrDefault(p => p.ProductoNombre == nombreProducto);


            if (productoSeleccionado != null)
            {
                return productoSeleccionado.ProductoId;
            }
            else { return 1; }
        }
    }
}
