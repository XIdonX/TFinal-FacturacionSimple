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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(62, 56, 95);
            textBox1.Location = new Point(380, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 34);
            textBox1.TabIndex = 24;
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
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(62, 56, 95);
            textBox2.Location = new Point(380, 511);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 34);
            textBox2.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 56, 95);
            button1.FlatAppearance.BorderColor = Color.FromArgb(62, 56, 95);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 45, 120);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 45, 120);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(228, 218, 252);
            button1.Location = new Point(477, 579);
            button1.Name = "button1";
            button1.Size = new Size(142, 56);
            button1.TabIndex = 27;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 738);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}