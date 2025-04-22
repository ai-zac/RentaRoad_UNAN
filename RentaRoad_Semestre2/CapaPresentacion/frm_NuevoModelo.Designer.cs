namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_NuevoModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevoModelo));
            label31 = new Label();
            textBox1 = new TextBox();
            btnGuardarModelo = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(58, 46);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(207, 32);
            label31.TabIndex = 100;
            label31.Text = "Nuevo modelo";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(133, 95);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 22);
            textBox1.TabIndex = 99;
            // 
            // btnGuardarModelo
            // 
            btnGuardarModelo.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarModelo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarModelo.ForeColor = Color.White;
            btnGuardarModelo.Image = (Image)resources.GetObject("btnGuardarModelo.Image");
            btnGuardarModelo.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarModelo.Location = new Point(58, 132);
            btnGuardarModelo.Margin = new Padding(2);
            btnGuardarModelo.Name = "btnGuardarModelo";
            btnGuardarModelo.Size = new Size(114, 39);
            btnGuardarModelo.TabIndex = 98;
            btnGuardarModelo.Text = "Guardar";
            btnGuardarModelo.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarModelo.UseVisualStyleBackColor = false;
            btnGuardarModelo.Click += btnGuardarModelo_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(58, 97);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 19);
            label10.TabIndex = 97;
            label10.Text = "Modelo:";
            // 
            // frm_NuevoModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 221);
            Controls.Add(label31);
            Controls.Add(textBox1);
            Controls.Add(btnGuardarModelo);
            Controls.Add(label10);
            Name = "frm_NuevoModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo modelo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label31;
        private TextBox textBox1;
        private Button btnGuardarModelo;
        private Label label10;
    }
}