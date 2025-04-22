namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label25 = new Label();
            button5 = new Button();
            label7 = new Label();
            textBox19 = new TextBox();
            label22 = new Label();
            label26 = new Label();
            label27 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 65;
            label1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column4, Column5, eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(11, 401);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Tai Le", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1066, 333);
            dataGridView1.TabIndex = 84;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox19);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label27);
            groupBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(37, 74);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(700, 313);
            groupBox2.TabIndex = 85;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Cliente";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(189, 135);
            comboBox5.Margin = new Padding(4, 3, 4, 3);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(180, 25);
            comboBox5.TabIndex = 94;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(85, 99);
            comboBox4.Margin = new Padding(4, 3, 4, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(180, 25);
            comboBox4.TabIndex = 82;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(85, 61);
            comboBox3.Margin = new Padding(4, 3, 4, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 25);
            comboBox3.TabIndex = 81;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 25);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(466, 25);
            comboBox1.TabIndex = 80;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(85, 171);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 25);
            comboBox2.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 173);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 78;
            label2.Text = "Estado:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(8, 102);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(65, 16);
            label25.TabIndex = 76;
            label25.Text = "Teléfono:";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 80, 200);
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(544, 252);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(127, 39);
            button5.TabIndex = 62;
            button5.Text = "Guardar";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(8, 139);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 16);
            label7.TabIndex = 62;
            label7.Text = "Licencia de conducir:";
            // 
            // textBox19
            // 
            textBox19.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox19.Location = new Point(98, 205);
            textBox19.Margin = new Padding(2);
            textBox19.Multiline = true;
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(377, 85);
            textBox19.TabIndex = 58;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(11, 204);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(73, 16);
            label22.TabIndex = 57;
            label22.Text = "Dirección:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(8, 27);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(128, 16);
            label26.TabIndex = 54;
            label26.Text = "Nombre completo:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(8, 60);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(59, 16);
            label27.TabIndex = 52;
            label27.Text = "Cédula:";
            // 
            // Column1
            // 
            Column1.HeaderText = "Cédula";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre completo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Licencia de conducir";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column4
            // 
            Column4.HeaderText = "Teléfono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Dirección";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "eliminar";
            // 
            // ControlCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 745);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ControlCliente";
            Text = "ControlCliente";
            Load += ControlCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupBox groupBox2;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label25;
        private Button button5;
        private Label label7;
        private TextBox textBox19;
        private Label label22;
        private Label label26;
        private Label label27;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn eliminar;
    }
}