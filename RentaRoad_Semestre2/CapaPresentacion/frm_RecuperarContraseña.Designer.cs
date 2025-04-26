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
            btnReenviar = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnToken = new Button();
            txtToken = new TextBox();
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
            groupBox3.Location = new Point(42, 56);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(385, 110);
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
            btnCorreo.Location = new Point(15, 60);
            btnCorreo.Margin = new Padding(3, 2, 3, 2);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Size = new Size(105, 34);
            btnCorreo.TabIndex = 76;
            btnCorreo.Text = "Enviar";
            btnCorreo.TextAlign = ContentAlignment.MiddleLeft;
            btnCorreo.UseVisualStyleBackColor = false;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(15, 30);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(346, 22);
            txtCorreo.TabIndex = 67;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(10, 34);
            label26.Name = "label26";
            label26.Size = new Size(252, 16);
            label26.TabIndex = 66;
            label26.Text = "1 minuto limite para ingresar el token";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 32);
            label1.TabIndex = 87;
            label1.Text = "Recuperar contraseña";
            // 
            // panelCorreo
            // 
            panelCorreo.Controls.Add(groupBox3);
            panelCorreo.Location = new Point(1, 39);
            panelCorreo.Margin = new Padding(3, 2, 3, 2);
            panelCorreo.Name = "panelCorreo";
            panelCorreo.Size = new Size(472, 216);
            panelCorreo.TabIndex = 89;
            // 
            // panelToken
            // 
            panelToken.Controls.Add(btnReenviar);
            panelToken.Controls.Add(label2);
            panelToken.Controls.Add(groupBox1);
            panelToken.Location = new Point(0, 37);
            panelToken.Margin = new Padding(3, 2, 3, 2);
            panelToken.Name = "panelToken";
            panelToken.Size = new Size(472, 216);
            panelToken.TabIndex = 90;
            // 
            // btnReenviar
            // 
            btnReenviar.BackColor = Color.FromArgb(0, 80, 200);
            btnReenviar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReenviar.ForeColor = Color.White;
            btnReenviar.ImageAlign = ContentAlignment.MiddleRight;
            btnReenviar.Location = new Point(11, 10);
            btnReenviar.Margin = new Padding(3, 2, 3, 2);
            btnReenviar.Name = "btnReenviar";
            btnReenviar.Size = new Size(125, 34);
            btnReenviar.TabIndex = 77;
            btnReenviar.Text = "Reenviar correo";
            btnReenviar.UseVisualStyleBackColor = false;
            btnReenviar.Click += btnReenviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 170);
            label2.Name = "label2";
            label2.Size = new Size(260, 16);
            label2.TabIndex = 66;
            label2.Text = "*Limite 1 minuto para ingresar el token";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnToken);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 56);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(385, 110);
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
            btnToken.Location = new Point(15, 60);
            btnToken.Margin = new Padding(3, 2, 3, 2);
            btnToken.Name = "btnToken";
            btnToken.Size = new Size(105, 34);
            btnToken.TabIndex = 76;
            btnToken.Text = "Validar";
            btnToken.UseVisualStyleBackColor = false;
            btnToken.Click += btnToken_Click;
            // 
            // txtToken
            // 
            txtToken.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToken.Location = new Point(15, 30);
            txtToken.Margin = new Padding(3, 2, 3, 2);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(346, 22);
            txtToken.TabIndex = 67;
            // 
            // panelContraseña
            // 
            panelContraseña.Controls.Add(groupBox2);
            panelContraseña.Location = new Point(0, 39);
            panelContraseña.Margin = new Padding(3, 2, 3, 2);
            panelContraseña.Name = "panelContraseña";
            panelContraseña.Size = new Size(472, 216);
            panelContraseña.TabIndex = 90;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnContraseña);
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(42, 56);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(385, 110);
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
            btnContraseña.Location = new Point(15, 60);
            btnContraseña.Margin = new Padding(3, 2, 3, 2);
            btnContraseña.Name = "btnContraseña";
            btnContraseña.Size = new Size(105, 34);
            btnContraseña.TabIndex = 76;
            btnContraseña.Text = "Guardar";
            btnContraseña.UseVisualStyleBackColor = false;
            btnContraseña.Click += btnContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(15, 30);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(346, 22);
            txtContraseña.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 34);
            label3.Name = "label3";
            label3.Size = new Size(0, 16);
            label3.TabIndex = 66;
            // 
            // frm_RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 255);
            Controls.Add(panelCorreo);
            Controls.Add(panelToken);
            Controls.Add(panelContraseña);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frm_RecuperarContraseña";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecuperarContraseña";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelCorreo.ResumeLayout(false);
            panelToken.ResumeLayout(false);
            panelToken.PerformLayout();
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
        private Button btnReenviar;
    }
}