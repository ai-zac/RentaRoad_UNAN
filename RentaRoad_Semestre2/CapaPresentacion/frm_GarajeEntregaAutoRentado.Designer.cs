namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_GarajeEntregaAutoRentado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GarajeEntregaAutoRentado));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnBuscarContrato = new Button();
            groupBox7 = new GroupBox();
            txtCantidadMulta = new TextBox();
            label2 = new Label();
            txtAtrasoDias = new TextBox();
            label13 = new Label();
            txtCantidadDias = new TextBox();
            label26 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label27 = new Label();
            label28 = new Label();
            groupBox6 = new GroupBox();
            txtPlaca = new TextBox();
            button3 = new Button();
            button8 = new Button();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            label20 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button5 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            descripcion = new DataGridViewTextBoxColumn();
            costoDaño = new DataGridViewTextBoxColumn();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            chbNecesitaMantenimiento = new CheckBox();
            txtColor = new TextBox();
            label3 = new Label();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarContrato
            // 
            btnBuscarContrato.Anchor = AnchorStyles.None;
            btnBuscarContrato.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarContrato.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarContrato.ForeColor = Color.White;
            btnBuscarContrato.Image = (Image)resources.GetObject("btnBuscarContrato.Image");
            btnBuscarContrato.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarContrato.Location = new Point(378, 65);
            btnBuscarContrato.Margin = new Padding(2);
            btnBuscarContrato.Name = "btnBuscarContrato";
            btnBuscarContrato.Size = new Size(143, 35);
            btnBuscarContrato.TabIndex = 94;
            btnBuscarContrato.Text = "Buscar contrato";
            btnBuscarContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarContrato.UseVisualStyleBackColor = false;
            btnBuscarContrato.Click += btnBuscarContrato_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtCantidadMulta);
            groupBox7.Controls.Add(label2);
            groupBox7.Controls.Add(txtAtrasoDias);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(txtCantidadDias);
            groupBox7.Controls.Add(label26);
            groupBox7.Controls.Add(dtpHasta);
            groupBox7.Controls.Add(dtpDesde);
            groupBox7.Controls.Add(label27);
            groupBox7.Controls.Add(label28);
            groupBox7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox7.Location = new Point(17, 15);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(386, 191);
            groupBox7.TabIndex = 95;
            groupBox7.TabStop = false;
            groupBox7.Text = "Plazo de renta";
            // 
            // txtCantidadMulta
            // 
            txtCantidadMulta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidadMulta.Location = new Point(253, 149);
            txtCantidadMulta.Margin = new Padding(2);
            txtCantidadMulta.Name = "txtCantidadMulta";
            txtCantidadMulta.Size = new Size(58, 22);
            txtCantidadMulta.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(167, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 39;
            label2.Text = "Multa\r\npor mora:";
            // 
            // txtAtrasoDias
            // 
            txtAtrasoDias.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAtrasoDias.Location = new Point(102, 149);
            txtAtrasoDias.Margin = new Padding(2);
            txtAtrasoDias.Name = "txtAtrasoDias";
            txtAtrasoDias.Size = new Size(58, 22);
            txtAtrasoDias.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(16, 143);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(70, 32);
            label13.TabIndex = 37;
            label13.Text = "Atraso de\r\nentrega:";
            // 
            // txtCantidadDias
            // 
            txtCantidadDias.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidadDias.Location = new Point(102, 95);
            txtCantidadDias.Margin = new Padding(2);
            txtCantidadDias.Name = "txtCantidadDias";
            txtCantidadDias.Size = new Size(58, 22);
            txtCantidadDias.TabIndex = 36;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(17, 89);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(69, 32);
            label26.TabIndex = 34;
            label26.Text = "Cantidad\r\nde días:";
            // 
            // dtpHasta
            // 
            dtpHasta.CalendarFont = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHasta.Location = new Point(79, 58);
            dtpHasta.Margin = new Padding(2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(285, 22);
            dtpHasta.TabIndex = 33;
            // 
            // dtpDesde
            // 
            dtpDesde.CalendarFont = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDesde.Location = new Point(79, 28);
            dtpDesde.Margin = new Padding(2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(285, 22);
            dtpDesde.TabIndex = 32;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(13, 61);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(48, 16);
            label27.TabIndex = 31;
            label27.Text = "Hasta:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(13, 31);
            label28.Margin = new Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new Size(51, 16);
            label28.TabIndex = 30;
            label28.Text = "Desde:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtColor);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(chbNecesitaMantenimiento);
            groupBox6.Controls.Add(txtPlaca);
            groupBox6.Controls.Add(button3);
            groupBox6.Controls.Add(button8);
            groupBox6.Controls.Add(txtMarca);
            groupBox6.Controls.Add(txtModelo);
            groupBox6.Controls.Add(label20);
            groupBox6.Controls.Add(label23);
            groupBox6.Controls.Add(label24);
            groupBox6.Controls.Add(label25);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(17, 229);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(386, 264);
            groupBox6.TabIndex = 93;
            groupBox6.TabStop = false;
            groupBox6.Text = "Datos del Auto";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaca.Location = new Point(92, 35);
            txtPlaca.Margin = new Padding(2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(152, 22);
            txtPlaca.TabIndex = 69;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 80, 200);
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(150, 211);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(131, 35);
            button3.TabIndex = 64;
            button3.Text = "Cancelar";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 80, 200);
            button8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(19, 211);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(124, 35);
            button8.TabIndex = 63;
            button8.Text = "Guardar";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(92, 69);
            txtMarca.Margin = new Padding(2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(152, 22);
            txtMarca.TabIndex = 24;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.Location = new Point(92, 102);
            txtModelo.Margin = new Padding(2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(272, 22);
            txtModelo.TabIndex = 23;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(13, 174);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(169, 16);
            label20.TabIndex = 19;
            label20.Text = "Necesita mantenimiento:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(15, 38);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(48, 16);
            label23.TabIndex = 14;
            label23.Text = "Placa:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(15, 73);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(54, 16);
            label24.TabIndex = 13;
            label24.Text = "Marca:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(15, 105);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(60, 16);
            label25.TabIndex = 12;
            label25.Text = "Modelo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(426, 15);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(424, 141);
            groupBox1.TabIndex = 94;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daños del auto";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(122, 34);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 22);
            textBox2.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 67;
            label1.Text = "Descripción:";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 80, 200);
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(15, 93);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(115, 35);
            button5.TabIndex = 63;
            button5.Text = "Añadir";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(92, 65);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 22);
            textBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 68);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 13;
            label4.Text = "Costo:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { descripcion, costoDaño });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(426, 167);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Tai Le", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(419, 253);
            dataGridView1.TabIndex = 69;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            // 
            // costoDaño
            // 
            costoDaño.HeaderText = "Costo";
            costoDaño.MinimumWidth = 6;
            costoDaño.Name = "costoDaño";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(544, 429);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(101, 22);
            textBox6.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(423, 432);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 19);
            label7.TabIndex = 69;
            label7.Text = "Total multa:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 65);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(335, 32);
            label8.TabIndex = 96;
            label8.Text = "Entrega de auto rentado";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(groupBox7);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(109, 119);
            panel1.MaximumSize = new Size(1023, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 520);
            panel1.TabIndex = 97;
            // 
            // chbNecesitaMantenimiento
            // 
            chbNecesitaMantenimiento.AutoSize = true;
            chbNecesitaMantenimiento.Location = new Point(187, 177);
            chbNecesitaMantenimiento.Name = "chbNecesitaMantenimiento";
            chbNecesitaMantenimiento.Size = new Size(15, 14);
            chbNecesitaMantenimiento.TabIndex = 70;
            chbNecesitaMantenimiento.UseVisualStyleBackColor = true;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(92, 140);
            txtColor.Margin = new Padding(2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(152, 22);
            txtColor.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 143);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 71;
            label3.Text = "Color:";
            // 
            // frm_GarajeEntregaAutoRentado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 745);
            Controls.Add(btnBuscarContrato);
            Controls.Add(label8);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_GarajeEntregaAutoRentado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrega de auto rentado";
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarContrato;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtAtrasoDias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCantidadMulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Panel panel1;
        private TextBox txtPlaca;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn costoDaño;
        private TextBox txtColor;
        private Label label3;
        private CheckBox chbNecesitaMantenimiento;
    }
}