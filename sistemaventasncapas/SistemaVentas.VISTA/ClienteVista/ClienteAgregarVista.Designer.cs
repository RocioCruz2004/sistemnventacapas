namespace SistemaVentas.VISTA.ClienteVista
{
    partial class ClienteAgregarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteAgregarVista));
            btnCerrarSesion = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(36, 66, 40);
            btnCerrarSesion.Location = new Point(15, 20);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(50, 51);
            btnCerrarSesion.TabIndex = 30;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(229, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(79, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 72);
            label2.TabIndex = 28;
            label2.Text = "AGREGAR\r\nCLIENTE";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(224, 94);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 33;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 101);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 32;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(82, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 24);
            textBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 137);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 34;
            label1.Text = "TipoCliente:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(217, 217, 217);
            comboBox1.Font = new Font("Century Gothic", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ocasional", "Regular", "Frecuente" });
            comboBox1.Location = new Point(95, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 174);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 36;
            label4.Text = "Código:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(73, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 24);
            textBox2.TabIndex = 37;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(36, 66, 40);
            button4.Location = new Point(72, 213);
            button4.Name = "button4";
            button4.Size = new Size(157, 33);
            button4.TabIndex = 41;
            button4.Text = "GUARDAR CAMBIOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ClienteAgregarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 194, 180);
            ClientSize = new Size(318, 260);
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
            Name = "ClienteAgregarVista";
            Text = "ClienteAgregarVista";
            Load += ClienteAgregarVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarSesion;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button4;
    }
}