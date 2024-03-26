using System.Collections.Generic;

namespace Facturacion.Models
{
    public class FacturaModelo
    {
        public CabeceraFactura Cabecera { get; set; }
        public List<DetalleFactura> Detalle { get; set; }
    }
}
