using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Porciento_Ponderaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Porciento_Ponderaciones));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.btn_guardar = new Gizmox.WebGUI.Forms.Button();
            this.DESCRIPCION = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this._ID = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.PORCIENTO = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dg = new Gizmox.WebGUI.Forms.DataGridView();
            this.lbl_total = new Gizmox.WebGUI.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_guardar.Image"));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(8, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 41);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "  Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.DESCRIPCION.Width = 390;
            // 
            // _ID
            // 
            this._ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            this._ID.DefaultCellStyle = dataGridViewCellStyle2;
            this._ID.HeaderText = "ID";
            this._ID.Name = "_ID";
            this._ID.ReadOnly = true;
            this._ID.Width = 50;
            // 
            // PORCIENTO
            // 
            this.PORCIENTO.DataPropertyName = "PORCIENTO";
            dataGridViewCellStyle3.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            dataGridViewCellStyle3.NullValue = null;
            this.PORCIENTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.PORCIENTO.HeaderText = "PORCIENTO";
            this.PORCIENTO.Name = "PORCIENTO";
            this.PORCIENTO.Width = 70;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Bottom | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.dg.AutoGenerateColumns = false;
            this.dg.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this._ID,
            this.DESCRIPCION,
            this.PORCIENTO});
            dataGridViewCellStyle4.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.FormatProvider = new System.Globalization.CultureInfo("es-DO");
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.ItemsPerPage = 100;
            this.dg.Location = new System.Drawing.Point(9, 61);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(519, 324);
            this.dg.TabIndex = 1;
            this.dg.Theme = "Vista";
            this.dg.KeyPress += new Gizmox.WebGUI.Forms.KeyPressEventHandler(this.dg_KeyPress);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(334, 391);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(195, 18);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_Porciento_Ponderaciones
            // 
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(539, 428);
            this.Load += new System.EventHandler(this.Frm_Porciento_Ponderaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Panel panel1;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn _ID;
        private Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn PORCIENTO;
        private Gizmox.WebGUI.Forms.DataGridView dg;
        private Gizmox.WebGUI.Forms.Button btn_guardar;
        private Gizmox.WebGUI.Forms.Label lbl_total;
	}
}
