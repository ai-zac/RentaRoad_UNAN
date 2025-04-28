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
            dgListaClientes = new DataGridView();
            groupBox2 = new GroupBox();
            btnBuscarNombre = new Button();
            btnBuscarLicencia = new Button();
            txtLicencia = new TextBox();
            txtTelefono = new TextBox();
            btnBuscarTelefono = new Button();
            txtCedula = new TextBox();
            btnBuscarCedula = new Button();
            txtNombre = new TextBox();
            label25 = new Label();
            btnGuardar = new Button();
            label7 = new Label();
            txtDireccion = new TextBox();
            label22 = new Label();
            label26 = new Label();
            label27 = new Label();
            btnCargar = new Button();
            clmCedula = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmLicencia = new DataGridViewTextBoxColumn();
            clmTelefono = new DataGridViewTextBoxColumn();
            clmDireccion = new DataGridViewTextBoxColumn();
            clmEliminar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgListaClientes).BeginInit();
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
            // dgListaClientes
            // 
            dgListaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaClientes.Columns.AddRange(new DataGridViewColumn[] { clmCedula, clmNombre, clmLicencia, clmTelefono, clmDireccion, clmEliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgListaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgListaClientes.Location = new Point(11, 401);
            dgListaClientes.Margin = new Padding(2);
            dgListaClientes.Name = "dgListaClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Tai Le", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgListaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgListaClientes.RowHeadersWidth = 51;
            dgListaClientes.RowTemplate.Height = 24;
            dgListaClientes.Size = new Size(1066, 333);
            dgListaClientes.TabIndex = 84;
            dgListaClientes.CellClick += dgListaClientes_seleccionarCliente;
            dgListaClientes.CellDoubleClick += dgListaClientes_eliminarClientes;
            dgListaClientes.CellEndEdit += dgListaClientes_actualizarCliente;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarNombre);
            groupBox2.Controls.Add(btnBuscarLicencia);
            groupBox2.Controls.Add(txtLicencia);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(btnBuscarTelefono);
            groupBox2.Controls.Add(txtCedula);
            groupBox2.Controls.Add(btnBuscarCedula);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDireccion);
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
            // btnBuscarNombre
            // 
            btnBuscarNombre.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarNombre.ForeColor = Color.White;
            btnBuscarNombre.Image = (Image)resources.GetObject("btnBuscarNombre.Image");
            btnBuscarNombre.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarNombre.Location = new Point(632, 18);
            btnBuscarNombre.Margin = new Padding(3, 2, 3, 2);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.Size = new Size(35, 35);
            btnBuscarNombre.TabIndex = 119;
            btnBuscarNombre.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarNombre.UseVisualStyleBackColor = false;
            btnBuscarNombre.Click += btnBuscarNombre_Click;
            // 
            // btnBuscarLicencia
            // 
            btnBuscarLicencia.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarLicencia.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarLicencia.ForeColor = Color.White;
            btnBuscarLicencia.Image = (Image)resources.GetObject("btnBuscarLicencia.Image");
            btnBuscarLicencia.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarLicencia.Location = new Point(351, 130);
            btnBuscarLicencia.Margin = new Padding(3, 2, 3, 2);
            btnBuscarLicencia.Name = "btnBuscarLicencia";
            btnBuscarLicencia.Size = new Size(35, 35);
            btnBuscarLicencia.TabIndex = 118;
            btnBuscarLicencia.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarLicencia.UseVisualStyleBackColor = false;
            btnBuscarLicencia.Click += btnBuscarLicencia_Click;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(165, 134);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(180, 26);
            txtLicencia.TabIndex = 117;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(85, 97);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 26);
            txtTelefono.TabIndex = 116;
            // 
            // btnBuscarTelefono
            // 
            btnBuscarTelefono.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarTelefono.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarTelefono.ForeColor = Color.White;
            btnBuscarTelefono.Image = (Image)resources.GetObject("btnBuscarTelefono.Image");
            btnBuscarTelefono.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarTelefono.Location = new Point(271, 93);
            btnBuscarTelefono.Margin = new Padding(3, 2, 3, 2);
            btnBuscarTelefono.Name = "btnBuscarTelefono";
            btnBuscarTelefono.Size = new Size(35, 35);
            btnBuscarTelefono.TabIndex = 115;
            btnBuscarTelefono.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarTelefono.UseVisualStyleBackColor = false;
            btnBuscarTelefono.Click += btnBuscarTelefono_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(85, 55);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(180, 26);
            txtCedula.TabIndex = 114;
            // 
            // btnBuscarCedula
            // 
            btnBuscarCedula.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarCedula.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCedula.ForeColor = Color.White;
            btnBuscarCedula.Image = (Image)resources.GetObject("btnBuscarCedula.Image");
            btnBuscarCedula.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarCedula.Location = new Point(271, 51);
            btnBuscarCedula.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCedula.Name = "btnBuscarCedula";
            btnBuscarCedula.Size = new Size(35, 35);
            btnBuscarCedula.TabIndex = 113;
            btnBuscarCedula.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarCedula.UseVisualStyleBackColor = false;
            btnBuscarCedula.Click += btnBuscarCedula_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(466, 26);
            txtNombre.TabIndex = 95;
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
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(544, 252);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 39);
            btnGuardar.TabIndex = 62;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(98, 182);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(377, 85);
            txtDireccion.TabIndex = 58;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(11, 181);
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
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(0, 80, 200);
            btnCargar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.ImageAlign = ContentAlignment.MiddleRight;
            btnCargar.Location = new Point(171, 23);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(76, 39);
            btnCargar.TabIndex = 120;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // clmCedula
            // 
            clmCedula.HeaderText = "Cédula";
            clmCedula.MinimumWidth = 6;
            clmCedula.Name = "clmCedula";
            clmCedula.ReadOnly = true;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre completo";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            // 
            // clmLicencia
            // 
            clmLicencia.HeaderText = "Licencia de conducir";
            clmLicencia.MinimumWidth = 6;
            clmLicencia.Name = "clmLicencia";
            clmLicencia.ReadOnly = true;
            // 
            // clmTelefono
            // 
            clmTelefono.HeaderText = "Teléfono";
            clmTelefono.MinimumWidth = 6;
            clmTelefono.Name = "clmTelefono";
            // 
            // clmDireccion
            // 
            clmDireccion.HeaderText = "Dirección";
            clmDireccion.MinimumWidth = 6;
            clmDireccion.Name = "clmDireccion";
            // 
            // clmEliminar
            // 
            clmEliminar.HeaderText = "Eliminar";
            clmEliminar.Name = "clmEliminar";
            clmEliminar.ReadOnly = true;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 745);
            Controls.Add(btnCargar);
            Controls.Add(groupBox2);
            Controls.Add(dgListaClientes);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_Clientes";
            Text = "ControlCliente";
            Load += ControlCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgListaClientes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private GroupBox groupBox2;
        private Label label25;
        private Button btnGuardar;
        private Label label7;
        private TextBox txtDireccion;
        private Label label22;
        private Label label26;
        private Label label27;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private Button btnBuscarCedula;
        private TextBox txtTelefono;
        private Button btnBuscarTelefono;
        private Button btnBuscarLicencia;
        private TextBox txtLicencia;
        private Button btnBuscarNombre;
        private Button btnCargar;
        private DataGridViewTextBoxColumn clmCedula;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmLicencia;
        private DataGridViewTextBoxColumn clmTelefono;
        private DataGridViewTextBoxColumn clmDireccion;
        private DataGridViewTextBoxColumn clmEliminar;
    }
}