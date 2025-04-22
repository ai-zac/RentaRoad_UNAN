namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_NuevoColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevoColor));
            label31 = new Label();
            textBox1 = new TextBox();
            btnGuardarColor = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(61, 46);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(173, 32);
            label31.TabIndex = 96;
            label31.Text = "Nuevo color";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(119, 95);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 22);
            textBox1.TabIndex = 95;
            // 
            // btnGuardarColor
            // 
            btnGuardarColor.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarColor.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarColor.ForeColor = Color.White;
            btnGuardarColor.Image = (Image)resources.GetObject("btnGuardarColor.Image");
            btnGuardarColor.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarColor.Location = new Point(61, 132);
            btnGuardarColor.Margin = new Padding(2);
            btnGuardarColor.Name = "btnGuardarColor";
            btnGuardarColor.Size = new Size(114, 39);
            btnGuardarColor.TabIndex = 94;
            btnGuardarColor.Text = "Guardar";
            btnGuardarColor.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarColor.UseVisualStyleBackColor = false;
            btnGuardarColor.Click += btnGuardarColor_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(61, 97);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 93;
            label10.Text = "Color:";
            // 
            // frm_NuevoColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 221);
            Controls.Add(label31);
            Controls.Add(textBox1);
            Controls.Add(btnGuardarColor);
            Controls.Add(label10);
            Name = "frm_NuevoColor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo color";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label31;
        private TextBox textBox1;
        private Button btnGuardarColor;
        private Label label10;
    }
}