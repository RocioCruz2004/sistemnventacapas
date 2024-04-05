namespace SistemaVentas.VISTA.VentaVista
{
    partial class EscogerProductoVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscogerProductoVista));
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 96);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 31;
            label3.Text = "Producto:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(94, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 24);
            textBox1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(387, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(125, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 72);
            label2.TabIndex = 32;
            label2.Text = "ESCOGER\r\nPRODUCTO";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(325, 87);
            button1.Name = "button1";
            button1.Size = new Size(61, 33);
            button1.TabIndex = 35;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(254, 194, 180);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(455, 150);
            dataGridView1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 292);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 37;
            label1.Text = "Cantidad:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(86, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(39, 24);
            textBox2.TabIndex = 39;
            textBox2.Text = "0";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.DialogResult = DialogResult.OK;
            button3.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(36, 66, 40);
            button3.Location = new Point(362, 288);
            button3.Name = "button3";
            button3.Size = new Size(87, 33);
            button3.TabIndex = 41;
            button3.Text = "Seleccionar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(217, 217, 217);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(255, 295);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 24);
            textBox3.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 296);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 42;
            label4.Text = "Precio:";
            // 
            // EscogerProductoVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 238);
            ClientSize = new Size(480, 337);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "EscogerProductoVista";
            Text = "EscogerProductoVista";
            Load += EscogerProductoVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
    }
}