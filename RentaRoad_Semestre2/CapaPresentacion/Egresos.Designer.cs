namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class Egresos
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
            panel1 = new Panel();
            txt_Nombre = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            btn_Guardar = new Button();
            txt1_Monto = new TextBox();
            label4 = new Label();
            txt_Direccion = new TextBox();
            label3 = new Label();
            txt_Fecha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgt_Agresos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgt_Agresos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_Guardar);
            panel1.Controls.Add(txt1_Monto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Direccion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Fecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            panel1.Location = new Point(68, 23);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1883, 495);
            panel1.TabIndex = 0;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(266, 159);
            txt_Nombre.Margin = new Padding(4, 3, 4, 3);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(455, 49);
            txt_Nombre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(97, 162);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 40);
            label5.TabIndex = 10;
            label5.Text = "Nombre:";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 81, 200);
            button3.Location = new Point(1448, 390);
            button3.Name = "button3";
            button3.Size = new Size(277, 93);
            button3.TabIndex = 9;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 81, 200);
            button2.Location = new Point(1114, 390);
            button2.Name = "button2";
            button2.Size = new Size(277, 93);
            button2.TabIndex = 8;
            button2.Text = "Cancelar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 81, 200);
            btn_Guardar.Location = new Point(806, 390);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(277, 93);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += button1_Click;
            // 
            // txt1_Monto
            // 
            txt1_Monto.Location = new Point(259, 390);
            txt1_Monto.Margin = new Padding(4, 3, 4, 3);
            txt1_Monto.Name = "txt1_Monto";
            txt1_Monto.Size = new Size(455, 49);
            txt1_Monto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(119, 399);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 40);
            label4.TabIndex = 5;
            label4.Text = "Monto:";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(259, 302);
            txt_Direccion.Margin = new Padding(4, 3, 4, 3);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(455, 49);
            txt_Direccion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 40);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
            // 
            // txt_Fecha
            // 
            txt_Fecha.Location = new Point(259, 227);
            txt_Fecha.Margin = new Padding(4, 3, 4, 3);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(455, 49);
            txt_Fecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 40);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 63);
            label1.TabIndex = 0;
            label1.Text = "Registrar Egresos";
            label1.Click += label1_Click;
            // 
            // dgt_Agresos
            // 
            dgt_Agresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgt_Agresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgt_Agresos.Location = new Point(54, 573);
            dgt_Agresos.Name = "dgt_Agresos";
            dgt_Agresos.RowHeadersWidth = 102;
            dgt_Agresos.Size = new Size(1910, 569);
            dgt_Agresos.TabIndex = 1;
            // 
            // Egresos
            // 
            AutoScaleDimensions = new SizeF(20F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2041, 1200);
            Controls.Add(dgt_Agresos);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Egresos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Egresos";
            Load += Egresos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgt_Agresos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_Fecha;
        private Button btn_Guardar;
        private TextBox txt1_Monto;
        private Label label4;
        private TextBox txt_Direccion;
        private Label label3;
        private DataGridView dgt_Agresos;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox txt_Nombre;
    }
}