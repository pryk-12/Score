using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Mant_Tipos_Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mant_Tipos_Calificaciones));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.btn_nuevo = new Gizmox.WebGUI.Forms.Button();
            this.DESCRIPCION = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar = new Gizmox.WebGUI.Forms.TextBox();
            this.btn_editar = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.PUNTOS = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.lbl_total = new Gizmox.WebGUI.Forms.Label();
            this.ID = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.cb_buscar = new Gizmox.WebGUI.Forms.ComboBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.dg = new Gizmox.WebGUI.Forms.DataGridView();
            this.ESTADO = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new Gizmox.WebGUI.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
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
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            dataGridViewCellStyle1.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle1;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 400;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_buscar.Location = new System.Drawing.Point(168, 63);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(220, 21);
            this.txt_buscar.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 48);
            this.panel1.TabIndex = 0;
            // 
            // PUNTOS
            // 
            this.PUNTOS.DataPropertyName = "PUNTOS";
            dataGridViewCellStyle2.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.PUNTOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.PUNTOS.HeaderText = "PUNTOS";
            this.PUNTOS.Name = "PUNTOS";
            this.PUNTOS.ReadOnly = true;
            this.PUNTOS.Width = 80;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(454, 66);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(195, 18);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle3.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // cb_buscar
            // 
            this.cb_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_buscar.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "",
            "ID",
            "DESCRIPCION"});
            this.cb_buscar.Location = new System.Drawing.Point(59, 63);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(106, 21);
            this.cb_buscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
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
            this.DESCRIPCION,
            this.PUNTOS,
            this.ESTADO});
            dataGridViewCellStyle5.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.ItemsPerPage = 100;
            this.dg.Location = new System.Drawing.Point(9, 90);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(644, 320);
            this.dg.TabIndex = 1;
            this.dg.Theme = "Vista";
            this.dg.DoubleClick += new System.EventHandler(this.dg_DoubleClick);
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            dataGridViewCellStyle4.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this.ESTADO.DefaultCellStyle = dataGridViewCellStyle4;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(391, 62);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(71, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "  Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Frm_Mant_Tipos_Calificaciones
            // 
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_buscar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_buscar);
            this.Size = new System.Drawing.Size(665, 431);
            this.Text = "Mantenimiento Tipos de Calificiones";
            this.Load += new System.EventHandler(this.Frm_Mant_Tipos_Calificaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Button btn_nuevo;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private Gizmox.WebGUI.Forms.TextBox txt_buscar;
        private Gizmox.WebGUI.Forms.Button btn_editar;
        private Gizmox.WebGUI.Forms.Panel panel1;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn PUNTOS;
        private Gizmox.WebGUI.Forms.Label lbl_total;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn ID;
        private Gizmox.WebGUI.Forms.ComboBox cb_buscar;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.DataGridView dg;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn ESTADO;
        private Gizmox.WebGUI.Forms.Button btn_buscar;
	}
}
