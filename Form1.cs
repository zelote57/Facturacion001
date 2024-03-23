using Facturacion.Data;
using System;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        private const string _decimalZeroValue = "0.00";

        public Form1()
        {
            InitializeComponent();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //crear una instancia de la clase a usar
            var facManager = new FacturacionManager();
            var cabeceraFactura = ObtenerDatosDelFormulario();

            //grabar cabecera de factura
            var resultado = facManager.GrabarCabeceraDeFactura(cabeceraFactura);

            if (resultado == true)
            {
                MessageBox.Show("Datos guardados correctamente");
            }
            else
            {
                MessageBox.Show("No se guardaron Datos");
            }            
        }

        private CabeceraFactura ObtenerDatosDelFormulario()
        {
            return new CabeceraFactura
            {
                NombreCliente = txtCliente.Text,
                IdentificadorCliente = txtNumeroIdentificacion.Text,
                Fecha = DateTime.Now,
                SubTotalIva = decimal.Parse(txtSubTotalIva.Text),
                SubTotalNoIva = decimal.Parse(txtSubTotalNoIva.Text),
                SubTotalSuma = decimal.Parse(txtSubTotalSuma.Text),
                Iva = decimal.Parse(txtIva.Text),
                Total = decimal.Parse(txtValorTotal.Text)
            };
        }

        private void LimpiarFormulario()
        {
            txtCliente.Text = string.Empty;
            txtNumeroIdentificacion.Text = string.Empty;
            txtSubTotalIva.Text = _decimalZeroValue;
            txtSubTotalNoIva.Text = _decimalZeroValue;
            txtSubTotalSuma.Text = _decimalZeroValue;
            txtIva.Text = _decimalZeroValue;
            txtValorTotal.Text = _decimalZeroValue;
        }
    
    }
}
