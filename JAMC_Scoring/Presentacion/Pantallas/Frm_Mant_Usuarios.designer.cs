using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Mant_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mant_Usuarios));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.btn_editar = new Gizmox.WebGUI.Forms.Button();
            this.btn_nuevo = new Gizmox.WebGUI.Forms.Button();
            this.dg = new Gizmox.WebGUI.Forms.DataGridView();
            this.ID = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.CLAVE = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar = new Gizmox.WebGUI.Forms.TextBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.lbl_total = new Gizmox.WebGUI.Forms.Label();
            this.btn_buscar = new Gizmox.WebGUI.Forms.Button();
            this.cb_buscar = new Gizmox.WebGUI.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_editar.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_editar.Image"));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(98, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(89, 41);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.Text = "  Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_nuevo.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_nuevo.Image"));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(7, 2);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(89, 41);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "  Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.dg.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.USUARIO,
            this.CLAVE,
            this.SEXO,
            this.ESTADO});
            dataGridViewCellStyle7.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle7;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.ItemsPerPage = 100;
            this.dg.Location = new System.Drawing.Point(9, 89);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(739, 350);
            this.dg.TabIndex = 1;
            this.dg.Theme = "Vista";
            this.dg.DoubleClick += new System.EventHandler(this.dg_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle2.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle2;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 400;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "USUARIO";
            dataGridViewCellStyle3.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.USUARIO.DefaultCellStyle = dataGridViewCellStyle3;
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Width = 80;
            // 
            // CLAVE
            // 
            this.CLAVE.DataPropertyName = "CLAVE";
            this.CLAVE.DefaultCellStyle = dataGridViewCellStyle4;
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.ReadOnly = true;
            this.CLAVE.Visible = false;
            // 
            // SEXO
            // 
            this.SEXO.DataPropertyName = "SEXO";
            dataGridViewCellStyle5.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.SEXO.DefaultCellStyle = dataGridViewCellStyle5;
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            dataGridViewCellStyle6.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.ESTADO.DefaultCellStyle = dataGridViewCellStyle6;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_buscar.Location = new System.Drawing.Point(168, 64);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(299, 21);
            this.txt_buscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(512, 67);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(232, 18);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(469, 63);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(71, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "  Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cb_buscar
            // 
            this.cb_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_buscar.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "",
            "ID",
            "NOMBRE",
            "USUARIO"});
            this.cb_buscar.Location = new System.Drawing.Point(59, 64);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(106, 21);
            this.cb_buscar.TabIndex = 4;
            // 
            // Frm_Mant_Usuarios
            // 
            this.Controls.Add(this.cb_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(760, 454);
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.Frm_Mant_Usuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel panel1;
        private Gizmox.WebGUI.Forms.Button btn_editar;
        private Gizmox.WebGUI.Forms.Button btn_nuevo;
        private Gizmox.WebGUI.Forms.DataGridView dg;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn ID;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn NOMBRE;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn USUARIO;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn CLAVE;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn SEXO;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn ESTADO;
        private Gizmox.WebGUI.Forms.TextBox txt_buscar;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.Label lbl_total;
        private Gizmox.WebGUI.Forms.Button btn_buscar;
        private Gizmox.WebGUI.Forms.ComboBox cb_buscar;
	}
}
