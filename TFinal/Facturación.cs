using System;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\FacturasGeneradas\";
            Directory.CreateDirectory(folderPath);

            string codigoFactura = "FAC-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string filePath = Path.Combine(folderPath, $"{codigoFactura}.pdf");

            Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Logo
            string logoPath = @"C:\Users\Yunni\Downloads\logo1.png";
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleToFit(80f, 80f);
                logo.Alignment = Element.ALIGN_LEFT;
                doc.Add(logo);
            }

            // Título
            Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Paragraph titulo = new Paragraph("IYUGU MINIMARKET\nFACTURA DE VENTA", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Paragraph("\n"));

            // Datos del cliente
            Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            doc.Add(new Paragraph("DATOS DEL CLIENTE", boldFont));
            doc.Add(new Paragraph("Tipo de Documento: " + cbTipoDoc.Text));
            doc.Add(new Paragraph("Razón Social: " + txtRazon.Text));
            doc.Add(new Paragraph("Nombre Completo: " + txtNombre.Text));
            doc.Add(new Paragraph("Número de Documento: " + txtDocumento.Text));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
            doc.Add(new Paragraph("Código de Factura: " + codigoFactura));
            doc.Add(new Paragraph("-------------------------------------------------------------"));

            // Tabla de productos
            PdfPTable tabla = new PdfPTable(5);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 1, 3, 2, 1, 2 });

            tabla.AddCell("Código");
            tabla.AddCell("Producto");
            tabla.AddCell("Precio");
            tabla.AddCell("Cantidad");
            tabla.AddCell("Importe");

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["ColCodigo"].Value != null)
                {
                    tabla.AddCell(fila.Cells["ColCodigo"].Value.ToString());
                    tabla.AddCell(fila.Cells["ColProducto"].Value.ToString());
                    tabla.AddCell(fila.Cells["ColPrecio"].Value.ToString());
                    tabla.AddCell(fila.Cells["ColCantidad"].Value.ToString());
                    tabla.AddCell(fila.Cells["ColImporte"].Value.ToString());
                }
            }

            doc.Add(tabla);
            doc.Add(new Paragraph("-------------------------------------------------------------"));

            // Totales
            doc.Add(new Paragraph("TOTAL INAFECTO: S/ " + txtInafecto.Text));
            doc.Add(new Paragraph("IGV (18%): S/ " + txtIGV.Text));
            doc.Add(new Paragraph("IMPORTE TOTAL: S/ " + txtImporte.Text));
            doc.Add(new Paragraph("TOTAL A PAGAR: S/ " + txtTotalPagar.Text));

            doc.Add(new Paragraph("-------------------------------------------------------------"));

            // Pago
            doc.Add(new Paragraph("MONTO PAGADO: S/ " + txtSoles.Text));
            doc.Add(new Paragraph("VUELTO: S/ " + txtVuelto.Text));

            Font italicFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 11);
            doc.Add(new Paragraph("\nGracias por su compra!", italicFont));

            doc.Close();

            MessageBox.Show("Factura generada correctamente en:\n" + filePath);
        }
    }
}
