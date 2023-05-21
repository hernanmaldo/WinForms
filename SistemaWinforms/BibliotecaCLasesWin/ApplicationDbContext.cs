using BibliotecaCLasesWin.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaCLasesWin
{
    public class ApplicationDbContext: DbContext 
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Bebida> Bebidas { get; set; }  

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoProducto> PedidosProductos { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Clientes.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //genero productos de pueba por defecto
            modelBuilder.Entity<Cliente>().HasData(new Cliente { ClienteId = 1, ClienteNombre = "Hernan",ClienteApellido= "Maldonado", DNI = "42530393", FechaNacimiento = DateTime.Now, Telefono = "3493669162" });
            modelBuilder.Entity<Producto>().HasData(new Producto { ProductoId = 1, ProductoNombre = "Producto1", Cantidad = 50, Descripcion = "Descripcion", Precio = 52.10 });
            modelBuilder.Entity<Producto>().HasData(new Producto { ProductoId = 2, ProductoNombre = "Producto2", Cantidad = 50, Descripcion = "Descripcion", Precio = 52.10 });
            modelBuilder.Entity<Producto>().HasData(new Producto { ProductoId = 3, ProductoNombre = "Producto3", Cantidad = 50, Descripcion = "Descripcion", Precio = 52.10 });
            modelBuilder.Entity<Producto>().HasData(new Producto { ProductoId = 4, ProductoNombre = "Producto4", Cantidad = 50, Descripcion = "Descripcion", Precio = 52.10 });

            
            modelBuilder.Entity<PedidoProducto>()
       .HasKey(pp => new { pp.PedidoId, pp.ProductoId });

            modelBuilder.Entity<PedidoProducto>()
                .HasOne(pp => pp.Pedido)
                .WithMany(p => p.PedidosProductos)
                .HasForeignKey(pp => pp.PedidoId);

            modelBuilder.Entity<PedidoProducto>()
                .HasOne(pp => pp.Producto)
                .WithMany(p => p.PedidosProductos)
                .HasForeignKey(pp => pp.ProductoId);





            base.OnModelCreating(modelBuilder);

        }
    }
}
