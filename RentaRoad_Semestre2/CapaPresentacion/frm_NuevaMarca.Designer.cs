namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_NuevaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevaMarca));
            label31 = new Label();
            textBox1 = new TextBox();
            btnGuardarMarca = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(58, 43);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(195, 32);
            label31.TabIndex = 100;
            label31.Text = "Nueva marca";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(125, 92);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 22);
            textBox1.TabIndex = 99;
            // 
            // btnGuardarMarca
            // 
            btnGuardarMarca.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarMarca.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarMarca.ForeColor = Color.White;
            btnGuardarMarca.Image = (Image)resources.GetObject("btnGuardarMarca.Image");
            btnGuardarMarca.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarMarca.Location = new Point(58, 129);
            btnGuardarMarca.Margin = new Padding(2);
            btnGuardarMarca.Name = "btnGuardarMarca";
            btnGuardarMarca.Size = new Size(114, 39);
            btnGuardarMarca.TabIndex = 98;
            btnGuardarMarca.Text = "Guardar";
            btnGuardarMarca.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarMarca.UseVisualStyleBackColor = false;
            btnGuardarMarca.Click += btnGuardarMarca_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(58, 94);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 19);
            label10.TabIndex = 97;
            label10.Text = "Marca:";
            // 
            // frm_NuevaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 221);
            Controls.Add(label31);
            Controls.Add(textBox1);
            Controls.Add(btnGuardarMarca);
            Controls.Add(label10);
            Name = "frm_NuevaMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva marca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label31;
        private TextBox textBox1;
        private Button btnGuardarMarca;
        private Label label10;
    }
}