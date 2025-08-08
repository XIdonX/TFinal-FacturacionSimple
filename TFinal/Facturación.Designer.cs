namespace TFinal
{
    partial class Facturación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturación));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtRazon = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            groupBox1 = new GroupBox();
            cbTipoDoc = new ComboBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            txtCodigo = new TextBox();
            label7 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            btnCalcularTotal = new Button();
            btnImprimir = new Button();
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
            dgvProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 56, 95);
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(62, 56, 95);
            label3.Location = new Point(6, 139);
            label3.Name = "label3";
            label3.Size = new Size(196, 23);
            label3.TabIndex = 2;
            label3.Text = "Número de Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(62, 56, 95);
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 3;
            label4.Text = "Razón Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(62, 56, 95);
            label5.Location = new Point(6, 101);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 4;
            label5.Text = "Nombre Completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(62, 56, 95);
            label6.Location = new Point(6, 60);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 5;
            label6.Text = "Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(62, 56, 95);
            label8.Location = new Point(6, 95);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 7;
            label8.Text = "Precio:";
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(127, 61);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(297, 25);
            txtRazon.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 25);
            txtNombre.TabIndex = 11;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(215, 139);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(209, 25);
            txtDocumento.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(cbTipoDoc);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRazon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(46, 56, 77);
            groupBox1.Location = new Point(138, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 180);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Cliente";
            // 
            // cbTipoDoc
            // 
            cbTipoDoc.FlatStyle = FlatStyle.System;
            cbTipoDoc.FormattingEnabled = true;
            cbTipoDoc.Items.AddRange(new object[] { "DNI", "RUC" });
            cbTipoDoc.Location = new Point(186, 31);
            cbTipoDoc.Name = "cbTipoDoc";
            cbTipoDoc.Size = new Size(127, 25);
            cbTipoDoc.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(62, 56, 95);
            label9.Location = new Point(6, 27);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
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
            groupBox4.Location = new Point(138, 242);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(297, 165);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(112, 123);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(167, 25);
            txtCantidad.TabIndex = 20;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(112, 91);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(167, 25);
            txtPrecio.TabIndex = 19;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(112, 59);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(167, 25);
            txtProducto.TabIndex = 18;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(112, 24);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 25);
            txtCodigo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(62, 56, 95);
            label7.Location = new Point(6, 124);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 16;
            label7.Text = "Cantidad:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(84, 76, 133);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(84, 76, 133);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(455, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 40);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(84, 76, 133);
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(84, 76, 133);
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(455, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 40);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "+Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.BackColor = Color.FromArgb(84, 76, 133);
            btnCalcularTotal.FlatAppearance.BorderColor = Color.FromArgb(84, 76, 133);
            btnCalcularTotal.FlatAppearance.BorderSize = 2;
            btnCalcularTotal.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            btnCalcularTotal.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            btnCalcularTotal.FlatStyle = FlatStyle.Flat;
            btnCalcularTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularTotal.ForeColor = Color.White;
            btnCalcularTotal.Location = new Point(508, 665);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(155, 49);
            btnCalcularTotal.TabIndex = 21;
            btnCalcularTotal.Text = "Calcular Total";
            btnCalcularTotal.UseVisualStyleBackColor = false;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(84, 76, 133);
            btnImprimir.FlatAppearance.BorderColor = Color.FromArgb(84, 76, 133);
            btnImprimir.FlatAppearance.BorderSize = 2;
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(683, 665);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(174, 49);
            btnImprimir.TabIndex = 22;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtVuelto);
            groupBox3.Controls.Add(txtSoles);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(587, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(270, 107);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Importe Cliente:";
            // 
            // txtVuelto
            // 
            txtVuelto.BackColor = Color.White;
            txtVuelto.Location = new Point(96, 68);
            txtVuelto.Name = "txtVuelto";
            txtVuelto.ReadOnly = true;
            txtVuelto.Size = new Size(142, 25);
            txtVuelto.TabIndex = 25;
            // 
            // txtSoles
            // 
            txtSoles.Location = new Point(96, 31);
            txtSoles.Name = "txtSoles";
            txtSoles.Size = new Size(142, 25);
            txtSoles.TabIndex = 24;
            txtSoles.KeyDown += txtSoles_KeyDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(62, 56, 95);
            label15.Location = new Point(13, 72);
            label15.Name = "label15";
            label15.Size = new Size(63, 23);
            label15.TabIndex = 23;
            label15.Text = "Vuelto:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(62, 56, 95);
            label14.Location = new Point(24, 35);
            label14.Name = "label14";
            label14.Size = new Size(53, 23);
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
            groupBox2.Location = new Point(587, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 197);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Montos Totales";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BackColor = Color.White;
            txtTotalPagar.Location = new Point(136, 155);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.ReadOnly = true;
            txtTotalPagar.Size = new Size(108, 25);
            txtTotalPagar.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(62, 56, 95);
            label13.Location = new Point(6, 157);
            label13.Name = "label13";
            label13.Size = new Size(114, 23);
            label13.TabIndex = 20;
            label13.Text = "Total a Pagar:";
            // 
            // txtImporte
            // 
            txtImporte.BackColor = Color.White;
            txtImporte.Location = new Point(136, 101);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(108, 25);
            txtImporte.TabIndex = 19;
            // 
            // txtIGV
            // 
            txtIGV.BackColor = Color.White;
            txtIGV.Location = new Point(136, 67);
            txtIGV.Name = "txtIGV";
            txtIGV.ReadOnly = true;
            txtIGV.Size = new Size(108, 25);
            txtIGV.TabIndex = 18;
            // 
            // txtInafecto
            // 
            txtInafecto.BackColor = Color.White;
            txtInafecto.Location = new Point(136, 33);
            txtInafecto.Name = "txtInafecto";
            txtInafecto.ReadOnly = true;
            txtInafecto.Size = new Size(108, 25);
            txtInafecto.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(62, 56, 95);
            label12.Location = new Point(6, 101);
            label12.Name = "label12";
            label12.Size = new Size(116, 23);
            label12.TabIndex = 16;
            label12.Text = "Importe Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(62, 56, 95);
            label11.Location = new Point(6, 67);
            label11.Name = "label11";
            label11.Size = new Size(50, 23);
            label11.TabIndex = 15;
            label11.Text = "I.G.V:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(62, 56, 95);
            label10.Location = new Point(6, 33);
            label10.Name = "label10";
            label10.Size = new Size(118, 23);
            label10.TabIndex = 14;
            label10.Text = "Total Inafecto:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colPrecio, colCantidad, colImporte });
            dgvProductos.GridColor = Color.FromArgb(84, 76, 133);
            dgvProductos.Location = new Point(138, 434);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(719, 188);
            dgvProductos.TabIndex = 24;
            dgvProductos.KeyDown += dgvProductos_KeyDown;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colImporte
            // 
            colImporte.HeaderText = "Importe";
            colImporte.MinimumWidth = 6;
            colImporte.Name = "colImporte";
            colImporte.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(806, 818);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(62, 56, 95);
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(70, 45, 120);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(62, 56, 95);
            dateTimePicker1.Location = new Point(138, 643);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // Facturación
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(889, 774);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvProductos);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnImprimir);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(46, 56, 77);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Facturación";
            Text = "Form1";
            FormClosed += Facturación_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtRazon;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private GroupBox groupBox1;
        private ComboBox cbTipoDoc;
        private Label label9;
        private GroupBox groupBox4;
        private Label label7;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private TextBox txtCodigo;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnCalcularTotal;
        private Button btnImprimir;
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
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colImporte;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}
