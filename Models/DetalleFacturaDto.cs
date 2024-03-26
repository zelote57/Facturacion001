namespace Facturacion.Models
{
    public class DetalleFacturaDto
    {
        public System.Guid Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public bool GrabaIva { get; set; }        
    }
}
