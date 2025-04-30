namespace RentaRoad_Semestre3.CapaPresentacion
{
    partial class frm_GarajeListaAutos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GarajeListaAutos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ofdImagenAuto = new OpenFileDialog();
            label32 = new Label();
            pibImagenAuto = new PictureBox();
            groupBox3 = new GroupBox();
            chbPlacaVerificada = new CheckBox();
            chbHabilitado = new CheckBox();
            chbDisponibilidad = new CheckBox();
            chbFuncional = new CheckBox();
            btnBuscarPlaca = new Button();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            cmbColor = new ComboBox();
            label29 = new Label();
            txtNumeroAsientos = new TextBox();
            label5 = new Label();
            btnNuevoModelo = new Button();
            btnNuevaMarca = new Button();
            btnNuevoColor = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPrecioRenta = new TextBox();
            txtAñoSalida = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dgListaAutos = new DataGridView();
            label31 = new Label();
            clPlaca = new DataGridViewTextBoxColumn();
            clMarca = new DataGridViewTextBoxColumn();
            clModelo = new DataGridViewTextBoxColumn();
            clColor = new DataGridViewTextBoxColumn();
            clAño = new DataGridViewTextBoxColumn();
            clAsientos = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewTextBoxColumn();
            clDisponibilidad = new DataGridViewTextBoxColumn();
            clEliminar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pibImagenAuto).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaAutos).BeginInit();
            SuspendLayout();
            // 
            // ofdImagenAuto
            // 
            ofdImagenAuto.FileName = "openFileDialog1";
            ofdImagenAuto.Title = "abrirImagenAuto";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label32.Location = new Point(719, 65);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(99, 19);
            label32.TabIndex = 90;
            label32.Text = "Vista previa";
            // 
            // pibImagenAuto
            // 
            pibImagenAuto.BackColor = Color.DarkGray;
            pibImagenAuto.Location = new Point(719, 87);
            pibImagenAuto.Margin = new Padding(4, 3, 4, 3);
            pibImagenAuto.Name = "pibImagenAuto";
            pibImagenAuto.Size = new Size(251, 277);
            pibImagenAuto.TabIndex = 88;
            pibImagenAuto.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chbPlacaVerificada);
            groupBox3.Controls.Add(chbHabilitado);
            groupBox3.Controls.Add(chbDisponibilidad);
            groupBox3.Controls.Add(chbFuncional);
            groupBox3.Controls.Add(btnBuscarPlaca);
            groupBox3.Controls.Add(txtPlaca);
            groupBox3.Controls.Add(txtModelo);
            groupBox3.Controls.Add(txtMarca);
            groupBox3.Controls.Add(cmbColor);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(txtNumeroAsientos);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnNuevoModelo);
            groupBox3.Controls.Add(btnNuevaMarca);
            groupBox3.Controls.Add(btnNuevoColor);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtPrecioRenta);
            groupBox3.Controls.Add(txtAñoSalida);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(28, 78);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(654, 277);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Auto";
            // 
            // chbPlacaVerificada
            // 
            chbPlacaVerificada.AutoSize = true;
            chbPlacaVerificada.Location = new Point(533, 181);
            chbPlacaVerificada.Name = "chbPlacaVerificada";
            chbPlacaVerificada.Size = new Size(15, 14);
            chbPlacaVerificada.TabIndex = 116;
            chbPlacaVerificada.UseVisualStyleBackColor = true;
            // 
            // chbHabilitado
            // 
            chbHabilitado.AutoSize = true;
            chbHabilitado.Location = new Point(533, 137);
            chbHabilitado.Name = "chbHabilitado";
            chbHabilitado.Size = new Size(15, 14);
            chbHabilitado.TabIndex = 115;
            chbHabilitado.UseVisualStyleBackColor = true;
            // 
            // chbDisponibilidad
            // 
            chbDisponibilidad.AutoSize = true;
            chbDisponibilidad.Location = new Point(533, 103);
            chbDisponibilidad.Name = "chbDisponibilidad";
            chbDisponibilidad.Size = new Size(15, 14);
            chbDisponibilidad.TabIndex = 114;
            chbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // chbFuncional
            // 
            chbFuncional.AutoSize = true;
            chbFuncional.Location = new Point(533, 68);
            chbFuncional.Name = "chbFuncional";
            chbFuncional.Size = new Size(15, 14);
            chbFuncional.TabIndex = 113;
            chbFuncional.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPlaca
            // 
            btnBuscarPlaca.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscarPlaca.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPlaca.ForeColor = Color.White;
            btnBuscarPlaca.Image = (Image)resources.GetObject("btnBuscarPlaca.Image");
            btnBuscarPlaca.Location = new Point(280, 24);
            btnBuscarPlaca.Margin = new Padding(3, 2, 3, 2);
            btnBuscarPlaca.Name = "btnBuscarPlaca";
            btnBuscarPlaca.Size = new Size(35, 35);
            btnBuscarPlaca.TabIndex = 112;
            btnBuscarPlaca.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarPlaca.UseVisualStyleBackColor = false;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaca.Location = new Point(122, 30);
            txtPlaca.Margin = new Padding(2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(152, 22);
            txtPlaca.TabIndex = 84;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.Location = new Point(122, 88);
            txtModelo.Margin = new Padding(2);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.Size = new Size(152, 22);
            txtModelo.TabIndex = 83;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(122, 58);
            txtMarca.Margin = new Padding(2);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(152, 22);
            txtMarca.TabIndex = 82;
            // 
            // cmbColor
            // 
            cmbColor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbColor.Location = new Point(124, 118);
            cmbColor.Margin = new Padding(2);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(152, 25);
            cmbColor.TabIndex = 80;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(412, 170);
            label29.Margin = new Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new Size(96, 32);
            label29.TabIndex = 76;
            label29.Text = "La placa esta\r\nverificada:";
            // 
            // txtNumeroAsientos
            // 
            txtNumeroAsientos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroAsientos.Location = new Point(124, 180);
            txtNumeroAsientos.Margin = new Padding(2);
            txtNumeroAsientos.Name = "txtNumeroAsientos";
            txtNumeroAsientos.Size = new Size(74, 22);
            txtNumeroAsientos.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(412, 134);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 16);
            label5.TabIndex = 70;
            label5.Text = "Esta Habilitado:";
            // 
            // btnNuevoModelo
            // 
            btnNuevoModelo.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevoModelo.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoModelo.ForeColor = Color.White;
            btnNuevoModelo.Image = (Image)resources.GetObject("btnNuevoModelo.Image");
            btnNuevoModelo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevoModelo.Location = new Point(280, 85);
            btnNuevoModelo.Margin = new Padding(2);
            btnNuevoModelo.Name = "btnNuevoModelo";
            btnNuevoModelo.Size = new Size(100, 30);
            btnNuevoModelo.TabIndex = 68;
            btnNuevoModelo.Text = "Nuevo";
            btnNuevoModelo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoModelo.UseVisualStyleBackColor = false;
            btnNuevoModelo.Click += btnNuevoModelo_Click;
            // 
            // btnNuevaMarca
            // 
            btnNuevaMarca.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevaMarca.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaMarca.ForeColor = Color.White;
            btnNuevaMarca.Image = (Image)resources.GetObject("btnNuevaMarca.Image");
            btnNuevaMarca.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevaMarca.Location = new Point(280, 55);
            btnNuevaMarca.Margin = new Padding(2);
            btnNuevaMarca.Name = "btnNuevaMarca";
            btnNuevaMarca.Size = new Size(100, 30);
            btnNuevaMarca.TabIndex = 67;
            btnNuevaMarca.Text = "Nuevo";
            btnNuevaMarca.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevaMarca.UseVisualStyleBackColor = false;
            btnNuevaMarca.Click += btnNuevaMarca_Click;
            // 
            // btnNuevoColor
            // 
            btnNuevoColor.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevoColor.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoColor.ForeColor = Color.White;
            btnNuevoColor.Image = (Image)resources.GetObject("btnNuevoColor.Image");
            btnNuevoColor.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevoColor.Location = new Point(280, 117);
            btnNuevoColor.Margin = new Padding(2);
            btnNuevoColor.Name = "btnNuevoColor";
            btnNuevoColor.Size = new Size(100, 30);
            btnNuevoColor.TabIndex = 66;
            btnNuevoColor.Text = "Nuevo";
            btnNuevoColor.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoColor.UseVisualStyleBackColor = false;
            btnNuevoColor.Click += btnNuevoColor_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(531, 217);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 39);
            btnGuardar.TabIndex = 63;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(412, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 16);
            label3.TabIndex = 54;
            label3.Text = "Esta disponible:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 155);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 49;
            label2.Text = "Año:";
            // 
            // txtPrecioRenta
            // 
            txtPrecioRenta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioRenta.Location = new Point(527, 30);
            txtPrecioRenta.Margin = new Padding(2);
            txtPrecioRenta.Name = "txtPrecioRenta";
            txtPrecioRenta.Size = new Size(89, 22);
            txtPrecioRenta.TabIndex = 25;
            // 
            // txtAñoSalida
            // 
            txtAñoSalida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAñoSalida.Location = new Point(124, 150);
            txtAñoSalida.Margin = new Padding(2);
            txtAñoSalida.Name = "txtAñoSalida";
            txtAñoSalida.Size = new Size(152, 22);
            txtAñoSalida.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(412, 65);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(102, 16);
            label15.TabIndex = 19;
            label15.Text = "Esta funcional:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(412, 31);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(110, 16);
            label14.TabIndex = 18;
            label14.Text = "Precio de renta:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 186);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(90, 16);
            label11.TabIndex = 15;
            label11.Text = "No. asientos:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 31);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 14;
            label10.Text = "Placa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 61);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 16);
            label9.TabIndex = 13;
            label9.Text = "Marca:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 91);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 16);
            label8.TabIndex = 12;
            label8.Text = "Modelo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 122);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 16);
            label7.TabIndex = 11;
            label7.Text = "Color:";
            // 
            // dgListaAutos
            // 
            dgListaAutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListaAutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListaAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListaAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListaAutos.Columns.AddRange(new DataGridViewColumn[] { clPlaca, clMarca, clModelo, clColor, clAño, clAsientos, clPrecio, clEstado, clDisponibilidad, clEliminar });
            dgListaAutos.Location = new Point(11, 395);
            dgListaAutos.Margin = new Padding(2);
            dgListaAutos.Name = "dgListaAutos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgListaAutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgListaAutos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F);
            dgListaAutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgListaAutos.RowTemplate.Height = 24;
            dgListaAutos.Size = new Size(1066, 339);
            dgListaAutos.TabIndex = 87;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(19, 33);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(106, 32);
            label31.TabIndex = 92;
            label31.Text = "Garaje";
            // 
            // clPlaca
            // 
            clPlaca.HeaderText = "Placa";
            clPlaca.MinimumWidth = 6;
            clPlaca.Name = "clPlaca";
            // 
            // clMarca
            // 
            clMarca.HeaderText = "Marca";
            clMarca.MinimumWidth = 6;
            clMarca.Name = "clMarca";
            // 
            // clModelo
            // 
            clModelo.HeaderText = "Modelo";
            clModelo.MinimumWidth = 6;
            clModelo.Name = "clModelo";
            // 
            // clColor
            // 
            clColor.HeaderText = "Color";
            clColor.MinimumWidth = 6;
            clColor.Name = "clColor";
            // 
            // clAño
            // 
            clAño.HeaderText = "Año fabricación";
            clAño.MinimumWidth = 6;
            clAño.Name = "clAño";
            // 
            // clAsientos
            // 
            clAsientos.HeaderText = "No. Asientos";
            clAsientos.MinimumWidth = 6;
            clAsientos.Name = "clAsientos";
            // 
            // clPrecio
            // 
            clPrecio.HeaderText = "Precio renta";
            clPrecio.MinimumWidth = 6;
            clPrecio.Name = "clPrecio";
            // 
            // clEstado
            // 
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            // 
            // clDisponibilidad
            // 
            clDisponibilidad.HeaderText = "Disponibilidad";
            clDisponibilidad.MinimumWidth = 6;
            clDisponibilidad.Name = "clDisponibilidad";
            clDisponibilidad.ReadOnly = true;
            // 
            // clEliminar
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            clEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            clEliminar.HeaderText = "Eliminar";
            clEliminar.Name = "clEliminar";
            clEliminar.ReadOnly = true;
            // 
            // frm_GarajeListaAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 745);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(pibImagenAuto);
            Controls.Add(groupBox3);
            Controls.Add(dgListaAutos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_GarajeListaAutos";
            Text = "Control del garaje";
            Load += ControlAutos_Load;
            ((System.ComponentModel.ISupportInitialize)pibImagenAuto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListaAutos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImagenAuto;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pibImagenAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNumeroAsientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoModelo;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Button btnNuevoColor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioRenta;
        private System.Windows.Forms.TextBox txtAñoSalida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgListaAutos;
        private System.Windows.Forms.Label label31;
        private TextBox txtPlaca;
        private Button btnBuscarPlaca;
        private CheckBox chbPlacaVerificada;
        private CheckBox chbHabilitado;
        private CheckBox chbDisponibilidad;
        private CheckBox chbFuncional;
        private DataGridViewTextBoxColumn clPlaca;
        private DataGridViewTextBoxColumn clMarca;
        private DataGridViewTextBoxColumn clModelo;
        private DataGridViewTextBoxColumn clColor;
        private DataGridViewTextBoxColumn clAño;
        private DataGridViewTextBoxColumn clAsientos;
        private DataGridViewTextBoxColumn clPrecio;
        private DataGridViewTextBoxColumn clEstado;
        private DataGridViewTextBoxColumn clDisponibilidad;
        private DataGridViewTextBoxColumn clEliminar;
    }
}
