namespace BibliotecaCLasesWin.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string DNI { get; set; } = null!;

        public string ClienteNombre { get; set; } = null!;

        public string ClienteApellido { get; set; } = null!;    

        public string Telefono { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }    

    }
}