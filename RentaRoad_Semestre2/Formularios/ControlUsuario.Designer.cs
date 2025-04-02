namespace RentaRoad_Semestre3.Formularios
{
    partial class ControlUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            label1 = new Label();
            dgListaUsuarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            nombreCompletoUsuario = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            correoElectrónico = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cargoEmpleado = new DataGridViewTextBoxColumn();
            casdf = new DataGridViewTextBoxColumn();
            fechaModificacion = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button3 = new Button();
            comboBox4 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            cbTipoUsuario = new ComboBox();
            txtContraseña = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgListaUsuarios).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 65;
            label1.Text = "Usuarios";
            // 
            // dgListaUsuarios
            // 
            dgListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column1, nombreCompletoUsuario, Column3, correoElectrónico, Column4, cargoEmpleado, casdf, fechaModificacion, eliminar });
            dgListaUsuarios.Dock = DockStyle.Bottom;
            dgListaUsuarios.Location = new Point(0, 347);
            dgListaUsuarios.Margin = new Padding(2);
            dgListaUsuarios.Name = "dgListaUsuarios";
            dgListaUsuarios.RowHeadersWidth = 51;
            dgListaUsuarios.RowTemplate.Height = 24;
            dgListaUsuarios.Size = new Size(791, 277);
            dgListaUsuarios.TabIndex = 64;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Usuario";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // nombreCompletoUsuario
            // 
            nombreCompletoUsuario.HeaderText = "Nombre completo";
            nombreCompletoUsuario.MinimumWidth = 6;
            nombreCompletoUsuario.Name = "nombreCompletoUsuario";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre usuario";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // correoElectrónico
            // 
            correoElectrónico.HeaderText = "Correo electrónico";
            correoElectrónico.Name = "correoElectrónico";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tipo de usuario";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // cargoEmpleado
            // 
            cargoEmpleado.HeaderText = "Cargo empleado";
            cargoEmpleado.Name = "cargoEmpleado";
            // 
            // casdf
            // 
            casdf.HeaderText = "Fecha de creación";
            casdf.MinimumWidth = 6;
            casdf.Name = "casdf";
            // 
            // fechaModificacion
            // 
            fechaModificacion.HeaderText = "Fecha modificación";
            fechaModificacion.Name = "fechaModificacion";
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "eliminar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(cbTipoUsuario);
            groupBox3.Controls.Add(txtContraseña);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(40, 70);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(707, 260);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del usuario";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Azure;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(511, 99);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(38, 38);
            button3.TabIndex = 95;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(167, 103);
            comboBox4.Margin = new Padding(4, 3, 4, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(338, 25);
            comboBox4.TabIndex = 94;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 106);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 16);
            label6.TabIndex = 93;
            label6.Text = "Correo electrónico:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(167, 179);
            comboBox3.Margin = new Padding(4, 3, 4, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(152, 27);
            comboBox3.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 185);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 16);
            label7.TabIndex = 91;
            label7.Text = "Cargo empleado:";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(511, 63);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 90;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Azure;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(639, 25);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(38, 38);
            button2.TabIndex = 89;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 80, 200);
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(550, 179);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(128, 39);
            button5.TabIndex = 84;
            button5.Text = "Guardar";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 67);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(338, 25);
            comboBox2.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 82;
            label2.Text = "Nombre usuario:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 29);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(466, 25);
            comboBox1.TabIndex = 81;
            // 
            // cbTipoUsuario
            // 
            cbTipoUsuario.FormattingEnabled = true;
            cbTipoUsuario.Location = new Point(167, 138);
            cbTipoUsuario.Margin = new Padding(4, 3, 4, 3);
            cbTipoUsuario.Name = "cbTipoUsuario";
            cbTipoUsuario.Size = new Size(152, 27);
            cbTipoUsuario.TabIndex = 70;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(167, 219);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(151, 22);
            txtContraseña.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 223);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 64;
            label5.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 16);
            label3.TabIndex = 13;
            label3.Text = "Nombre completo:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 12;
            label4.Text = "Tipo usuario:";
            // 
            // ControlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 624);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(dgListaUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ControlUsuario";
            Text = "ControlUsuario";
            ((System.ComponentModel.ISupportInitialize)dgListaUsuarios).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectrónico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn casdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
    }
}