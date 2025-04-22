namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_GarajeColores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GarajeColores));
            dgListaColores = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            button2 = new Button();
            button4 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgListaColores).BeginInit();
            SuspendLayout();
            // 
            // dgListaColores
            // 
            dgListaColores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaColores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListaColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListaColores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaColores.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgListaColores.Location = new Point(37, 203);
            dgListaColores.Margin = new Padding(2);
            dgListaColores.Name = "dgListaColores";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgListaColores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgListaColores.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Microsoft Tai Le", 11F);
            dgListaColores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgListaColores.RowTemplate.Height = 24;
            dgListaColores.Size = new Size(461, 469);
            dgListaColores.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 85;
            label1.Text = "Lista de colores";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(37, 85);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 16);
            label8.TabIndex = 97;
            label8.Text = "Nombre del color:";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 80, 200);
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(37, 149);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 96;
            button2.Text = "Guardar";
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
            button4.Location = new Point(274, 97);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(38, 35);
            button4.TabIndex = 94;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(37, 104);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(232, 23);
            maskedTextBox1.TabIndex = 98;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 64.69302F;
            Column1.HeaderText = "ID_Color";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.FillWeight = 83.02271F;
            Column2.HeaderText = "Color";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            // frm_GarajeColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 710);
            Controls.Add(maskedTextBox1);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(dgListaColores);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_GarajeColores";
            Text = "frm_GarajeColores";
            ((System.ComponentModel.ISupportInitialize)dgListaColores).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaColores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private Button button4;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}