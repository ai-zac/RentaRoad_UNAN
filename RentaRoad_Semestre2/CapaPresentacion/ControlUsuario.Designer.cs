namespace RentaRoad_Semestre3.CapaPresentacion
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            label1 = new Label();
            dgListaUsuarios = new DataGridView();
            groupBox3 = new GroupBox();
            txtCedulaUsuario = new TextBox();
            label8 = new Label();
            txtTelefonoUsuario = new TextBox();
            btnCrear = new Button();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtCorreoUsuario = new TextBox();
            button3 = new Button();
            label6 = new Label();
            cmbCargoEmpleado = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            label2 = new Label();
            cmbTipoUsuario = new ComboBox();
            txtContraseña = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgListaUsuarios).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 65;
            label1.Text = "Usuarios";
            // 
            // dgListaUsuarios
            // 
            dgListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaUsuarios.Location = new Point(0, 406);
            dgListaUsuarios.Margin = new Padding(2);
            dgListaUsuarios.Name = "dgListaUsuarios";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgListaUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgListaUsuarios.RowTemplate.Height = 24;
            dgListaUsuarios.Size = new Size(1089, 339);
            dgListaUsuarios.TabIndex = 64;
            dgListaUsuarios.CellClick += dgListaUsuarios_seleccionarUsuario;
            dgListaUsuarios.CellDoubleClick += dgListaUsuarios_eliminarUsuario;
            dgListaUsuarios.CellEndEdit += dgListaUsuarios_actualizarUsuario;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtCedulaUsuario);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtTelefonoUsuario);
            groupBox3.Controls.Add(btnCrear);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtNombreUsuario);
            groupBox3.Controls.Add(txtCorreoUsuario);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmbCargoEmpleado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cmbTipoUsuario);
            groupBox3.Controls.Add(txtContraseña);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(37, 95);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(589, 264);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del usuario";
            // 
            // txtCedulaUsuario
            // 
            txtCedulaUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedulaUsuario.Location = new Point(167, 126);
            txtCedulaUsuario.Margin = new Padding(2);
            txtCedulaUsuario.Name = "txtCedulaUsuario";
            txtCedulaUsuario.Size = new Size(179, 22);
            txtCedulaUsuario.TabIndex = 102;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 125);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 16);
            label8.TabIndex = 101;
            label8.Text = "Cedula:";
            // 
            // txtTelefonoUsuario
            // 
            txtTelefonoUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoUsuario.Location = new Point(168, 98);
            txtTelefonoUsuario.Margin = new Padding(2);
            txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            txtTelefonoUsuario.Size = new Size(179, 22);
            txtTelefonoUsuario.TabIndex = 100;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 80, 200);
            btnCrear.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Image = (Image)resources.GetObject("btnCrear.Image");
            btnCrear.ImageAlign = ContentAlignment.MiddleRight;
            btnCrear.Location = new Point(408, 200);
            btnCrear.Margin = new Padding(2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(128, 39);
            btnCrear.TabIndex = 84;
            btnCrear.Text = "Guardar";
            btnCrear.TextAlign = ContentAlignment.MiddleLeft;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 99;
            label3.Text = "Teléfono:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(167, 33);
            txtNombreUsuario.Margin = new Padding(2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(338, 22);
            txtNombreUsuario.TabIndex = 98;
            // 
            // txtCorreoUsuario
            // 
            txtCorreoUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoUsuario.Location = new Point(167, 67);
            txtCorreoUsuario.Margin = new Padding(2);
            txtCorreoUsuario.Name = "txtCorreoUsuario";
            txtCorreoUsuario.Size = new Size(338, 22);
            txtCorreoUsuario.TabIndex = 97;
            // 
            // button3
            // 
            button3.BackColor = Color.Azure;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(511, 59);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(38, 38);
            button3.TabIndex = 95;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 66);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 16);
            label6.TabIndex = 93;
            label6.Text = "Correo electrónico:";
            // 
            // cmbCargoEmpleado
            // 
            cmbCargoEmpleado.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbCargoEmpleado.FormattingEnabled = true;
            cmbCargoEmpleado.Location = new Point(167, 188);
            cmbCargoEmpleado.Margin = new Padding(4, 3, 4, 3);
            cmbCargoEmpleado.Name = "cmbCargoEmpleado";
            cmbCargoEmpleado.Size = new Size(152, 21);
            cmbCargoEmpleado.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 194);
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
            button1.Location = new Point(511, 25);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 90;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 16);
            label2.TabIndex = 82;
            label2.Text = "Nombre usuario:";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(167, 155);
            cmbTipoUsuario.Margin = new Padding(4, 3, 4, 3);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(152, 21);
            cmbTipoUsuario.TabIndex = 70;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtContraseña.Location = new Point(167, 219);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(151, 20);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 161);
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
            ClientSize = new Size(1088, 745);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(dgListaUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ControlUsuario";
            Text = "ControlUsuario";
            Load += ControlUsuario_Load;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCargoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private TextBox txtNombreUsuario;
        private TextBox txtCorreoUsuario;
        private TextBox txtTelefonoUsuario;
        private Label label3;
        private TextBox txtCedulaUsuario;
        private Label label8;
    }
}