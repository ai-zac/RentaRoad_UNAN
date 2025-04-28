namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Proveedores));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            btnGuardar = new Button();
            groupBox3 = new GroupBox();
            btnTelefono = new Button();
            btnNombre = new Button();
            btnCorreo = new Button();
            btnBuscarRUC = new Button();
            txtTelefono = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            chbEstaHabilitado = new CheckBox();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtRUC = new TextBox();
            label26 = new Label();
            label5 = new Label();
            label2 = new Label();
            dgListaProveedores = new DataGridView();
            dgCodigoRuc = new DataGridViewTextBoxColumn();
            dgNombre = new DataGridViewTextBoxColumn();
            dgTelefono = new DataGridViewTextBoxColumn();
            dgCorreo = new DataGridViewTextBoxColumn();
            dgEstado = new DataGridViewTextBoxColumn();
            dgEliminar = new DataGridViewTextBoxColumn();
            btnCargar = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 71;
            label1.Text = "Proveedores";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(559, 152);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 62;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTelefono);
            groupBox3.Controls.Add(btnNombre);
            groupBox3.Controls.Add(btnCorreo);
            groupBox3.Controls.Add(btnBuscarRUC);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(txtCorreo);
            groupBox3.Controls.Add(txtRUC);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(35, 81);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(706, 212);
            groupBox3.TabIndex = 86;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del proveedor";
            // 
            // btnTelefono
            // 
            btnTelefono.BackColor = Color.FromArgb(0, 80, 200);
            btnTelefono.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTelefono.ForeColor = Color.White;
            btnTelefono.Image = (Image)resources.GetObject("btnTelefono.Image");
            btnTelefono.ImageAlign = ContentAlignment.MiddleRight;
            btnTelefono.Location = new Point(388, 126);
            btnTelefono.Margin = new Padding(3, 2, 3, 2);
            btnTelefono.Name = "btnTelefono";
            btnTelefono.Size = new Size(35, 35);
            btnTelefono.TabIndex = 117;
            btnTelefono.TextAlign = ContentAlignment.MiddleLeft;
            btnTelefono.UseVisualStyleBackColor = false;
            btnTelefono.Click += btnTelefono_Click;
            // 
            // btnNombre
            // 
            btnNombre.BackColor = Color.FromArgb(0, 80, 200);
            btnNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNombre.ForeColor = Color.White;
            btnNombre.Image = (Image)resources.GetObject("btnNombre.Image");
            btnNombre.ImageAlign = ContentAlignment.MiddleRight;
            btnNombre.Location = new Point(642, 92);
            btnNombre.Margin = new Padding(3, 2, 3, 2);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(35, 35);
            btnNombre.TabIndex = 116;
            btnNombre.TextAlign = ContentAlignment.MiddleLeft;
            btnNombre.UseVisualStyleBackColor = false;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnCorreo
            // 
            btnCorreo.BackColor = Color.FromArgb(0, 80, 200);
            btnCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCorreo.ForeColor = Color.White;
            btnCorreo.Image = (Image)resources.GetObject("btnCorreo.Image");
            btnCorreo.ImageAlign = ContentAlignment.MiddleRight;
            btnCorreo.Location = new Point(446, 58);
            btnCorreo.Margin = new Padding(3, 2, 3, 2);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Size = new Size(35, 35);
            btnCorreo.TabIndex = 115;
            btnCorreo.TextAlign = ContentAlignment.MiddleLeft;
            btnCorreo.UseVisualStyleBackColor = false;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // btnBuscarRUC
            // 
            btnBuscarRUC.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarRUC.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarRUC.ForeColor = Color.White;
            btnBuscarRUC.Image = (Image)resources.GetObject("btnBuscarRUC.Image");
            btnBuscarRUC.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarRUC.Location = new Point(446, 24);
            btnBuscarRUC.Margin = new Padding(3, 2, 3, 2);
            btnBuscarRUC.Name = "btnBuscarRUC";
            btnBuscarRUC.Size = new Size(35, 35);
            btnBuscarRUC.TabIndex = 114;
            btnBuscarRUC.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarRUC.UseVisualStyleBackColor = false;
            btnBuscarRUC.Click += btnBuscarRUC_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(169, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 27);
            txtTelefono.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 136);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 12;
            label4.Text = "Teléfono:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbEstaHabilitado);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(18, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 42);
            groupBox2.TabIndex = 110;
            groupBox2.TabStop = false;
            // 
            // chbEstaHabilitado
            // 
            chbEstaHabilitado.AutoSize = true;
            chbEstaHabilitado.Location = new Point(151, 22);
            chbEstaHabilitado.Name = "chbEstaHabilitado";
            chbEstaHabilitado.Size = new Size(15, 14);
            chbEstaHabilitado.TabIndex = 109;
            chbEstaHabilitado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(-2, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 105;
            label3.Text = "Esta habilitado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(466, 27);
            txtNombre.TabIndex = 88;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(170, 62);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(270, 27);
            txtCorreo.TabIndex = 87;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(170, 28);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(270, 27);
            txtRUC.TabIndex = 86;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(18, 102);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(128, 16);
            label26.TabIndex = 81;
            label26.Text = "Nombre completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 67);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 16);
            label5.TabIndex = 64;
            label5.Text = "Correo electrónico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 16);
            label2.TabIndex = 14;
            label2.Text = "Código RUC:";
            // 
            // dgListaProveedores
            // 
            dgListaProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgListaProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaProveedores.Columns.AddRange(new DataGridViewColumn[] { dgCodigoRuc, dgNombre, dgTelefono, dgCorreo, dgEstado, dgEliminar });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Tai Le", 11F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgListaProveedores.DefaultCellStyle = dataGridViewCellStyle10;
            dgListaProveedores.Location = new Point(11, 316);
            dgListaProveedores.Margin = new Padding(2);
            dgListaProveedores.Name = "dgListaProveedores";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgListaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgListaProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new Font("Microsoft Tai Le", 11F);
            dgListaProveedores.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgListaProveedores.RowTemplate.Height = 24;
            dgListaProveedores.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgListaProveedores.Size = new Size(1066, 418);
            dgListaProveedores.TabIndex = 82;
            dgListaProveedores.CellClick += dgListaProveedores_seleccionarProveedor;
            dgListaProveedores.CellDoubleClick += dgListaProveedores_eliminarUsuario;
            dgListaProveedores.CellEndEdit += dgListaProveedores_actualizarProveedor;
            // 
            // dgCodigoRuc
            // 
            dgCodigoRuc.HeaderText = "Código RUC";
            dgCodigoRuc.MinimumWidth = 6;
            dgCodigoRuc.Name = "dgCodigoRuc";
            dgCodigoRuc.ReadOnly = true;
            // 
            // dgNombre
            // 
            dgNombre.HeaderText = "Nombre completo";
            dgNombre.MinimumWidth = 6;
            dgNombre.Name = "dgNombre";
            // 
            // dgTelefono
            // 
            dgTelefono.HeaderText = "Teléfono";
            dgTelefono.MinimumWidth = 6;
            dgTelefono.Name = "dgTelefono";
            // 
            // dgCorreo
            // 
            dgCorreo.HeaderText = "Correo electrónico";
            dgCorreo.MinimumWidth = 6;
            dgCorreo.Name = "dgCorreo";
            // 
            // dgEstado
            // 
            dgEstado.HeaderText = "Habilitado";
            dgEstado.Name = "dgEstado";
            // 
            // dgEliminar
            // 
            dgEliminar.HeaderText = "Eliminar";
            dgEliminar.Name = "dgEliminar";
            dgEliminar.ReadOnly = true;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(0, 80, 200);
            btnCargar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.ImageAlign = ContentAlignment.MiddleRight;
            btnCargar.Location = new Point(218, 36);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(76, 39);
            btnCargar.TabIndex = 121;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // frm_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 745);
            Controls.Add(btnCargar);
            Controls.Add(groupBox3);
            Controls.Add(dgListaProveedores);
            Controls.Add(label1);
            Margin = new Padding(2);
            MinimumSize = new Size(700, 345);
            Name = "frm_Proveedores";
            Text = "ControlProveedores";
            Load += frm_Proveedores_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgListaProveedores;
        private System.Windows.Forms.Label label26;
        private TextBox txtRUC;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private GroupBox groupBox2;
        private CheckBox chbEstaHabilitado;
        private Label label3;
        private DataGridViewTextBoxColumn dgNombreCompleto;
        private DataGridViewTextBoxColumn dgTelefonoProveedor;
        private DataGridViewTextBoxColumn dgCorreoElectronico;
        private DataGridViewTextBoxColumn dgHabilitado;
        private DataGridViewTextBoxColumn dgCodigoRuc;
        private DataGridViewTextBoxColumn dgNombre;
        private DataGridViewTextBoxColumn dgTelefono;
        private DataGridViewTextBoxColumn dgCorreo;
        private DataGridViewTextBoxColumn dgEstado;
        private DataGridViewTextBoxColumn dgEliminar;
        private Button btnCargar;
        private Button btnCorreo;
        private Button btnBuscarRUC;
        private Button btnTelefono;
        private Button btnNombre;
    }
}