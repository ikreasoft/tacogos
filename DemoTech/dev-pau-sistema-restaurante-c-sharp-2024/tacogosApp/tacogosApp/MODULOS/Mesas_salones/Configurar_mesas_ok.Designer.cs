namespace tacogosApp.MODULOS.Mesas_salones
{
    partial class Configurar_mesas_ok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurar_mesas_ok));
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            panel5 = new Panel();
            PanelMesas = new FlowLayoutPanel();
            PanelBienvenida = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 697);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 564);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 133);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(43, 43, 43);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBox1);
            panel4.ForeColor = Color.FromArgb(43, 43, 43);
            panel4.Location = new Point(19, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 44);
            panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(232, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(43, 43, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox1.Location = new Point(17, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 18);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 19);
            button1.Name = "button1";
            button1.Size = new Size(281, 38);
            button1.TabIndex = 0;
            button1.Text = "+ Agregar Salón";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(PanelMesas);
            panel5.Controls.Add(PanelBienvenida);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(318, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1219, 697);
            panel5.TabIndex = 1;
            // 
            // PanelMesas
            // 
            PanelMesas.BackColor = Color.Black;
            PanelMesas.Location = new Point(52, 403);
            PanelMesas.Name = "PanelMesas";
            PanelMesas.Size = new Size(623, 244);
            PanelMesas.TabIndex = 2;
            PanelMesas.Visible = false;
            PanelMesas.Paint += PanelMesas_Paint;
            // 
            // PanelBienvenida
            // 
            PanelBienvenida.BackColor = Color.Silver;
            PanelBienvenida.Dock = DockStyle.Fill;
            PanelBienvenida.Font = new Font("Segoe UI", 30F);
            PanelBienvenida.ForeColor = Color.Black;
            PanelBienvenida.Location = new Point(0, 0);
            PanelBienvenida.Name = "PanelBienvenida";
            PanelBienvenida.Size = new Size(1219, 697);
            PanelBienvenida.TabIndex = 0;
            PanelBienvenida.Text = "Elija un salon para iniciar";
            PanelBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            PanelBienvenida.Click += label1_Click;
            // 
            // Configurar_mesas_ok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1537, 697);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Configurar_mesas_ok";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar_mesas_ok";
            WindowState = FormWindowState.Maximized;
            Load += Configurar_mesas_ok_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel5;
        private Label PanelBienvenida;
        private FlowLayoutPanel PanelMesas;
    }
}