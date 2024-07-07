namespace tacogosApp.MODULOS.Mesas_salones
{
    partial class Salones
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
            Salon = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            volverSalones = new Button();
            guardarSalones = new Button();
            panel2 = new Panel();
            cerrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Salon
            // 
            Salon.AutoSize = true;
            Salon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Salon.ForeColor = Color.White;
            Salon.Location = new Point(37, 39);
            Salon.Name = "Salon";
            Salon.Size = new Size(197, 37);
            Salon.TabIndex = 0;
            Salon.Text = "Agregar salon";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 31, 31);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(18, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 36);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(volverSalones);
            panel1.Controls.Add(guardarSalones);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(37, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 317);
            panel1.TabIndex = 2;
            // 
            // volverSalones
            // 
            volverSalones.BackColor = Color.Gray;
            volverSalones.FlatAppearance.BorderSize = 0;
            volverSalones.FlatStyle = FlatStyle.Flat;
            volverSalones.Font = new Font("Segoe UI", 12F);
            volverSalones.ForeColor = Color.Black;
            volverSalones.Location = new Point(89, 190);
            volverSalones.Name = "volverSalones";
            volverSalones.Size = new Size(157, 37);
            volverSalones.TabIndex = 2;
            volverSalones.Text = "Volver";
            volverSalones.UseVisualStyleBackColor = false;
            // 
            // guardarSalones
            // 
            guardarSalones.BackColor = Color.DarkGreen;
            guardarSalones.Cursor = Cursors.Hand;
            guardarSalones.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            guardarSalones.FlatAppearance.BorderSize = 0;
            guardarSalones.FlatStyle = FlatStyle.Flat;
            guardarSalones.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            guardarSalones.ForeColor = Color.White;
            guardarSalones.Location = new Point(312, 180);
            guardarSalones.Name = "guardarSalones";
            guardarSalones.Size = new Size(184, 52);
            guardarSalones.TabIndex = 1;
            guardarSalones.Text = "Guardar";
            guardarSalones.UseVisualStyleBackColor = false;
            guardarSalones.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(18, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 1);
            panel2.TabIndex = 0;
            // 
            // cerrar
            // 
            cerrar.BackColor = Color.Red;
            cerrar.Cursor = Cursors.Hand;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            cerrar.ForeColor = Color.White;
            cerrar.Location = new Point(552, 39);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(42, 42);
            cerrar.TabIndex = 3;
            cerrar.Text = "X";
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += button3_Click;
            // 
            // Salones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(628, 452);
            Controls.Add(cerrar);
            Controls.Add(panel1);
            Controls.Add(Salon);
            ForeColor = Color.FromArgb(31, 31, 31);
            Name = "Salones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salones";
            Load += Salones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Salon;
        private TextBox textBox1;
        private Panel panel1;
        private Button volverSalones;
        private Button guardarSalones;
        private Panel panel2;
        private Button cerrar;
    }
}