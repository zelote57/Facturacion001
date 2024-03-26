using Facturacion.Models;
using System.Linq;

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

        public int ObtenerSecuencial()
        {
            var secuencial = 0;
            using (var db = new FacturacionDbContext())
            {
                secuencial = db.CabeceraFacturas.OrderByDescending(t => t.Fecha)
                    .Select(x => x.Secuencial).FirstOrDefault();
            }
            return secuencial + 1;
        }
    }
}
