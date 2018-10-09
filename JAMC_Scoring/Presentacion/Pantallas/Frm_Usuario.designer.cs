using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuario));
            this.btn_guardar = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.txt_id = new Gizmox.WebGUI.Forms.TextBox();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.cb_sexo = new Gizmox.WebGUI.Forms.ComboBox();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.cb_estado = new Gizmox.WebGUI.Forms.ComboBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.txt_clave = new Gizmox.WebGUI.Forms.TextBox();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txt_usuario = new Gizmox.WebGUI.Forms.TextBox();
            this.txt_nombre = new Gizmox.WebGUI.Forms.TextBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btn_guardar.Image"));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(7, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 41);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "  Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 48);
            this.panel1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txt_id.Location = new System.Drawing.Point(372, 17);
            this.txt_id.MaxLength = 50;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(99, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_sexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_clave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(264, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_sexo.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.cb_sexo.Location = new System.Drawing.Point(308, 97);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_estado.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(93, 97);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave:";
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_clave.Location = new System.Drawing.Point(93, 74);
            this.txt_clave.MaxLength = 30;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(336, 20);
            this.txt_clave.TabIndex = 2;
            this.txt_clave.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_usuario.CharacterCasing = Gizmox.WebGUI.Forms.CharacterCasing.Upper;
            this.txt_usuario.Location = new System.Drawing.Point(93, 51);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(336, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_nombre.Location = new System.Drawing.Point(93, 28);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(336, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // Frm_Usuario
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(492, 208);
            this.Load += new System.EventHandler(this.Frm_Usuario_Load);
            this.Activated += new System.EventHandler(this.Frm_Usuario_Activated);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Button btn_guardar;
        private Gizmox.WebGUI.Forms.Panel panel1;
        private Gizmox.WebGUI.Forms.GroupBox groupBox1;
        private Gizmox.WebGUI.Forms.TextBox txt_id;
        private Gizmox.WebGUI.Forms.Label label5;
        private Gizmox.WebGUI.Forms.ComboBox cb_sexo;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.ComboBox cb_estado;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.TextBox txt_clave;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.TextBox txt_usuario;
        private Gizmox.WebGUI.Forms.TextBox txt_nombre;
        private Gizmox.WebGUI.Forms.Label label1;
	}
}
