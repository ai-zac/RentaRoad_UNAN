namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_PagoTarjetaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PagoTarjetaCredito));
            label31 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(39, 33);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(336, 80);
            label31.TabIndex = 88;
            label31.Text = "Pago con tarjeta\r\nde crédito o débito";
            label31.Click += label31_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 44;
            label1.Text = "Nombre del titular";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(213, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 26);
            textBox1.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 54);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 89;
            label2.Text = "Número de tarjeta";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(213, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 26);
            textBox2.TabIndex = 90;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 166);
            label3.Name = "label3";
            label3.Size = new Size(182, 22);
            label3.TabIndex = 91;
            label3.Text = "Fecha de vigencia ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 218);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 93;
            label4.Text = "Código CVV";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(213, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 26);
            textBox4.TabIndex = 94;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(52, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 305);
            groupBox1.TabIndex = 88;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la tarjeta";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(213, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 26);
            textBox3.TabIndex = 92;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(259, 485);
            button3.Name = "button3";
            button3.Size = new Size(128, 59);
            button3.TabIndex = 89;
            button3.Text = "Pagar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // FormularioPagoTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 573);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label31);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormularioPagoTarjetaCredito";
            Text = "Pago con tarjeta de crédito/débito";
            Load += FormularioPagoTarjetaCredito_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private TextBox textBox3;
    }
}