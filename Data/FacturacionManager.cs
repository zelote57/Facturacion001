using Facturacion.Models;

namespace Facturacion.Data
{
    public class FacturacionManager
    {
        public bool GrabarFactura(FacturaModelo factura)
        {
            try
            {
                using (var db = new FacturacionDbContext())
                {
                    db.CabeceraFacturas.Add(factura.Cabecera);

                    foreach (var detalleFactura in factura.Detalle)
                    {
                        db.DetalleFacturas.Add(detalleFactura);
                    }

                    db.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}
