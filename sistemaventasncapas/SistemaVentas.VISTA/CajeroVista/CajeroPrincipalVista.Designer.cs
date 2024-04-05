namespace SistemaVentas.VISTA.CajeroVista
{
    partial class CajeroPrincipalVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajeroPrincipalVista));
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCerrarSesion = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lemon Friday", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(36, 66, 40);
            label1.Location = new Point(153, 48);
            label1.Name = "label1";
            label1.Size = new Size(183, 52);
            label1.TabIndex = 2;
            label1.Text = "\"AHISITO\"";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(131, 8);
            label2.Name = "label2";
            label2.Size = new Size(242, 40);
            label2.TabIndex = 3;
            label2.Text = "SUPERMERCADO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(408, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(254, 248, 238);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(522, 150);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(254, 248, 238);
            button1.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(166, 279);
            button1.Name = "button1";
            button1.Size = new Size(120, 72);
            button1.TabIndex = 9;
            button1.Text = "EDITAR\r\nVENTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 248, 238);
            button2.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(36, 66, 40);
            button2.Location = new Point(292, 279);
            button2.Name = "button2";
            button2.Size = new Size(112, 72);
            button2.TabIndex = 10;
            button2.Text = "NUEVA\r\nVENTA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(254, 248, 238);
            button3.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(36, 66, 40);
            button3.Location = new Point(410, 279);
            button3.Name = "button3";
            button3.Size = new Size(111, 72);
            button3.TabIndex = 11;
            button3.Text = "ELIMINAR VENTA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(36, 66, 40);
            btnCerrarSesion.Location = new Point(32, 24);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(59, 59);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(254, 248, 238);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 306);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(134, 24);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.Location = new Point(8, 279);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 8;
            label3.Text = "Cajero/a:";
            // 
            // CajeroPrincipalVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 194, 180);
            ClientSize = new Size(546, 370);
            Controls.Add(btnCerrarSesion);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CajeroPrincipalVista";
            Text = "CajeroPrincipalVista";
            Load += CajeroPrincipalVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCerrarSesion;
        private TextBox textBox1;
        private Label label3;
    }
}