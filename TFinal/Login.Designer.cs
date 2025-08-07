namespace TFinal
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtClave = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(380, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(295, 295);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-244, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(754, 803);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 56, 95);
            label1.Location = new Point(380, 359);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 23;
            label1.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(62, 56, 95);
            txtUsuario.Location = new Point(380, 393);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(295, 34);
            txtUsuario.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 56, 95);
            label2.Location = new Point(380, 477);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 25;
            label2.Text = "CONTRASEÑA";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.FromArgb(62, 56, 95);
            txtClave.Location = new Point(380, 511);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(295, 34);
            txtClave.TabIndex = 26;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(62, 56, 95);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(62, 56, 95);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(228, 218, 252);
            btnLogin.Location = new Point(440, 588);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 56);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 738);
            Controls.Add(btnLogin);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtClave;
        private Button btnLogin;
    }
}