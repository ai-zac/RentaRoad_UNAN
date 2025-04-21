namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Usuarios));
            label1 = new Label();
            dgListaUsuarios = new DataGridView();
            groupBox3 = new GroupBox();
            txtCedulaUsuario = new TextBox();
            label8 = new Label();
            btnCrear = new Button();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtCorreoUsuario = new TextBox();
            label6 = new Label();
            cmbCargoEmpleado = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            cmbTipoUsuario = new ComboBox();
            txtContraseña = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cmbTelefonoUsuario = new ComboBox();
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
            dgListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaUsuarios.Location = new Point(11, 406);
            dgListaUsuarios.Margin = new Padding(2);
            dgListaUsuarios.Name = "dgListaUsuarios";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgListaUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgListaUsuarios.RowTemplate.Height = 24;
            dgListaUsuarios.Size = new Size(1066, 328);
            dgListaUsuarios.TabIndex = 64;
            dgListaUsuarios.CellClick += dgListaUsuarios_seleccionarUsuario;
            dgListaUsuarios.CellDoubleClick += dgListaUsuarios_eliminarUsuario;
            dgListaUsuarios.CellEndEdit += dgListaUsuarios_actualizarUsuario;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(cmbTelefonoUsuario);
            groupBox3.Controls.Add(txtCedulaUsuario);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnCrear);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtNombreUsuario);
            groupBox3.Controls.Add(txtCorreoUsuario);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cmbCargoEmpleado);
            groupBox3.Controls.Add(label7);
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
            // cmbTelefonoUsuario
            // 
            cmbTelefonoUsuario.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbTelefonoUsuario.FormattingEnabled = true;
            cmbTelefonoUsuario.Location = new Point(167, 95);
            cmbTelefonoUsuario.Margin = new Padding(4, 3, 4, 3);
            cmbTelefonoUsuario.Name = "cmbTelefonoUsuario";
            cmbTelefonoUsuario.Size = new Size(179, 21);
            cmbTelefonoUsuario.TabIndex = 103;
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
            Shown += ControlUsuario_Load;
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
        private System.Windows.Forms.ComboBox cmbCargoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private TextBox txtNombreUsuario;
        private TextBox txtCorreoUsuario;
        private Label label3;
        private TextBox txtCedulaUsuario;
        private Label label8;
        private ComboBox cmbTelefonoUsuario;
    }
}