namespace RentaRoad_Semestre3.Formularios
{
    partial class Adquisiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adquisiciones));
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label14 = new Label();
            textBox10 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            comboBox6 = new ComboBox();
            button5 = new Button();
            label11 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            comboBox5 = new ComboBox();
            label12 = new Label();
            label2 = new Label();
            label15 = new Label();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            eliminarFila = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 74);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(690, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de adquisición";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(158, 24);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(61, 25);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 28);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 4;
            label3.Text = "No. adquisición:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 9F);
            dateTimePicker1.Location = new Point(384, 24);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 22);
            dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 28);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 1;
            label1.Text = "Fecha de pedido:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 20);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(195, 32);
            label10.TabIndex = 67;
            label10.Text = "Adquisiciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(302, 32);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 12;
            label8.Text = "Modelo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(21, 32);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 13;
            label9.Text = "Marca:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(21, 136);
            label14.Name = "label14";
            label14.Size = new Size(115, 17);
            label14.TabIndex = 18;
            label14.Text = "Precio de renta:";
            label14.Click += label14_Click;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(153, 134);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(96, 22);
            textBox10.TabIndex = 25;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(574, 510);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 52;
            label5.Text = "Total:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(648, 510);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(96, 22);
            textBox4.TabIndex = 53;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(35, 285);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(710, 188);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paquete de autos";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(91, 66);
            comboBox6.Margin = new Padding(3, 2, 3, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(96, 25);
            comboBox6.TabIndex = 79;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 80, 200);
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(561, 93);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(99, 34);
            button5.TabIndex = 88;
            button5.Text = "Añadir";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(295, 69);
            label11.Name = "label11";
            label11.Size = new Size(95, 17);
            label11.TabIndex = 76;
            label11.Text = "No. Asientos:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(402, 66);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(52, 22);
            textBox7.TabIndex = 77;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(21, 69);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 74;
            label7.Text = "Color:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Century Gothic", 9F);
            numericUpDown2.Location = new Point(108, 99);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 22);
            numericUpDown2.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 104);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 72;
            label6.Text = "Cantidad:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(382, 28);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(273, 25);
            comboBox3.TabIndex = 70;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(91, 28);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 25);
            comboBox2.TabIndex = 69;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Subtotal, eliminarFila });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 550);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(777, 323);
            dataGridView1.TabIndex = 84;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(comboBox5);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label15);
            groupBox4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(36, 151);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(710, 113);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos del proveedor";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 68);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 27);
            textBox5.TabIndex = 83;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 29);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 82;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(532, 32);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 25);
            comboBox5.TabIndex = 81;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(449, 34);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(70, 17);
            label12.TabIndex = 80;
            label12.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(95, 17);
            label2.TabIndex = 63;
            label2.Text = "Código RUC:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(17, 34);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(142, 17);
            label15.TabIndex = 2;
            label15.Text = "Nombre completo: ";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 80, 200);
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(34, 506);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(113, 34);
            button3.TabIndex = 86;
            button3.Text = "Guardar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 81, 200);
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(262, 22);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(157, 34);
            button2.TabIndex = 85;
            button2.Text = "Nuevo pedido";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 80, 200);
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(157, 506);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(129, 34);
            button4.TabIndex = 87;
            button4.Text = "Cancelar";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Marca";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Modelo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Color";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad de autos";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio de renta";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // eliminarFila
            // 
            eliminarFila.HeaderText = "Eliminar";
            eliminarFila.MinimumWidth = 6;
            eliminarFila.Name = "eliminarFila";
            // 
            // Adquisiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 873);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Adquisiciones";
            Text = "Adquisiciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn eliminarFila;
    }
}