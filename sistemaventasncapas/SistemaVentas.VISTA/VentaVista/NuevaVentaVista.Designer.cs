namespace SistemaVentas.VISTA.VentaVista
{
    partial class NuevaVentaVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaVentaVista));
            btnCerrarSesion = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(36, 66, 40);
            btnCerrarSesion.Location = new Point(30, 20);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(50, 51);
            btnCerrarSesion.TabIndex = 16;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(244, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(116, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 72);
            label2.TabIndex = 14;
            label2.Text = "NUEVA\r\nVENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 18;
            label3.Text = "Cliente:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(89, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 24);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 20;
            label1.Text = "Cajero/a:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(89, 137);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(134, 24);
            textBox2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 21;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(217, 217, 217);
            dateTimePicker1.Location = new Point(89, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(231, 100);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 23;
            button1.Text = "Seleccionar";
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
            dataGridView1.Location = new Point(10, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(335, 150);
            dataGridView1.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(254, 194, 180);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(268, 352);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(77, 24);
            textBox3.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(218, 355);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 26;
            label5.Text = "TOTAL:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(36, 66, 40);
            button3.Location = new Point(142, 388);
            button3.Name = "button3";
            button3.Size = new Size(73, 33);
            button3.TabIndex = 28;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(36, 66, 40);
            button4.Location = new Point(221, 388);
            button4.Name = "button4";
            button4.Size = new Size(87, 33);
            button4.TabIndex = 29;
            button4.Text = "GUARDAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(217, 217, 217);
            button5.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(36, 66, 40);
            button5.Location = new Point(37, 388);
            button5.Name = "button5";
            button5.Size = new Size(99, 33);
            button5.TabIndex = 30;
            button5.Text = "PRODUCTOS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // NuevaVentaVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 238);
            ClientSize = new Size(359, 436);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Name = "NuevaVentaVista";
            Text = "NUEVA VENTA";
            Load += NuevaVentaVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarSesion;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label5;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}