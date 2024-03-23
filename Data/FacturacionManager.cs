namespace Facturacion.Data
{
    public class FacturacionManager
    {
        public bool GrabarCabeceraDeFactura(CabeceraFactura cabeceraFactura)
        {
            try
            {
                using (var db = new FacturacionDbContext())
                {
                    db.CabeceraFacturas.Add(cabeceraFactura);
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
