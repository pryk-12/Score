using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Presentacion.Pantallas;
using Negocio;
using Entidades;

namespace Presentacion.Pantallas
{
	public partial class Frm_Mant_Clientes : Frm_Plantilla
	{
		public Frm_Mant_Clientes()
		{
			InitializeComponent();
		}

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Cliente frm = new Frm_Cliente();
            frm.ShowDialog();
        }

        public void Consultar()
        {
            string condicion = "";

            if (cb_buscar.Text == "ID")
            {
                condicion = "ID_CLIENTE =" + txt_buscar.Text + "";
            }
            else if (cb_buscar.Text == "NOMBRES")
            {
                condicion = "(NOMBRES LIKE'%" + txt_buscar.Text + "%')";
            }
            else if (cb_buscar.Text == "APELLIDOS")
            {
                condicion = "(APELLIDOS LIKE'%" + txt_buscar.Text + "%')";
            }
            else if (cb_buscar.Text == "CEDULA" || cb_buscar.Text == "")
            {
                condicion = "(CEDULA LIKE'%" + txt_buscar.Text + "%')";
            }

            dg.DataSource = N_Cliente.Consultar_Datos(condicion);
            lbl_total.Text = "Total de Regist.:  " + dg.Rows.Count.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Frm_Mant_Clientes_Load(object sender, EventArgs e)
        {
            dg.AutoGenerateColumns = false;

            if (Funciones.Utilitario.Datos_Usuarios.USUARIO == "")
            {
                this.Context.Redirect("Frm_Login.wgx");
            }
        }

        public void Editar()
        {
            if (dg.Rows.Count == 0)
            {
                return;
            }
            E_Cliente obj = new E_Cliente();
            obj._APELLIDOS = dg.CurrentRow.Cells["APELLIDOS"].Value.ToString();
            obj._CEDULA = dg.CurrentRow.Cells["CEDULA"].Value.ToString();
            obj._CELULAR = dg.CurrentRow.Cells["CELULAR"].Value.ToString();
            obj._DIRECCION = dg.CurrentRow.Cells["DIRECCION"].Value.ToString();
            obj._ESTADO = dg.CurrentRow.Cells["ESTADO"].Value.ToString();
            obj._ID_CLIENTE = Convert.ToInt32(dg.CurrentRow.Cells["_ID"].Value.ToString());
            obj._NOMBRES = dg.CurrentRow.Cells["NOMBRES"].Value.ToString();
            obj._SEXO = dg.CurrentRow.Cells["SEXO"].Value.ToString();
            obj._TELEFONO = dg.CurrentRow.Cells["TELEFONO"].Value.ToString();
            Frm_Cliente frm = new Frm_Cliente();
            frm.Recibir_Datos(obj);
            frm.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void dg_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }		
	}
}
