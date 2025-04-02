namespace RentaRoad_Semestre3
{
    partial class VentanaPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCerrarSesion = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            textBox6 = new TextBox();
            label30 = new Label();
            textBox7 = new TextBox();
            label31 = new Label();
            button6 = new Button();
            panelContenedor = new Panel();
            panelVertical = new Panel();
            BtnFormSalidaGaraje = new Button();
            BtnFormEntregaAuto = new Button();
            BtnFormAcerca = new Button();
            BtnFormPagos = new Button();
            pictureBox1 = new PictureBox();
            BtnFormCaja = new Button();
            BtnFormProveedores = new Button();
            btnFormUsuarios = new Button();
            BtnFormClientes = new Button();
            BtnFormMantenimiento = new Button();
            BtnFormAdquisiciones = new Button();
            BtnFormRenta = new Button();
            BtnFormControlAutos = new Button();
            groupBox3.SuspendLayout();
            panelContenedor.SuspendLayout();
            panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(500, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 44);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(554, 32);
            label2.TabIndex = 8;
            label2.Text = "La apertura de caja del día de hoy está: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(544, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 9;
            label3.Text = "Realizada";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(9, 11, 14);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(869, 10);
            btnCerrarSesion.Margin = new Padding(2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(173, 39);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(button6);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(484, 257);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(318, 223);
            groupBox3.TabIndex = 63;
            groupBox3.TabStop = false;
            groupBox3.Text = "Apertura de caja";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 80, 200);
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(165, 147);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(122, 43);
            button5.TabIndex = 91;
            button5.Text = "Cancelar";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(174, 55);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(79, 22);
            textBox6.TabIndex = 85;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(34, 48);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(90, 34);
            label30.TabIndex = 84;
            label30.Text = "Monto total\r\nde apertura:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(174, 98);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(79, 22);
            textBox7.TabIndex = 83;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(34, 91);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(113, 34);
            label31.TabIndex = 82;
            label31.Text = "Tasa de\r\ncambio (C$/$):";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 80, 200);
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(29, 147);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(131, 43);
            button6.TabIndex = 88;
            button6.Text = "Abrir caja";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ButtonHighlight;
            panelContenedor.Controls.Add(groupBox3);
            panelContenedor.Controls.Add(btnCerrarSesion);
            panelContenedor.Controls.Add(label3);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1059, 723);
            panelContenedor.TabIndex = 4;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // panelVertical
            // 
            panelVertical.BackColor = Color.FromArgb(26, 32, 40);
            panelVertical.Controls.Add(BtnFormSalidaGaraje);
            panelVertical.Controls.Add(BtnFormEntregaAuto);
            panelVertical.Controls.Add(BtnFormAcerca);
            panelVertical.Controls.Add(BtnFormPagos);
            panelVertical.Controls.Add(pictureBox1);
            panelVertical.Controls.Add(BtnFormCaja);
            panelVertical.Controls.Add(BtnFormProveedores);
            panelVertical.Controls.Add(btnFormUsuarios);
            panelVertical.Controls.Add(BtnFormClientes);
            panelVertical.Controls.Add(BtnFormMantenimiento);
            panelVertical.Controls.Add(BtnFormAdquisiciones);
            panelVertical.Controls.Add(BtnFormRenta);
            panelVertical.Controls.Add(BtnFormControlAutos);
            panelVertical.Dock = DockStyle.Left;
            panelVertical.Location = new Point(0, 0);
            panelVertical.Margin = new Padding(2);
            panelVertical.Name = "panelVertical";
            panelVertical.Size = new Size(192, 723);
            panelVertical.TabIndex = 6;
            // 
            // BtnFormSalidaGaraje
            // 
            BtnFormSalidaGaraje.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormSalidaGaraje.FlatAppearance.BorderSize = 0;
            BtnFormSalidaGaraje.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormSalidaGaraje.FlatStyle = FlatStyle.Flat;
            BtnFormSalidaGaraje.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormSalidaGaraje.ForeColor = Color.White;
            BtnFormSalidaGaraje.Location = new Point(2, 317);
            BtnFormSalidaGaraje.Margin = new Padding(2);
            BtnFormSalidaGaraje.Name = "BtnFormSalidaGaraje";
            BtnFormSalidaGaraje.Size = new Size(188, 30);
            BtnFormSalidaGaraje.TabIndex = 16;
            BtnFormSalidaGaraje.Text = "Salida de garaje";
            BtnFormSalidaGaraje.UseVisualStyleBackColor = false;
            BtnFormSalidaGaraje.Click += BtnFormSalidaGaraje_Click;
            // 
            // BtnFormEntregaAuto
            // 
            BtnFormEntregaAuto.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormEntregaAuto.FlatAppearance.BorderSize = 0;
            BtnFormEntregaAuto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormEntregaAuto.FlatStyle = FlatStyle.Flat;
            BtnFormEntregaAuto.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormEntregaAuto.ForeColor = Color.White;
            BtnFormEntregaAuto.Location = new Point(2, 355);
            BtnFormEntregaAuto.Margin = new Padding(2);
            BtnFormEntregaAuto.Name = "BtnFormEntregaAuto";
            BtnFormEntregaAuto.Size = new Size(188, 30);
            BtnFormEntregaAuto.TabIndex = 15;
            BtnFormEntregaAuto.Text = "Entrega de auto";
            BtnFormEntregaAuto.UseVisualStyleBackColor = false;
            BtnFormEntregaAuto.Click += BtnFormEntregaAuto_Click;
            // 
            // BtnFormAcerca
            // 
            BtnFormAcerca.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormAcerca.Cursor = Cursors.Hand;
            BtnFormAcerca.FlatAppearance.BorderSize = 0;
            BtnFormAcerca.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormAcerca.FlatStyle = FlatStyle.Flat;
            BtnFormAcerca.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormAcerca.ForeColor = Color.White;
            BtnFormAcerca.Location = new Point(2, 546);
            BtnFormAcerca.Margin = new Padding(2);
            BtnFormAcerca.Name = "BtnFormAcerca";
            BtnFormAcerca.Size = new Size(188, 30);
            BtnFormAcerca.TabIndex = 9;
            BtnFormAcerca.Text = "Acerca de";
            BtnFormAcerca.UseVisualStyleBackColor = false;
            BtnFormAcerca.Click += BtnFormAcerca_Click;
            // 
            // BtnFormPagos
            // 
            BtnFormPagos.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormPagos.FlatAppearance.BorderSize = 0;
            BtnFormPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormPagos.FlatStyle = FlatStyle.Flat;
            BtnFormPagos.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormPagos.ForeColor = Color.White;
            BtnFormPagos.Location = new Point(2, 241);
            BtnFormPagos.Margin = new Padding(2);
            BtnFormPagos.Name = "BtnFormPagos";
            BtnFormPagos.Size = new Size(188, 30);
            BtnFormPagos.TabIndex = 13;
            BtnFormPagos.Text = "Registro placa";
            BtnFormPagos.UseVisualStyleBackColor = false;
            BtnFormPagos.Click += BtnFormPagos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnFormCaja
            // 
            BtnFormCaja.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormCaja.FlatAppearance.BorderSize = 0;
            BtnFormCaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormCaja.FlatStyle = FlatStyle.Flat;
            BtnFormCaja.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormCaja.ForeColor = Color.White;
            BtnFormCaja.Location = new Point(2, 279);
            BtnFormCaja.Margin = new Padding(2);
            BtnFormCaja.Name = "BtnFormCaja";
            BtnFormCaja.Size = new Size(188, 30);
            BtnFormCaja.TabIndex = 5;
            BtnFormCaja.Text = "Caja";
            BtnFormCaja.UseVisualStyleBackColor = false;
            BtnFormCaja.Click += BtnFormCaja_Click;
            // 
            // BtnFormProveedores
            // 
            BtnFormProveedores.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormProveedores.Cursor = Cursors.Hand;
            BtnFormProveedores.FlatAppearance.BorderSize = 0;
            BtnFormProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormProveedores.FlatStyle = FlatStyle.Flat;
            BtnFormProveedores.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormProveedores.ForeColor = Color.White;
            BtnFormProveedores.Location = new Point(2, 432);
            BtnFormProveedores.Margin = new Padding(2);
            BtnFormProveedores.Name = "BtnFormProveedores";
            BtnFormProveedores.Size = new Size(188, 30);
            BtnFormProveedores.TabIndex = 10;
            BtnFormProveedores.Text = "Proveedores";
            BtnFormProveedores.UseVisualStyleBackColor = false;
            BtnFormProveedores.Click += BtnFormProveedores_Click;
            // 
            // btnFormUsuarios
            // 
            btnFormUsuarios.BackColor = Color.FromArgb(9, 11, 14);
            btnFormUsuarios.Cursor = Cursors.Hand;
            btnFormUsuarios.FlatAppearance.BorderSize = 0;
            btnFormUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFormUsuarios.FlatStyle = FlatStyle.Flat;
            btnFormUsuarios.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormUsuarios.ForeColor = Color.White;
            btnFormUsuarios.Location = new Point(2, 470);
            btnFormUsuarios.Margin = new Padding(2);
            btnFormUsuarios.Name = "btnFormUsuarios";
            btnFormUsuarios.Size = new Size(188, 30);
            btnFormUsuarios.TabIndex = 12;
            btnFormUsuarios.Text = "Usuarios";
            btnFormUsuarios.UseVisualStyleBackColor = false;
            btnFormUsuarios.Click += BtnFormUsuarios_Click;
            // 
            // BtnFormClientes
            // 
            BtnFormClientes.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormClientes.Cursor = Cursors.Hand;
            BtnFormClientes.FlatAppearance.BorderSize = 0;
            BtnFormClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormClientes.FlatStyle = FlatStyle.Flat;
            BtnFormClientes.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormClientes.ForeColor = Color.White;
            BtnFormClientes.Location = new Point(2, 165);
            BtnFormClientes.Margin = new Padding(2);
            BtnFormClientes.Name = "BtnFormClientes";
            BtnFormClientes.Size = new Size(188, 30);
            BtnFormClientes.TabIndex = 11;
            BtnFormClientes.Text = "Cliente";
            BtnFormClientes.UseVisualStyleBackColor = false;
            BtnFormClientes.Click += BtnFormClientes_Click;
            // 
            // BtnFormMantenimiento
            // 
            BtnFormMantenimiento.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormMantenimiento.Cursor = Cursors.Hand;
            BtnFormMantenimiento.FlatAppearance.BorderSize = 0;
            BtnFormMantenimiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormMantenimiento.FlatStyle = FlatStyle.Flat;
            BtnFormMantenimiento.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormMantenimiento.ForeColor = Color.White;
            BtnFormMantenimiento.Location = new Point(2, 508);
            BtnFormMantenimiento.Margin = new Padding(2);
            BtnFormMantenimiento.Name = "BtnFormMantenimiento";
            BtnFormMantenimiento.Size = new Size(188, 30);
            BtnFormMantenimiento.TabIndex = 8;
            BtnFormMantenimiento.Text = "Mantenimiento";
            BtnFormMantenimiento.UseVisualStyleBackColor = false;
            BtnFormMantenimiento.Click += BtnFormMantenimiento_Click;
            // 
            // BtnFormAdquisiciones
            // 
            BtnFormAdquisiciones.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormAdquisiciones.FlatAppearance.BorderSize = 0;
            BtnFormAdquisiciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormAdquisiciones.FlatStyle = FlatStyle.Flat;
            BtnFormAdquisiciones.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormAdquisiciones.ForeColor = Color.White;
            BtnFormAdquisiciones.Location = new Point(2, 393);
            BtnFormAdquisiciones.Margin = new Padding(2);
            BtnFormAdquisiciones.Name = "BtnFormAdquisiciones";
            BtnFormAdquisiciones.Size = new Size(188, 30);
            BtnFormAdquisiciones.TabIndex = 5;
            BtnFormAdquisiciones.Text = "Adquisiciones";
            BtnFormAdquisiciones.UseVisualStyleBackColor = false;
            BtnFormAdquisiciones.Click += BtnFormAdquisicion_Click;
            // 
            // BtnFormRenta
            // 
            BtnFormRenta.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormRenta.FlatAppearance.BorderSize = 0;
            BtnFormRenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormRenta.FlatStyle = FlatStyle.Flat;
            BtnFormRenta.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormRenta.ForeColor = Color.White;
            BtnFormRenta.Location = new Point(2, 127);
            BtnFormRenta.Margin = new Padding(2);
            BtnFormRenta.Name = "BtnFormRenta";
            BtnFormRenta.Size = new Size(188, 30);
            BtnFormRenta.TabIndex = 5;
            BtnFormRenta.Text = "Renta";
            BtnFormRenta.UseVisualStyleBackColor = false;
            BtnFormRenta.Click += BtnFormRenta_Click;
            // 
            // BtnFormControlAutos
            // 
            BtnFormControlAutos.BackColor = Color.FromArgb(9, 11, 14);
            BtnFormControlAutos.Cursor = Cursors.Hand;
            BtnFormControlAutos.FlatAppearance.BorderSize = 0;
            BtnFormControlAutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            BtnFormControlAutos.FlatStyle = FlatStyle.Flat;
            BtnFormControlAutos.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFormControlAutos.ForeColor = Color.White;
            BtnFormControlAutos.Location = new Point(2, 203);
            BtnFormControlAutos.Margin = new Padding(2);
            BtnFormControlAutos.Name = "BtnFormControlAutos";
            BtnFormControlAutos.Size = new Size(188, 30);
            BtnFormControlAutos.TabIndex = 1;
            BtnFormControlAutos.Text = "Garaje";
            BtnFormControlAutos.UseVisualStyleBackColor = false;
            BtnFormControlAutos.Click += BtnFormGaraje_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 723);
            Controls.Add(panelVertical);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "VentanaPrincipal";
            Text = "RentaRoad - Ventana principal";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Button BtnFormSalidaGaraje;
        private System.Windows.Forms.Button BtnFormEntregaAuto;
        private System.Windows.Forms.Button BtnFormAcerca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFormCaja;
        private System.Windows.Forms.Button BtnFormProveedores;
        private System.Windows.Forms.Button btnFormUsuarios;
        private System.Windows.Forms.Button BtnFormClientes;
        private System.Windows.Forms.Button BtnFormMantenimiento;
        private System.Windows.Forms.Button BtnFormAdquisiciones;
        private System.Windows.Forms.Button BtnFormRenta;
        private System.Windows.Forms.Button BtnFormControlAutos;
        private System.Windows.Forms.Button BtnFormPagos;
    }
}

