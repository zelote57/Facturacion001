using Facturacion.Data;
using Facturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        private const string _decimalZeroValue = "0.00";
        private List<DetalleFacturaDto> _detalleDeFacturaGrid;
        private List<Guid> _detalleDeFacturaGridGrabaIva;
        private List<Guid> _detalleDeFacturaGridNoGrabaIva;

        public Form1()
        {
            InitializeComponent();
            ObtenerMostrarSecuencial();
            LimpiarFormulario();
        }

        private void ObtenerMostrarSecuencial()
        {
            var manager = new FacturacionManager();
            lblNumeroSecuencial.Text = manager.ObtenerSecuencial().ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            //crear una instancia de la clase a usar
            var facManager = new FacturacionManager();

            var nuevaFactura = ObtenerDatosDelFormulario();

            //grabar cabecera de factura
            var resultado = facManager.GrabarFactura(nuevaFactura);

            if (resultado == true)
            {
                MessageBox.Show("Datos guardados correctamente");
            }
            else
            {
                MessageBox.Show("No se guardaron Datos");
            }
        }

        private FacturaModelo ObtenerDatosDelFormulario()
        {
            var idFactura = Guid.NewGuid();
            var factura = new FacturaModelo();

            factura.Cabecera = new CabeceraFactura
            {
                Id = idFactura,
                NombreCliente = txtCliente.Text,
                IdentificadorCliente = txtNumeroIdentificacion.Text,
                Fecha = DateTime.Now,
                SubTotalIva = decimal.Parse(txtSubTotalIva.Text),
                SubTotalNoIva = decimal.Parse(txtSubTotalNoIva.Text),
                SubTotalSuma = decimal.Parse(txtSubTotalSuma.Text),
                Iva = decimal.Parse(txtIva.Text),
                Total = decimal.Parse(txtValorTotal.Text)
            };

            factura.Detalle = new List<DetalleFactura>();

            foreach (var itemGrid in _detalleDeFacturaGrid)
            {
                var itemDetalle = new DetalleFactura
                {
                    Id = itemGrid.Id,
                    Producto = itemGrid.Producto,
                    ValorUnitario = itemGrid.ValorUnitario,
                    ValorTotal = itemGrid.ValorTotal,
                    GrabaIva = itemGrid.GrabaIva,
                    CabeceraFacturaId = idFactura
                };

                factura.Detalle.Add(itemDetalle);
            }

            return factura;
        }

        private void InicializarGridDetalleDeFactura()
        {
            _detalleDeFacturaGrid = new List<DetalleFacturaDto>();
            _detalleDeFacturaGridGrabaIva = new List<Guid>();
            _detalleDeFacturaGridNoGrabaIva = new List<Guid>();
            AgregarFilaDetalleFactura();
        }

        private void AgregarFilaDetalleFactura()
        {
            var idNuevaFila = Guid.NewGuid();
            _detalleDeFacturaGrid.Add(new DetalleFacturaDto
            {
                Id = idNuevaFila,
                Producto = string.Empty,
                Cantidad = 0,
                ValorUnitario = 0M,
                ValorTotal = 0M,
                GrabaIva = false
            });

            _detalleDeFacturaGridNoGrabaIva.Add(idNuevaFila);

            UpdateDataGrid();
        }

        private void LimpiarFormulario()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();

            txtCliente.Text = string.Empty;
            txtNumeroIdentificacion.Text = string.Empty;
            txtSubTotalIva.Text = _decimalZeroValue;
            txtSubTotalNoIva.Text = _decimalZeroValue;
            txtSubTotalSuma.Text = _decimalZeroValue;
            txtIva.Text = _decimalZeroValue;
            txtValorTotal.Text = _decimalZeroValue;

            InicializarGridDetalleDeFactura();
        }

        private void btnAgregarFilaDetalle_Click(object sender, EventArgs e)
        {
            AgregarFilaDetalleFactura();
        }

        private void btnQuitarFilaDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.SelectedRows == null ||
                dgvDetalleFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay Filas Seleccionadas");
                return;
            }

            if (dgvDetalleFactura.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo una fila");
                return;
            }

            var idDetalleParaEliminar = dgvDetalleFactura.SelectedRows[0].Cells[nameof(DetalleFacturaDto.Id)].Value.ToString();

            var itemParaEliminar = _detalleDeFacturaGrid.First(x => x.Id == new Guid(idDetalleParaEliminar));

            var grabaIvaDetalleFactura = (bool)dgvDetalleFactura.SelectedRows[0].Cells[nameof(DetalleFacturaDto.GrabaIva)].Value;

            if (grabaIvaDetalleFactura)
            {
                _detalleDeFacturaGridGrabaIva.Remove(new Guid(idDetalleParaEliminar));
            }
            else
            {
                _detalleDeFacturaGridNoGrabaIva.Remove(new Guid(idDetalleParaEliminar));
            }

            _detalleDeFacturaGrid.Remove(itemParaEliminar);
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            dgvDetalleFactura.DataSource = null;
            dgvDetalleFactura.DataSource = _detalleDeFacturaGrid;
            dgvDetalleFactura.Columns[nameof(DetalleFacturaDto.Id)].Visible = false;
            CalcularTotales();
        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var columName = dgvDetalleFactura.Columns[e.ColumnIndex].Name;

                if (columName == nameof(DetalleFacturaDto.GrabaIva))
                {
                    var idDetalleFactura = new Guid(dgvDetalleFactura.Rows[e.RowIndex].Cells[nameof(DetalleFacturaDto.Id)].Value.ToString());
                    var grabaIvaDetalleFactura = (bool)dgvDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;

                    if (grabaIvaDetalleFactura)
                    {
                        _detalleDeFacturaGridNoGrabaIva.Remove(idDetalleFactura);

                        var existe = _detalleDeFacturaGridGrabaIva.Exists(x => x.Equals(idDetalleFactura));
                        if (!existe)
                        {
                            _detalleDeFacturaGridGrabaIva.Add(idDetalleFactura);
                        }
                    }
                    else
                    {
                        _detalleDeFacturaGridGrabaIva.Remove(idDetalleFactura);

                        var existe = _detalleDeFacturaGridNoGrabaIva.Exists(x => x.Equals(idDetalleFactura));
                        if (!existe)
                        {
                            _detalleDeFacturaGridNoGrabaIva.Add(idDetalleFactura);
                        }
                    }

                    CalcularTotales();
                }
            }
        }

        private void CalcularTotales()
        {
            var subTotalIva = 0M;
            var subTotalNoIva = 0M;
            var subTotalSuma = 0M;
            var iva = 0M;
            var valorTotal = 0M;

            foreach (var itemGrid in _detalleDeFacturaGrid)
            {
                if (_detalleDeFacturaGridGrabaIva.Contains(itemGrid.Id))
                {
                    subTotalIva = subTotalIva + itemGrid.ValorTotal;
                }

                if (_detalleDeFacturaGridNoGrabaIva.Contains(itemGrid.Id))
                {
                    subTotalNoIva = subTotalNoIva + itemGrid.ValorTotal;
                }
            }

            subTotalSuma = subTotalIva + subTotalNoIva;

            iva = subTotalIva * 0.12M;

            valorTotal = subTotalSuma + iva;

            txtSubTotalIva.Text = subTotalIva.ToString("0.00");
            txtSubTotalNoIva.Text = subTotalNoIva.ToString("0.00");
            txtSubTotalSuma.Text = subTotalSuma.ToString("0.00");
            txtIva.Text = iva.ToString("0.00");
            txtValorTotal.Text = valorTotal.ToString("0.00");
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtCliente.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un nombre del cliente");
                return false;
            }

            if (string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un número de identificación del cliente");
                return false;
            }

            bool isNumeric = int.TryParse(txtNumeroIdentificacion.Text.Trim(), out int n);

            if (!isNumeric)
            {
                MessageBox.Show("Debe ingresar un número de identificación válido");
                return false;
            }

            if (_detalleDeFacturaGrid.Count == 0)
            {
                MessageBox.Show("Debe agregar productos");
                return false;
            }

            if (decimal.Parse(txtValorTotal.Text) == 0)
            {
                MessageBox.Show("Debe agregar un producto válido");
                return false;
            }

            return true;
        }
    }
}
