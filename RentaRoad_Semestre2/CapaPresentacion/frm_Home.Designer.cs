namespace RentaRoad_Semestre3
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            menuNavegacion = new MenuStrip();
            optionGaraje = new ToolStripMenuItem();
            optionListaDeAutos = new ToolStripMenuItem();
            optionSalidaDeGaraje = new ToolStripMenuItem();
            optionEntregaDeAuto = new ToolStripMenuItem();
            optionRenta = new ToolStripMenuItem();
            optionClientes = new ToolStripMenuItem();
            optionUsuarios = new ToolStripMenuItem();
            optionProveedores = new ToolStripMenuItem();
            optionCaja = new ToolStripMenuItem();
            optionAdquisiciones = new ToolStripMenuItem();
            optionAcercaDe = new ToolStripMenuItem();
            panelVertical = new Panel();
            label1 = new Label();
            btnCerrarSesion = new Button();
            panelSuperior = new Panel();
            panelContenedor = new Panel();
            optionMatenimiento = new ToolStripMenuItem();
            menuNavegacion.SuspendLayout();
            panelVertical.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // menuNavegacion
            // 
            menuNavegacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuNavegacion.AutoSize = false;
            menuNavegacion.BackColor = Color.FromArgb(56, 62, 70);
            menuNavegacion.Dock = DockStyle.None;
            menuNavegacion.Items.AddRange(new ToolStripItem[] { optionGaraje, optionRenta, optionClientes, optionUsuarios, optionProveedores, optionCaja, optionAdquisiciones, optionMatenimiento, optionAcercaDe });
            menuNavegacion.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuNavegacion.Location = new Point(0, 125);
            menuNavegacion.Name = "menuNavegacion";
            menuNavegacion.Size = new Size(230, 810);
            menuNavegacion.TabIndex = 64;
            menuNavegacion.Text = "menuStrip1";
            // 
            // optionGaraje
            // 
            optionGaraje.BackColor = Color.FromArgb(26, 32, 40);
            optionGaraje.DropDownItems.AddRange(new ToolStripItem[] { optionListaDeAutos, optionSalidaDeGaraje, optionEntregaDeAuto });
            optionGaraje.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionGaraje.ForeColor = Color.White;
            optionGaraje.Margin = new Padding(0, 2, 0, 2);
            optionGaraje.Name = "optionGaraje";
            optionGaraje.Padding = new Padding(4, 5, 4, 5);
            optionGaraje.Size = new Size(223, 39);
            optionGaraje.Text = "Garaje";
            // 
            // optionListaDeAutos
            // 
            optionListaDeAutos.BackColor = Color.FromArgb(26, 32, 40);
            optionListaDeAutos.ForeColor = Color.White;
            optionListaDeAutos.Margin = new Padding(0, 1, 0, 1);
            optionListaDeAutos.Name = "optionListaDeAutos";
            optionListaDeAutos.Padding = new Padding(0, 2, 0, 2);
            optionListaDeAutos.Size = new Size(220, 32);
            optionListaDeAutos.Text = "Lista de autos";
            optionListaDeAutos.Click += optionListaDeAutos_Click;
            // 
            // optionSalidaDeGaraje
            // 
            optionSalidaDeGaraje.BackColor = Color.FromArgb(26, 32, 40);
            optionSalidaDeGaraje.ForeColor = Color.White;
            optionSalidaDeGaraje.Margin = new Padding(0, 1, 0, 1);
            optionSalidaDeGaraje.Name = "optionSalidaDeGaraje";
            optionSalidaDeGaraje.Padding = new Padding(0, 2, 0, 2);
            optionSalidaDeGaraje.Size = new Size(220, 32);
            optionSalidaDeGaraje.Text = "Salida de garaje";
            optionSalidaDeGaraje.Click += optionSalidaGaraje_Click;
            // 
            // optionEntregaDeAuto
            // 
            optionEntregaDeAuto.BackColor = Color.FromArgb(26, 32, 40);
            optionEntregaDeAuto.ForeColor = Color.White;
            optionEntregaDeAuto.Margin = new Padding(0, 1, 0, 1);
            optionEntregaDeAuto.Name = "optionEntregaDeAuto";
            optionEntregaDeAuto.Padding = new Padding(0, 2, 0, 2);
            optionEntregaDeAuto.Size = new Size(220, 32);
            optionEntregaDeAuto.Text = "Entrega de auto";
            optionEntregaDeAuto.Click += optionEntregaAuto_Click;
            // 
            // optionRenta
            // 
            optionRenta.BackColor = Color.FromArgb(26, 32, 40);
            optionRenta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionRenta.ForeColor = Color.White;
            optionRenta.Margin = new Padding(0, 2, 0, 2);
            optionRenta.Name = "optionRenta";
            optionRenta.Padding = new Padding(4, 5, 4, 5);
            optionRenta.Size = new Size(223, 39);
            optionRenta.Text = "Renta";
            optionRenta.Click += optionRenta_Click;
            // 
            // optionClientes
            // 
            optionClientes.BackColor = Color.FromArgb(26, 32, 40);
            optionClientes.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionClientes.ForeColor = Color.White;
            optionClientes.Margin = new Padding(0, 2, 0, 2);
            optionClientes.Name = "optionClientes";
            optionClientes.Padding = new Padding(4, 5, 4, 5);
            optionClientes.Size = new Size(223, 39);
            optionClientes.Text = "Clientes";
            optionClientes.Click += optionClientes_Click;
            // 
            // optionUsuarios
            // 
            optionUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            optionUsuarios.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionUsuarios.ForeColor = Color.White;
            optionUsuarios.Margin = new Padding(0, 2, 0, 2);
            optionUsuarios.Name = "optionUsuarios";
            optionUsuarios.Padding = new Padding(4, 5, 4, 5);
            optionUsuarios.Size = new Size(223, 39);
            optionUsuarios.Text = "Usuarios";
            optionUsuarios.Click += optionUsuarios_Click;
            // 
            // optionProveedores
            // 
            optionProveedores.BackColor = Color.FromArgb(26, 32, 40);
            optionProveedores.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionProveedores.ForeColor = Color.White;
            optionProveedores.Margin = new Padding(0, 2, 0, 2);
            optionProveedores.Name = "optionProveedores";
            optionProveedores.Padding = new Padding(4, 5, 4, 5);
            optionProveedores.Size = new Size(223, 39);
            optionProveedores.Text = "Proveedores";
            optionProveedores.Click += optionProveedores_Click;
            // 
            // optionCaja
            // 
            optionCaja.BackColor = Color.FromArgb(26, 32, 40);
            optionCaja.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionCaja.ForeColor = Color.White;
            optionCaja.Margin = new Padding(0, 2, 0, 2);
            optionCaja.Name = "optionCaja";
            optionCaja.Padding = new Padding(4, 5, 4, 5);
            optionCaja.Size = new Size(223, 39);
            optionCaja.Text = "Caja";
            optionCaja.Click += optionCaja_Click;
            // 
            // optionAdquisiciones
            // 
            optionAdquisiciones.BackColor = Color.FromArgb(26, 32, 40);
            optionAdquisiciones.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionAdquisiciones.ForeColor = Color.White;
            optionAdquisiciones.Margin = new Padding(0, 2, 0, 2);
            optionAdquisiciones.Name = "optionAdquisiciones";
            optionAdquisiciones.Padding = new Padding(4, 5, 4, 5);
            optionAdquisiciones.Size = new Size(223, 39);
            optionAdquisiciones.Text = "Adquisiciones";
            optionAdquisiciones.Click += optionAdquisicion_Click;
            // 
            // optionAcercaDe
            // 
            optionAcercaDe.BackColor = Color.FromArgb(26, 32, 40);
            optionAcercaDe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionAcercaDe.ForeColor = Color.White;
            optionAcercaDe.Margin = new Padding(0, 2, 0, 2);
            optionAcercaDe.Name = "optionAcercaDe";
            optionAcercaDe.Padding = new Padding(4, 5, 4, 5);
            optionAcercaDe.Size = new Size(223, 39);
            optionAcercaDe.Text = "Acerca de";
            optionAcercaDe.Click += optionAcerca_Click;
            // 
            // panelVertical
            // 
            panelVertical.BackColor = Color.FromArgb(26, 32, 40);
            panelVertical.Controls.Add(label1);
            panelVertical.Controls.Add(menuNavegacion);
            panelVertical.Dock = DockStyle.Left;
            panelVertical.Location = new Point(0, 0);
            panelVertical.Margin = new Padding(2);
            panelVertical.Name = "panelVertical";
            panelVertical.Size = new Size(230, 828);
            panelVertical.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(45, 44);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 66;
            label1.Text = "RentARoad";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.FromArgb(9, 11, 14);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(947, 3);
            btnCerrarSesion.Margin = new Padding(2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(146, 39);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 32, 40);
            panelSuperior.Controls.Add(btnCerrarSesion);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(230, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1104, 44);
            panelSuperior.TabIndex = 65;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContenedor.BackColor = SystemColors.ButtonHighlight;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContenedor.Location = new Point(230, 44);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1104, 784);
            panelContenedor.TabIndex = 66;
            // 
            // optionMatenimiento
            // 
            optionMatenimiento.BackColor = Color.FromArgb(26, 32, 40);
            optionMatenimiento.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            optionMatenimiento.ForeColor = Color.White;
            optionMatenimiento.Margin = new Padding(0, 2, 0, 2);
            optionMatenimiento.Name = "optionMatenimiento";
            optionMatenimiento.Padding = new Padding(4, 5, 4, 5);
            optionMatenimiento.Size = new Size(223, 39);
            optionMatenimiento.Text = "Matenimiento";
            optionMatenimiento.Click += optionMantenimiento_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 828);
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);
            Controls.Add(panelVertical);
            MainMenuStrip = menuNavegacion;
            Margin = new Padding(2);
            MinimumSize = new Size(1315, 867);
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentaRoad - Ventana principal";
            menuNavegacion.ResumeLayout(false);
            menuNavegacion.PerformLayout();
            panelVertical.ResumeLayout(false);
            panelVertical.PerformLayout();
            panelSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuNavegacion;
        private ToolStripMenuItem optionGaraje;
        private ToolStripMenuItem optionListaDeAutos;
        private ToolStripMenuItem optionSalidaDeGaraje;
        private ToolStripMenuItem optionRenta;
        private Panel panelVertical;
        private ToolStripMenuItem optionClientes;
        private ToolStripMenuItem optionUsuarios;
        private ToolStripMenuItem optionProveedores;
        private ToolStripMenuItem optionCaja;
        private ToolStripMenuItem optionAdquisiciones;
        private ToolStripMenuItem optionEntregaDeAuto;
        private ToolStripMenuItem optionAcercaDe;
        private Button btnCerrarSesion;
        private Panel panelSuperior;
        private Label label1;
        private Panel panelContenedor;
        private ToolStripMenuItem optionMatenimiento;
    }
}

