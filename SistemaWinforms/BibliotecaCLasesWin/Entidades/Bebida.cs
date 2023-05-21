using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLasesWin.Entidades
{
    public class Bebida : Producto
    {
        public int VolumenContenido { get; set; }   

        public DateTime fechaVencimiento { get; set; }  
    }
}
