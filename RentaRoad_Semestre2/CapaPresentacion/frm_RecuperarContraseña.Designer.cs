namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RecuperarContraseña));
            groupBox3 = new GroupBox();
            btnCorreo = new Button();
            txtCorreo = new TextBox();
            label26 = new Label();
            label1 = new Label();
            panelCorreo = new Panel();
            panelToken = new Panel();
            groupBox1 = new GroupBox();
            btnToken = new Button();
            txtToken = new TextBox();
            label2 = new Label();
            panelContraseña = new Panel();
            groupBox2 = new GroupBox();
            btnContraseña = new Button();
            txtContraseña = new TextBox();
            label3 = new Label();
            groupBox3.SuspendLayout();
            panelCorreo.SuspendLayout();
            panelToken.SuspendLayout();
            groupBox1.SuspendLayout();
            panelContraseña.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCorreo);
            groupBox3.Controls.Add(txtCorreo);
            groupBox3.Controls.Add(label26);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(48, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(440, 146);
            groupBox3.TabIndex = 88;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ingrese su correo electrónico";
            // 
            // btnCorreo
            // 
            btnCorreo.BackColor = Color.FromArgb(0, 80, 200);
            btnCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCorreo.ForeColor = Color.White;
            btnCorreo.Image = (Image)resources.GetObject("btnCorreo.Image");
            btnCorreo.ImageAlign = ContentAlignment.MiddleRight;
            btnCorreo.Location = new Point(17, 80);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Size = new Size(120, 46);
            btnCorreo.TabIndex = 76;
            btnCorreo.Text = "Enviar";
            btnCorreo.TextAlign = ContentAlignment.MiddleLeft;
            btnCorreo.UseVisualStyleBackColor = false;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(17, 40);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(395, 26);
            txtCorreo.TabIndex = 67;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(12, 45);
            label26.Name = "label26";
            label26.Size = new Size(0, 19);
            label26.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 40);
            label1.TabIndex = 87;
            label1.Text = "Recuperar contraseña";
            // 
            // panelCorreo
            // 
            panelCorreo.Controls.Add(groupBox3);
            panelCorreo.Location = new Point(1, 52);
            panelCorreo.Name = "panelCorreo";
            panelCorreo.Size = new Size(540, 288);
            panelCorreo.TabIndex = 89;
            // 
            // panelToken
            // 
            panelToken.Controls.Add(groupBox1);
            panelToken.Location = new Point(0, 49);
            panelToken.Name = "panelToken";
            panelToken.Size = new Size(540, 288);
            panelToken.TabIndex = 90;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnToken);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(48, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 146);
            groupBox1.TabIndex = 88;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese el token de recuperación";
            // 
            // btnToken
            // 
            btnToken.BackColor = Color.FromArgb(0, 80, 200);
            btnToken.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToken.ForeColor = Color.White;
            btnToken.ImageAlign = ContentAlignment.MiddleRight;
            btnToken.Location = new Point(17, 80);
            btnToken.Name = "btnToken";
            btnToken.Size = new Size(120, 46);
            btnToken.TabIndex = 76;
            btnToken.Text = "Validar";
            btnToken.UseVisualStyleBackColor = false;
            btnToken.Click += btnToken_Click;
            // 
            // txtToken
            // 
            txtToken.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToken.Location = new Point(17, 40);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(395, 26);
            txtToken.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 66;
            // 
            // panelContraseña
            // 
            panelContraseña.Controls.Add(groupBox2);
            panelContraseña.Location = new Point(0, 52);
            panelContraseña.Name = "panelContraseña";
            panelContraseña.Size = new Size(540, 288);
            panelContraseña.TabIndex = 90;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnContraseña);
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(48, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 146);
            groupBox2.TabIndex = 88;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingrese su nueva contraseña";
            // 
            // btnContraseña
            // 
            btnContraseña.BackColor = Color.FromArgb(0, 80, 200);
            btnContraseña.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContraseña.ForeColor = Color.White;
            btnContraseña.ImageAlign = ContentAlignment.MiddleRight;
            btnContraseña.Location = new Point(17, 80);
            btnContraseña.Name = "btnContraseña";
            btnContraseña.Size = new Size(120, 46);
            btnContraseña.TabIndex = 76;
            btnContraseña.Text = "Guardar";
            btnContraseña.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(17, 40);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(395, 26);
            txtContraseña.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 66;
            // 
            // frm_RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 340);
            Controls.Add(panelCorreo);
            Controls.Add(panelToken);
            Controls.Add(panelContraseña);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frm_RecuperarContraseña";
            Text = "RecuperarContraseñá";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelCorreo.ResumeLayout(false);
            panelToken.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelContraseña.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private Panel panelCorreo;
        private Panel panelToken;
        private GroupBox groupBox1;
        private Button btnToken;
        private TextBox txtToken;
        private Label label2;
        private Panel panelContraseña;
        private GroupBox groupBox2;
        private Button btnContraseña;
        private TextBox txtContraseña;
        private Label label3;
    }
}