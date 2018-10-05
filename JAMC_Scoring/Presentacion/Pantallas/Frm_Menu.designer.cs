using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Menu
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.pnl_izquierdo = new Gizmox.WebGUI.Forms.Panel();
            this.btn_usuario = new Gizmox.WebGUI.Forms.Button();
            this.cm_usuario = new Gizmox.WebGUI.Forms.ContextMenu();
            this.mn_cambiar_clave = new Gizmox.WebGUI.Forms.MenuItem();
            this.mn_cerrar_sesion = new Gizmox.WebGUI.Forms.MenuItem();
            this.mn_actualizar_menu = new Gizmox.WebGUI.Forms.MenuItem();
            this.btn_proceso = new Gizmox.WebGUI.Forms.Button();
            this.cm_procesos = new Gizmox.WebGUI.Forms.ContextMenu();
            this.mn_score_cliente = new Gizmox.WebGUI.Forms.MenuItem();
            this.pictureBox1 = new Gizmox.WebGUI.Forms.PictureBox();
            this.btn_mantenimiento = new Gizmox.WebGUI.Forms.Button();
            this.cm_mantenimientos = new Gizmox.WebGUI.Forms.ContextMenu();
            this.mn_calificacion_cliente = new Gizmox.WebGUI.Forms.MenuItem();
            this.mn_usuarios = new Gizmox.WebGUI.Forms.MenuItem();
            this.pnl_izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_izquierdo
            // 
            this.pnl_izquierdo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnl_izquierdo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Black);
            this.pnl_izquierdo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.pnl_izquierdo.Controls.Add(this.btn_usuario);
            this.pnl_izquierdo.Controls.Add(this.btn_proceso);
            this.pnl_izquierdo.Controls.Add(this.pictureBox1);
            this.pnl_izquierdo.Controls.Add(this.btn_mantenimiento);
            this.pnl_izquierdo.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnl_izquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnl_izquierdo.Name = "pnl_izquierdo";
            this.pnl_izquierdo.Size = new System.Drawing.Size(80, 539);
            this.pnl_izquierdo.TabIndex = 0;
            // 
            // btn_usuario
            // 
            this.btn_usuario.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btn_usuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuario.DropDownMenu = this.cm_usuario;
            this.btn_usuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_usuario.ForeColor = System.Drawing.Color.Black;
            this.btn_usuario.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_usuario.Image"));
            this.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuario.Location = new System.Drawing.Point(6, 489);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(65, 40);
            this.btn_usuario.TabIndex = 0;
            this.btn_usuario.Text = "  ";
            this.btn_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuario.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            // 
            // cm_usuario
            // 
            this.cm_usuario.MenuItems.AddRange(new Gizmox.WebGUI.Forms.MenuItem[] {
            this.mn_cambiar_clave,
            this.mn_cerrar_sesion,
            this.mn_actualizar_menu});
            // 
            // mn_cambiar_clave
            // 
            this.mn_cambiar_clave.Index = 0;
            this.mn_cambiar_clave.Text = "Cambiar Clave";
            // 
            // mn_cerrar_sesion
            // 
            this.mn_cerrar_sesion.Index = 1;
            this.mn_cerrar_sesion.Text = "Cerrar Sesión";
            this.mn_cerrar_sesion.Click += new System.EventHandler(this.mn_cerrar_sesion_Click);
            // 
            // mn_actualizar_menu
            // 
            this.mn_actualizar_menu.Index = 2;
            this.mn_actualizar_menu.Text = "Actualizar Menu";
            // 
            // btn_proceso
            // 
            this.btn_proceso.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btn_proceso.BackColor = System.Drawing.Color.Transparent;
            this.btn_proceso.DropDownMenu = this.cm_procesos;
            this.btn_proceso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_proceso.ForeColor = System.Drawing.Color.Black;
            this.btn_proceso.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_proceso.Image"));
            this.btn_proceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proceso.Location = new System.Drawing.Point(6, 144);
            this.btn_proceso.Name = "btn_proceso";
            this.btn_proceso.Size = new System.Drawing.Size(65, 40);
            this.btn_proceso.TabIndex = 0;
            this.btn_proceso.Text = "  Procesos";
            this.btn_proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proceso.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            // 
            // cm_procesos
            // 
            this.cm_procesos.MenuItems.AddRange(new Gizmox.WebGUI.Forms.MenuItem[] {
            this.mn_score_cliente});
            // 
            // mn_score_cliente
            // 
            this.mn_score_cliente.Index = 0;
            this.mn_score_cliente.Text = "Score de Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand;
            this.pictureBox1.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pictureBox1.Image"));
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 40);
            this.pictureBox1.SizeMode = Gizmox.WebGUI.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_mantenimiento
            // 
            this.btn_mantenimiento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btn_mantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.btn_mantenimiento.DropDownMenu = this.cm_mantenimientos;
            this.btn_mantenimiento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_mantenimiento.ForeColor = System.Drawing.Color.Black;
            this.btn_mantenimiento.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_mantenimiento.Image"));
            this.btn_mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mantenimiento.Location = new System.Drawing.Point(6, 99);
            this.btn_mantenimiento.Name = "btn_mantenimiento";
            this.btn_mantenimiento.Size = new System.Drawing.Size(65, 40);
            this.btn_mantenimiento.TabIndex = 0;
            this.btn_mantenimiento.Text = "  Mantenimientos";
            this.btn_mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mantenimiento.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // cm_mantenimientos
            // 
            this.cm_mantenimientos.MenuItems.AddRange(new Gizmox.WebGUI.Forms.MenuItem[] {
            this.mn_calificacion_cliente,
            this.mn_usuarios});
            // 
            // mn_calificacion_cliente
            // 
            this.mn_calificacion_cliente.Index = 0;
            this.mn_calificacion_cliente.Text = "Tipos Calificaciones";
            this.mn_calificacion_cliente.Click += new System.EventHandler(this.mn_calificacion_cliente_Click);
            // 
            // mn_usuarios
            // 
            this.mn_usuarios.Index = 1;
            this.mn_usuarios.Text = "Usuarios";
            this.mn_usuarios.Click += new System.EventHandler(this.mn_usuarios_Click);
            // 
            // Frm_Menu
            // 
            this.Controls.Add(this.pnl_izquierdo);
            this.IsMdiContainer = true;
            this.Size = new System.Drawing.Size(883, 539);
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.pnl_izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel pnl_izquierdo;
        private Gizmox.WebGUI.Forms.Button btn_mantenimiento;
        private Gizmox.WebGUI.Forms.ContextMenu cm_mantenimientos;
        private Gizmox.WebGUI.Forms.MenuItem mn_calificacion_cliente;
        private Gizmox.WebGUI.Forms.PictureBox pictureBox1;
        private Gizmox.WebGUI.Forms.Button btn_proceso;
        private Gizmox.WebGUI.Forms.ContextMenu cm_procesos;
        private Gizmox.WebGUI.Forms.MenuItem mn_score_cliente;
        private Gizmox.WebGUI.Forms.Button btn_usuario;
        private Gizmox.WebGUI.Forms.ContextMenu cm_usuario;
        private Gizmox.WebGUI.Forms.MenuItem mn_cambiar_clave;
        private Gizmox.WebGUI.Forms.MenuItem mn_cerrar_sesion;
        private Gizmox.WebGUI.Forms.MenuItem mn_actualizar_menu;
        private Gizmox.WebGUI.Forms.MenuItem mn_usuarios;
	}
}
