using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace TFinal
{
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private List<Producto> productos = new List<Producto>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
            string.IsNullOrWhiteSpace(txtProducto.Text) ||
            string.IsNullOrWhiteSpace(txtPrecio.Text) ||
            string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Complete todos los campos del producto.", "Advertencia");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.", "Error");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.", "Error");
                return;
            }

            Producto p = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtProducto.Text,
                Precio = precio,
                Cantidad = cantidad
            };

            productos.Add(p);
            ActualizarTabla();
            btnLimpiar_Click(null, null);
        }

        private void ActualizarTabla()
        {
            dgvProductos.Rows.Clear();
            foreach (var p in productos)
            {
                dgvProductos.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Precio.ToString("0.00"),
                    p.Cantidad,
                    p.Importe.ToString("0.00")
                );
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCodigo.Focus();
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show(
                        "¿Deseas eliminar este producto?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        int filaSeleccionada = dgvProductos.SelectedRows[0].Index;
                        productos.RemoveAt(filaSeleccionada);
                        ActualizarTabla();
                    }
                }
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0, igv, total;
            foreach (var p in productos)
                subtotal += p.Importe;

            igv = subtotal * 0.18m;
            subtotal = subtotal - (subtotal * 0.18m); // Aplicar descuento del 18% como inafecto
            total = subtotal + igv;

            txtInafecto.Text = subtotal.ToString("0.00");
            txtIGV.Text = igv.ToString("0.00");
            txtImporte.Text = total.ToString("0.00");
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void txtSoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (decimal.TryParse(txtSoles.Text, out decimal pago) &&
                    decimal.TryParse(txtTotalPagar.Text, out decimal total))
                {
                    if (pago >= total)
                    {
                        decimal vuelto = pago - total;
                        txtVuelto.Text = vuelto.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("El pago es menor al total a pagar.");
                        txtVuelto.Clear();
                    }
                }
            }
        }

        private void Facturación_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
