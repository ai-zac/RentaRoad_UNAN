namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_GarajeMarcas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GarajeMarcas));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label8 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 93;
            label1.Text = "Lista de marcas";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3 });
            dataGridView1.Location = new Point(38, 204);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Microsoft Tai Le", 11F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(463, 485);
            dataGridView1.TabIndex = 92;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 80, 200);
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(275, 106);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(38, 35);
            button3.TabIndex = 98;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(38, 94);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(148, 16);
            label8.TabIndex = 101;
            label8.Text = "Nombre de la marca:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 80, 200);
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(38, 150);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 100;
            button2.Text = "Guardar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(38, 113);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(232, 23);
            maskedTextBox1.TabIndex = 102;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 64.69302F;
            Column1.HeaderText = "ID_Marca";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Marca";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.FillWeight = 152.2843F;
            Column3.HeaderText = "Eliminar";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 80;
            // 
            // frm_GarajeMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 727);
            Controls.Add(maskedTextBox1);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_GarajeMarcas";
            Text = "ControlMarcas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}