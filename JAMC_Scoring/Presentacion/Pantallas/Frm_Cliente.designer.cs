using System.Drawing;

namespace Presentacion.Pantallas
{
	partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.cb_sexo = new Gizmox.WebGUI.Forms.ComboBox();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.cb_estado = new Gizmox.WebGUI.Forms.ComboBox();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txt_direccion = new Gizmox.WebGUI.Forms.TextBox();
            this.txt_nombres = new Gizmox.WebGUI.Forms.TextBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.txt_id = new Gizmox.WebGUI.Forms.TextBox();
            this.btn_guardar = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.txt_apellidos = new Gizmox.WebGUI.Forms.TextBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.txt_cedula = new Gizmox.WebGUI.Forms.TextBox();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.txt_telefono = new Gizmox.WebGUI.Forms.MaskedTextBox();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.txt_celular = new Gizmox.WebGUI.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(338, 52);
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
            this.cb_sexo.Location = new System.Drawing.Point(382, 48);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(100, 21);
            this.cb_sexo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(327, 135);
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
            this.cb_estado.Location = new System.Drawing.Point(382, 131);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(100, 21);
            this.cb_estado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_direccion.Location = new System.Drawing.Point(88, 72);
            this.txt_direccion.MaxLength = 500;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(394, 56);
            this.txt_direccion.TabIndex = 4;
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_nombres.Location = new System.Drawing.Point(88, 28);
            this.txt_nombres.MaxLength = 25;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(167, 20);
            this.txt_nombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_celular);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_sexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txt_id.Location = new System.Drawing.Point(417, 17);
            this.txt_id.MaxLength = 50;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(99, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Visible = false;
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
            this.panel1.Size = new System.Drawing.Size(539, 48);
            this.panel1.TabIndex = 0;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_apellidos.Location = new System.Drawing.Point(88, 50);
            this.txt_apellidos.MaxLength = 25;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(167, 20);
            this.txt_apellidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cedula.Location = new System.Drawing.Point(382, 25);
            this.txt_cedula.MaxLength = 50;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(327, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cédula:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_telefono.CustomStyle = "Masked";
            this.txt_telefono.Location = new System.Drawing.Point(88, 131);
            this.txt_telefono.Mask = "000-000-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PromptChar = ' ';
            this.txt_telefono.Size = new System.Drawing.Size(84, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.Text = "   -   -    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(184, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Celular:";
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_celular.CustomStyle = "Masked";
            this.txt_celular.Location = new System.Drawing.Point(239, 131);
            this.txt_celular.Mask = "000-000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.PromptChar = ' ';
            this.txt_celular.Size = new System.Drawing.Size(84, 20);
            this.txt_celular.TabIndex = 6;
            this.txt_celular.Text = "   -   -    ";
            // 
            // Frm_Cliente
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Size = new System.Drawing.Size(539, 245);
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Gizmox.WebGUI.Forms.Label label5;
        private Gizmox.WebGUI.Forms.ComboBox cb_sexo;
        private Gizmox.WebGUI.Forms.Label label4;
        private Gizmox.WebGUI.Forms.ComboBox cb_estado;
        private Gizmox.WebGUI.Forms.Label label2;
        private Gizmox.WebGUI.Forms.TextBox txt_direccion;
        private Gizmox.WebGUI.Forms.TextBox txt_nombres;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.GroupBox groupBox1;
        private Gizmox.WebGUI.Forms.MaskedTextBox txt_celular;
        private Gizmox.WebGUI.Forms.Label label8;
        private Gizmox.WebGUI.Forms.Label label7;
        private Gizmox.WebGUI.Forms.MaskedTextBox txt_telefono;
        private Gizmox.WebGUI.Forms.Label label6;
        private Gizmox.WebGUI.Forms.TextBox txt_cedula;
        private Gizmox.WebGUI.Forms.Label label3;
        private Gizmox.WebGUI.Forms.TextBox txt_apellidos;
        private Gizmox.WebGUI.Forms.TextBox txt_id;
        private Gizmox.WebGUI.Forms.Button btn_guardar;
        private Gizmox.WebGUI.Forms.Panel panel1;
	}
}
