namespace SistemaVentas.VISTA.ClienteVista
{
    partial class ClienteEditarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteEditarVista));
            button4 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            btnCerrarSesion = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(36, 66, 40);
            button4.Location = new Point(80, 213);
            button4.Name = "button4";
            button4.Size = new Size(157, 33);
            button4.TabIndex = 52;
            button4.Text = "GUARDAR CAMBIOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(81, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 24);
            textBox2.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 174);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 50;
            label4.Text = "Código:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(217, 217, 217);
            comboBox1.Font = new Font("Century Gothic", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ocasional", "Regular", "Frecuente" });
            comboBox1.Location = new Point(103, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 137);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 48;
            label1.Text = "TipoCliente:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(232, 94);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 47;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 101);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 46;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(90, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 24);
            textBox1.TabIndex = 45;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(36, 66, 40);
            btnCerrarSesion.Location = new Point(23, 20);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(50, 51);
            btnCerrarSesion.TabIndex = 44;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(237, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(100, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 72);
            label2.TabIndex = 42;
            label2.Text = "EDITAR\nCLIENTE";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 194, 180);
            ClientSize = new Size(331, 257);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Button btnCerrarSesion;
        private PictureBox pictureBox2;
        private Label label2;
    }
}