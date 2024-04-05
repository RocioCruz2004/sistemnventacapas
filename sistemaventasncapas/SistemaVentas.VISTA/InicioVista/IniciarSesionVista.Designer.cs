namespace SistemaVentas.VISTA.InicioVista
{
    partial class IniciarSesionVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionVista));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lemon Friday", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 66, 40);
            label1.Location = new Point(369, 21);
            label1.Name = "label1";
            label1.Size = new Size(275, 52);
            label1.TabIndex = 1;
            label1.Text = "INICIAR SESIÓN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(274, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(274, 178);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(348, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 24);
            textBox1.TabIndex = 4;
            textBox1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(348, 182);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(286, 24);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(217, 217, 217);
            comboBox1.Cursor = Cursors.No;
            comboBox1.Font = new Font("Century Gothic", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Cajero", "Supervisor" });
            comboBox1.Location = new Point(274, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 30);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(517, 239);
            button1.Name = "button1";
            button1.Size = new Size(166, 44);
            button1.TabIndex = 7;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IniciarSesionVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 238);
            ClientSize = new Size(698, 308);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "IniciarSesionVista";
            Text = "IniciarSesionVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
    }
}