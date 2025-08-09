using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.IO;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace TFinal
{
    public partial class Facturación : Form
    {

        // Colores personalizados basados en el diseño
        private readonly BaseColor COLOR_TITULO = new BaseColor(50, 50, 50);  // Gris oscuro
        private readonly BaseColor COLOR_TEXTO = new BaseColor(70, 70, 70);    // Gris medio
        private readonly BaseColor COLOR_DESTACADO = new BaseColor(40, 40, 40); // Gris más oscuro

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
            try
            {
                string folderPath = @"C:\Users\Yunni\Downloads\FacturasGeneradas\";
                Directory.CreateDirectory(folderPath);

                string codigoFactura = "B" + DateTime.Now.ToString("yyyyMMddHHmmss");
                //nombre del archivo con código de factura y extensión .pdf
                string filePath = Path.Combine(folderPath, $"{codigoFactura}.pdf");

                // Configuración del documento (+80mm de ancho)
                float ancho = 250f;
                var pageRect = new iTextSharp.text.Rectangle(ancho, 1000f);
                Document doc = new Document(pageRect, 10, 10, 10, 10);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Configuración de fuentes
                var negritaFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9);
                var negritaFont2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                var normalFont2 = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                var smallFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);

                // Logo centrado en la parte superior
                string logoPath = @"C:\Users\Yunni\Downloads\logo1.png";
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.Alignment = Element.ALIGN_CENTER;
                    logo.ScaleToFit(60f, 60f);
                    doc.Add(logo);
                    //doc.Add(new Paragraph(" "));
                }

                // Encabezado - Nombre del negocio (centrado)
                Paragraph titulo = new Paragraph("IYUGU MINIMARKET", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                // RUC (centrado)
                doc.Add(new Paragraph("RUC: 12345678901", smallFont) { Alignment = Element.ALIGN_CENTER });

                // Tipo de documento y número (centrado)
                doc.Add(new Paragraph("BOLETA / FACTURA", negritaFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"N° {codigoFactura}", normalFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph(" "));

                // Datos del cliente (alineados a la izquierda con sangría)
                Paragraph datosCliente = new Paragraph();
                datosCliente.Alignment = Element.ALIGN_LEFT;
                datosCliente.Add(new Phrase($"Tipo Doc: {cbTipoDoc.Text}\n", normalFont));
                datosCliente.Add(new Phrase($"Razón Social: {txtRazon.Text}\n", normalFont));
                datosCliente.Add(new Phrase($"Nombre: {txtNombre.Text}\n", normalFont));
                datosCliente.Add(new Phrase($"N° Documento: {txtDocumento.Text}", normalFont));
                doc.Add(datosCliente);

                // Fecha y hora (alineados a la izquierda con sangría)
                string periodo = DateTime.Now.Hour < 12 ? "a. m." : "p. m.";
                string horaFormateada = $"{DateTime.Now:hh:mm} {periodo}";
                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}   Hora: {horaFormateada}", normalFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph(" "));

                // Tabla de productos (5 columnas, alineación exacta como en imagen)
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 0.8f, 2.5f, 0.8f, 0.8f, 1.1f }); // Proporciones exactas

                // Eliminar bordes y ajustar padding
                tabla.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tabla.DefaultCell.Padding = 1;
                tabla.DefaultCell.PaddingBottom = 3;

                // Encabezados de tabla (negrita, alineación exacta)
                AddCell(tabla, "COD", negritaFont2, Element.ALIGN_LEFT);
                AddCell(tabla, "PRODUCTO", negritaFont2, Element.ALIGN_CENTER);
                AddCell(tabla, "P.U", negritaFont2, Element.ALIGN_LEFT);
                AddCell(tabla, "CANT", negritaFont2, Element.ALIGN_CENTER);
                AddCell(tabla, "IMPORTE", negritaFont2, Element.ALIGN_LEFT);

                // Productos (alineación exacta como encabezados)
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string cod = fila.Cells["ColCodigo"].Value?.ToString() ?? "";
                    string prod = fila.Cells["ColProducto"].Value?.ToString() ?? "";
                    string precio = fila.Cells["ColPrecio"].Value?.ToString() ?? "";
                    string cant = fila.Cells["ColCantidad"].Value?.ToString() ?? "";
                    string importe = fila.Cells["ColImporte"].Value?.ToString() ?? "";

                    AddCell(tabla, cod, normalFont2, Element.ALIGN_LEFT);
                    AddCell(tabla, prod, normalFont2, Element.ALIGN_CENTER);
                    AddCell(tabla, precio, normalFont2, Element.ALIGN_LEFT);
                    AddCell(tabla, cant, normalFont2, Element.ALIGN_CENTER);
                    AddCell(tabla, importe, normalFont2, Element.ALIGN_LEFT);
                }

                doc.Add(tabla);
                doc.Add(new Paragraph("----------------------------------------------------------------------------", smallFont));

                // Totales (alineación exacta como en imagen)
                decimal subtotal = 0m, igv = 0m, total = 0m, pago = 0m, vuelto = 0m;
                decimal.TryParse(txtInafecto.Text, out subtotal);
                decimal.TryParse(txtIGV.Text, out igv);
                decimal.TryParse(txtTotalPagar.Text, out total);
                decimal.TryParse(txtSoles.Text, out pago);
                decimal.TryParse(txtVuelto.Text, out vuelto);

                doc.Add(new Paragraph($"SUBTOTAL: S/ {subtotal.ToString("0.00").PadLeft(10)}", negritaFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph($"IGV (18%): S/ {igv.ToString("0.00").PadLeft(10)}", negritaFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph($"TOTAL: S/ {total.ToString("0.00").PadLeft(10)}", negritaFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph("---------------------------------------------------------------------------", smallFont));

                // Monto en letras (alineado a la izquierda con sangría)
                doc.Add(new Paragraph($"SON: {NumeroALetras(total)}", normalFont) { Alignment = Element.ALIGN_LEFT });

                // Pago y vuelto (alineación exacta como en imagen)
                doc.Add(new Paragraph($"PAGO: S/ {pago.ToString("0.00").PadLeft(10)}", negritaFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph($"VUELTO: S/ {vuelto.ToString("0.00").PadLeft(10)}", negritaFont) { Alignment = Element.ALIGN_LEFT });
                doc.Add(new Paragraph(" "));

                // Mensaje final (centrado)
                doc.Add(new Paragraph("¡Gracias por su compra!", smallFont) { Alignment = Element.ALIGN_CENTER });

                doc.Close();

                MessageBox.Show($"Boleta generada correctamente en:\n{filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la boleta: {ex.Message}");
            }
        }

        private void AddCell(PdfPTable table, string text, Font font, int alignment)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = alignment;
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.Padding = 1;
            cell.PaddingBottom = 3;
            table.AddCell(cell);
        }


        // Conversor a letras (ya integrado)
        private string NumeroALetras(decimal numero)
        {
            string decimales = "";
            int entero = (int)Math.Floor(numero);
            int centimos = (int)Math.Round((numero - entero) * 100, 2);

            if (centimos > 0)
            {
                decimales = $" CON {centimos:00}/100";
            }

            return $"{ConvertirNumero(entero)}{decimales} SOLES";
        }

        private string ConvertirNumero(int valor)
        {
            string[] unidades = { "", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ",
                "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISÉIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
            string[] decenas = { "", "", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] centenas = { "", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS",
                "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

            if (valor == 0) return "CERO";
            if (valor == 100) return "CIEN";

            if (valor < 20) return unidades[valor];
            if (valor < 100)
            {
                int d = valor / 10;
                int u = valor % 10;
                if (valor < 30 && valor > 20)
                    return ("VEINTI" + unidades[u]).ToUpper();
                return decenas[d] + (u > 0 ? " Y " + unidades[u] : "");
            }
            if (valor < 1000)
            {
                int c = valor / 100;
                int resto = valor % 100;
                return centenas[c] + (resto > 0 ? " " + ConvertirNumero(resto) : "");
            }
            if (valor < 1000000)
            {
                int miles = valor / 1000;
                int resto = valor % 1000;
                if (miles == 1)
                    return "MIL" + (resto > 0 ? " " + ConvertirNumero(resto) : "");
                return ConvertirNumero(miles) + " MIL" + (resto > 0 ? " " + ConvertirNumero(resto) : "");
            }
            if (valor < 1000000000)
            {
                int millones = valor / 1000000;
                int resto = valor % 1000000;
                if (millones == 1)
                    return "UN MILLÓN" + (resto > 0 ? " " + ConvertirNumero(resto) : "");
                return ConvertirNumero(millones) + " MILLONES" + (resto > 0 ? " " + ConvertirNumero(resto) : "");
            }
            return "";
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
