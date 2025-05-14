namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_Egreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Egreso));
            dgt_egresos = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dgt_egresos).BeginInit();
            SuspendLayout();
            // 
            // dgt_egresos
            // 
            dgt_egresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgt_egresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgt_egresos.Location = new Point(85, 162);
            dgt_egresos.Name = "dgt_egresos";
            dgt_egresos.RowHeadersWidth = 102;
            dgt_egresos.Size = new Size(2139, 710);
            dgt_egresos.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1002, 59);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 47);
            label1.TabIndex = 219;
            label1.Text = "Ver Egresos ";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 81, 200);
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1002, 925);
            button3.Name = "button3";
            button3.Size = new Size(277, 93);
            button3.TabIndex = 221;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // frm_Egreso
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2286, 1200);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dgt_egresos);
            Name = "frm_Egreso";
            Text = "frm_Egreso";
            Load += frm_Egreso_Load;
            ((System.ComponentModel.ISupportInitialize)dgt_egresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgt_egresos;
        private Label label1;
        private Button button3;
        private PrintPreviewDialog printPreviewDialog1;
    }
}