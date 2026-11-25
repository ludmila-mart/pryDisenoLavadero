using System;
using System.Globalization;
using System.Windows.Forms;

namespace pryDisenoLavadero
{
    public partial class frmLavadero : Form
    {
        // ANEXO: Reemplazar por los valores indicados en la consigna / anexo
        private const decimal RecargoExpressPorc = 25m;
        private const decimal DescuentoFrecuentePorc = 5m;

        public frmLavadero()
        {
            InitializeComponent();
        }

        private void frmLavadero_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                chkExpress.Checked = false;
            }
        }

        private void chkExpress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpress.Checked)
            {
                chkNormal.Checked = false;
            }
        }

        private void cbxCliente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

   
        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos(out int cantidad)
        {
            cantidad = 0;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            string patente = txtPatente.Text.Trim();
            if (patente.Length != 6 && patente.Length != 7)
            {
                MessageBox.Show("La patente debe tener 6 o 7 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatente.Focus();
                return false;
            }

            if (cboServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un servicio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboServicio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                !int.TryParse(txtCliente.Text.Trim(), out cantidad) ||
                cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("La cantidad debe ser un número entero entre 1 y 5.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            if (!chkNormal.Checked && !chkExpress.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega (Normal o Express).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkNormal.Focus();
                return false;
            }

            return true;
        }

        private decimal ObtenerPrecioPorVehiculo()
        {
            string servicio = cboServicio.SelectedItem?.ToString() ?? string.Empty;

            switch (servicio)
            {
                case "Lavado Básico":
                    return 10000m;
                case "Lavado Completo":
                    return 15000m;
                case "Encerado":
                    return 20000m;
                default:
                    return 0m;
            }
        }

        private static decimal ObtenerPorcentajeDescuento(int cantidad, bool esClienteFrecuente)
        {
            decimal porcentaje;

            if (cantidad >= 4)
            {
                porcentaje = 15m;
            }
            else if (cantidad >= 2)
            {
                porcentaje = 10m;
            }
            else
            {
                porcentaje = 0m;
            }

            if (esClienteFrecuente)
            {
                porcentaje += DescuentoFrecuentePorc;
            }

            return porcentaje;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(out int cantidad))
            {
                return;
            }

            decimal precioVehiculo = ObtenerPrecioPorVehiculo();
            decimal subtotal = precioVehiculo * cantidad;

            decimal recargo = chkExpress.Checked
                ? subtotal * (RecargoExpressPorc / 100m)
                : 0m;

            decimal porcentajeDescuento = ObtenerPorcentajeDescuento(cantidad, cbxCliente.Checked);
            decimal importeDescuento = subtotal * (porcentajeDescuento / 100m);

            decimal total = subtotal + recargo - importeDescuento;

            CultureInfo ar = new("es-AR");

            lblSub.Text = $"Subtotal: {subtotal.ToString("N2", ar)}";
            lblRecargo.Text = $"Recargo: {recargo.ToString("N2", ar)}";
            lblDescuento.Text = $"Descuento ({porcentajeDescuento:0.##}%): {importeDescuento.ToString("N2", ar)}";
            lblTotal.Text = $"Total: {total.ToString("N2", ar)}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtPatente.Clear();
            cboServicio.SelectedIndex = -1;
            txtCliente.Clear();
            chkNormal.Checked = false;
            chkExpress.Checked = false;
            cbxCliente.Checked = false;

            CultureInfo ar = new("es-AR");
            lblSub.Text = $"Subtotal: {0m.ToString("N2", ar)}";
            lblRecargo.Text = $"Recargo: {0m.ToString("N2", ar)}";
            lblDescuento.Text = $"Descuento: {0m.ToString("N2", ar)}";
            lblTotal.Text = $"Total: {0m.ToString("N2", ar)}";

            txtCliente.Focus();
        }
    }
}