namespace SistemaVentas.VISTA.PersonaVista
{
    partial class PersonaListarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaListarVista));
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            btnCerrarSesion = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 66, 40);
            button1.Location = new Point(14, 253);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 55;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(36, 66, 40);
            button4.Location = new Point(249, 253);
            button4.Name = "button4";
            button4.Size = new Size(87, 33);
            button4.TabIndex = 54;
            button4.Text = "Seleccionar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(36, 66, 40);
            button3.Location = new Point(107, 253);
            button3.Name = "button3";
            button3.Size = new Size(70, 33);
            button3.TabIndex = 53;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Font = new Font("Lemon Friday", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(36, 66, 40);
            button2.Location = new Point(183, 253);
            button2.Name = "button2";
            button2.Size = new Size(60, 33);
            button2.TabIndex = 52;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(254, 194, 180);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(292, 150);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Font = new Font("Lemon Friday", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.FromArgb(36, 66, 40);
            btnCerrarSesion.Location = new Point(21, 15);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(50, 51);
            btnCerrarSesion.TabIndex = 50;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(249, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lemon Friday", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(36, 66, 40);
            label2.Location = new Point(94, 20);
            label2.Name = "label2";
            label2.Size = new Size(146, 36);
            label2.TabIndex = 48;
            label2.Text = "PERSONAS";
            // 
            // PersonaListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 248, 238);
            ClientSize = new Size(344, 307);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Name = "PersonaListarVista";
            Text = "PersonaListarVista";
            Load += PersonaListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Button btnCerrarSesion;
        private PictureBox pictureBox2;
        private Label label2;
    }
}