namespace TFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            dgvProductos = new ListView();
            txtRazonSocial = new TextBox();
            txtNombreCompleto = new TextBox();
            txtNumeroDocumento = new TextBox();
            groupBox1 = new GroupBox();
            mbTipoDocumento = new ComboBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            txtCodigo = new TextBox();
            label7 = new Label();
            label1 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            btnCalcularTotal = new Button();
            btnImprimir = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            txtVuelto = new TextBox();
            txtSoles = new TextBox();
            label15 = new Label();
            label14 = new Label();
            groupBox2 = new GroupBox();
            txtTotalPagar = new TextBox();
            label13 = new Label();
            txtImporte = new TextBox();
            txtIGV = new TextBox();
            txtInafecto = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            colCodigo = new ColumnHeader();
            colProducto = new ColumnHeader();
            colPrecio = new ColumnHeader();
            colCantidad = new ColumnHeader();
            colImporte = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 56, 95);
            label2.Location = new Point(5, 23);
            label2.Name = "label2";
            label2.Size = new Size(136, 19);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(62, 56, 95);
            label3.Location = new Point(5, 104);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 2;
            label3.Text = "Número de Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(62, 56, 95);
            label4.Location = new Point(5, 50);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 3;
            label4.Text = "Razón Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(62, 56, 95);
            label5.Location = new Point(5, 76);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 4;
            label5.Text = "Nombre Completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(62, 56, 95);
            label6.Location = new Point(5, 45);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 5;
            label6.Text = "Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(62, 56, 95);
            label8.Location = new Point(5, 71);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 7;
            label8.Text = "Precio:";
            // 
            // dgvProductos
            // 
            dgvProductos.BackColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.FixedSingle;
            dgvProductos.Columns.AddRange(new ColumnHeader[] { colCodigo, colProducto, colPrecio, colCantidad, colImporte });
            dgvProductos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvProductos.ForeColor = Color.FromArgb(62, 56, 95);
            dgvProductos.Location = new Point(21, 347);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.OwnerDraw = true;
            dgvProductos.Size = new Size(635, 161);
            dgvProductos.TabIndex = 8;
            dgvProductos.UseCompatibleStateImageBehavior = false;
            dgvProductos.View = View.Details;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(111, 46);
            txtRazonSocial.Margin = new Padding(3, 2, 3, 2);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(233, 21);
            txtRazonSocial.TabIndex = 10;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(155, 74);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(190, 21);
            txtNombreCompleto.TabIndex = 11;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(188, 104);
            txtNumeroDocumento.Margin = new Padding(3, 2, 3, 2);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(156, 21);
            txtNumeroDocumento.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(mbTipoDocumento);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(txtNumeroDocumento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(46, 56, 77);
            groupBox1.Location = new Point(21, 79);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 135);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Cliente";
            // 
            // mbTipoDocumento
            // 
            mbTipoDocumento.FlatStyle = FlatStyle.System;
            mbTipoDocumento.FormattingEnabled = true;
            mbTipoDocumento.Location = new Point(163, 23);
            mbTipoDocumento.Margin = new Padding(3, 2, 3, 2);
            mbTipoDocumento.Name = "mbTipoDocumento";
            mbTipoDocumento.Size = new Size(112, 20);
            mbTipoDocumento.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(62, 56, 95);
            label9.Location = new Point(5, 20);
            label9.Name = "label9";
            label9.Size = new Size(57, 19);
            label9.TabIndex = 15;
            label9.Text = "Código:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtCantidad);
            groupBox4.Controls.Add(txtPrecio);
            groupBox4.Controls.Add(txtProducto);
            groupBox4.Controls.Add(txtCodigo);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(21, 219);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(274, 124);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(98, 92);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(157, 21);
            txtCantidad.TabIndex = 20;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(98, 68);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(157, 21);
            txtPrecio.TabIndex = 19;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(98, 44);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(157, 21);
            txtProducto.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(98, 18);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(157, 21);
            txtCodigo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(62, 56, 95);
            label7.Location = new Point(5, 93);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 16;
            label7.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 56, 95);
            label1.Location = new Point(65, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(246, 25);
            label1.TabIndex = 18;
            label1.Text = "IYUGU - MINIMARKET";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(144, 118, 179);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 235, 255);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 235, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(84, 76, 133);
            btnLimpiar.Location = new Point(307, 248);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 30);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(144, 118, 179);
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 235, 255);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 235, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(84, 76, 133);
            btnAgregar.Location = new Point(307, 291);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 30);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "+Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.FlatAppearance.BorderColor = Color.FromArgb(144, 118, 179);
            btnCalcularTotal.FlatAppearance.BorderSize = 2;
            btnCalcularTotal.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 235, 255);
            btnCalcularTotal.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 235, 255);
            btnCalcularTotal.FlatStyle = FlatStyle.Flat;
            btnCalcularTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularTotal.ForeColor = Color.FromArgb(84, 76, 133);
            btnCalcularTotal.Location = new Point(392, 525);
            btnCalcularTotal.Margin = new Padding(3, 2, 3, 2);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(136, 37);
            btnCalcularTotal.TabIndex = 21;
            btnCalcularTotal.Text = "Calcular Total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatAppearance.BorderColor = Color.FromArgb(144, 118, 179);
            btnImprimir.FlatAppearance.BorderSize = 2;
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 235, 255);
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 235, 255);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.FromArgb(84, 76, 133);
            btnImprimir.Location = new Point(556, 525);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(99, 37);
            btnImprimir.TabIndex = 22;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 219, 252);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 54);
            panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtVuelto);
            groupBox3.Controls.Add(txtSoles);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(419, 241);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(236, 80);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Importe Cliente:";
            // 
            // txtVuelto
            // 
            txtVuelto.BackColor = Color.White;
            txtVuelto.Location = new Point(84, 51);
            txtVuelto.Margin = new Padding(3, 2, 3, 2);
            txtVuelto.Name = "txtVuelto";
            txtVuelto.ReadOnly = true;
            txtVuelto.Size = new Size(125, 21);
            txtVuelto.TabIndex = 25;
            // 
            // txtSoles
            // 
            txtSoles.Location = new Point(84, 23);
            txtSoles.Margin = new Padding(3, 2, 3, 2);
            txtSoles.Name = "txtSoles";
            txtSoles.Size = new Size(125, 21);
            txtSoles.TabIndex = 24;
            txtSoles.TextChanged += txtSoles_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(62, 56, 95);
            label15.Location = new Point(11, 54);
            label15.Name = "label15";
            label15.Size = new Size(53, 19);
            label15.TabIndex = 23;
            label15.Text = "Vuelto:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(62, 56, 95);
            label14.Location = new Point(21, 26);
            label14.Name = "label14";
            label14.Size = new Size(45, 19);
            label14.TabIndex = 22;
            label14.Text = "Soles:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalPagar);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtImporte);
            groupBox2.Controls.Add(txtIGV);
            groupBox2.Controls.Add(txtInafecto);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(419, 79);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(236, 148);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Montos Totales";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BackColor = Color.White;
            txtTotalPagar.Location = new Point(119, 116);
            txtTotalPagar.Margin = new Padding(3, 2, 3, 2);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.ReadOnly = true;
            txtTotalPagar.Size = new Size(95, 21);
            txtTotalPagar.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(62, 56, 95);
            label13.Location = new Point(5, 118);
            label13.Name = "label13";
            label13.Size = new Size(94, 19);
            label13.TabIndex = 20;
            label13.Text = "Total a Pagar:";
            // 
            // txtImporte
            // 
            txtImporte.BackColor = Color.White;
            txtImporte.Location = new Point(119, 76);
            txtImporte.Margin = new Padding(3, 2, 3, 2);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(95, 21);
            txtImporte.TabIndex = 19;
            // 
            // txtIGV
            // 
            txtIGV.BackColor = Color.White;
            txtIGV.Location = new Point(119, 50);
            txtIGV.Margin = new Padding(3, 2, 3, 2);
            txtIGV.Name = "txtIGV";
            txtIGV.ReadOnly = true;
            txtIGV.Size = new Size(95, 21);
            txtIGV.TabIndex = 18;
            // 
            // txtInafecto
            // 
            txtInafecto.BackColor = Color.White;
            txtInafecto.Location = new Point(119, 25);
            txtInafecto.Margin = new Padding(3, 2, 3, 2);
            txtInafecto.Name = "txtInafecto";
            txtInafecto.ReadOnly = true;
            txtInafecto.Size = new Size(95, 21);
            txtInafecto.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(62, 56, 95);
            label12.Location = new Point(5, 76);
            label12.Name = "label12";
            label12.Size = new Size(61, 19);
            label12.TabIndex = 16;
            label12.Text = "Importe:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(62, 56, 95);
            label11.Location = new Point(5, 50);
            label11.Name = "label11";
            label11.Size = new Size(41, 19);
            label11.TabIndex = 15;
            label11.Text = "I.G.V:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(62, 56, 95);
            label10.Location = new Point(5, 25);
            label10.Name = "label10";
            label10.Size = new Size(98, 19);
            label10.TabIndex = 14;
            label10.Text = "Total Inafecto:";
            // 
            // colCodigo
            // 
            colCodigo.Text = "Código";
            colCodigo.Width = 90;
            // 
            // colProducto
            // 
            colProducto.Text = "Producto";
            colProducto.Width = 90;
            // 
            // colPrecio
            // 
            colPrecio.Text = "Precio";
            colPrecio.Width = 90;
            // 
            // colCantidad
            // 
            colCantidad.Text = "Cantidad";
            colCantidad.Width = 100;
            // 
            // colImporte
            // 
            colImporte.Text = "Importe";
            colImporte.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 596);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            ForeColor = Color.FromArgb(46, 56, 77);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private ListView dgvProductos;
        private TextBox txtRazonSocial;
        private TextBox txtNombreCompleto;
        private TextBox txtNumeroDocumento;
        private GroupBox groupBox1;
        private ComboBox mbTipoDocumento;
        private Label label9;
        private GroupBox groupBox4;
        private Label label7;
        private Label label1;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private TextBox txtCodigo;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnCalcularTotal;
        private Button btnImprimir;
        private Panel panel1;
        private GroupBox groupBox3;
        private TextBox txtVuelto;
        private TextBox txtSoles;
        private Label label15;
        private Label label14;
        private GroupBox groupBox2;
        private TextBox txtTotalPagar;
        private Label label13;
        private TextBox txtImporte;
        private TextBox txtIGV;
        private TextBox txtInafecto;
        private Label label12;
        private Label label11;
        private Label label10;
        private ColumnHeader colCodigo;
        private ColumnHeader colProducto;
        private ColumnHeader colPrecio;
        private ColumnHeader colCantidad;
        private ColumnHeader colImporte;
    }
}
