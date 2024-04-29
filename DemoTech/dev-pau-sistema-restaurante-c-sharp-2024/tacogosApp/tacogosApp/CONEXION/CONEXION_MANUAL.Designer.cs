namespace tacogosApp.CONEXION
{
    partial class CONEXION_MANUAL
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
            label1 = new Label();
            label2 = new Label();
            txtCnString = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(335, 21);
            label1.TabIndex = 0;
            label1.Text = "INGRESE LA CADENA DE CONEXION LOCAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 7F);
            label2.Location = new Point(41, 56);
            label2.Name = "label2";
            label2.Size = new Size(597, 32);
            label2.TabIndex = 1;
            label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexión\", se creara un Archivo que contendrá tu conexión Encriptada. \r\nAhora tu conexióon es más segura ante posibles hackers.";
            label2.Click += label2_Click;
            // 
            // txtCnString
            // 
            txtCnString.BorderStyle = BorderStyle.FixedSingle;
            txtCnString.Font = new Font("Segoe UI", 12F);
            txtCnString.Location = new Point(41, 101);
            txtCnString.Multiline = true;
            txtCnString.Name = "txtCnString";
            txtCnString.Size = new Size(597, 59);
            txtCnString.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.ForestGreen;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 165);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(313, 35);
            button1.TabIndex = 3;
            button1.Tag = "btn-cadena-conexion";
            button1.Text = "Generar cadena de conexion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CONEXION_MANUAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(676, 217);
            Controls.Add(button1);
            Controls.Add(txtCnString);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CONEXION_MANUAL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexion manual";
            Load += CONEXION_MANUAL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCnString;
        private Button button1;
    }
}