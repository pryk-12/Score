using System;
using Negocio;
using Entidades;

namespace Presentacion.Pantallas
{
	public partial class Frm_Mant_Ingresos : Frm_Plantilla
	{
		public Frm_Mant_Ingresos()
		{
			InitializeComponent();
		}

        public void Consultar()
        {
            string condicion = "";

            if (cb_buscar.Text == "ID")
            {
                condicion = "ID_INGRESO =" + txt_buscar.Text + "";
            }
            else if (cb_buscar.Text == "DESCRIPCION" || cb_buscar.Text == "")
            {
                condicion = "(DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            }

            dg.DataSource = N_Ingreso.Consultar_Datos(condicion);
            lbl_total.Text = "Total de Regist.:  " + dg.Rows.Count.ToString();
        }

        public void Editar()
        {
            if (dg.Rows.Count == 0)
            {
                return;
            }
            E_Ingreso obj = new E_Ingreso();
            obj._DESCRIPCION = dg.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            obj._ESTADO = dg.CurrentRow.Cells["ESTADO"].Value.ToString();
            obj._ID_INGRESO = Convert.ToInt32(dg.CurrentRow.Cells["_ID"].Value.ToString());
            obj._TIPO = dg.CurrentRow.Cells["TIPO"].Value.ToString();
            Frm_Ingreso frm = new Frm_Ingreso();
            frm.Recibir_Datos(obj);
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Ingreso frm = new Frm_Ingreso();
            frm.ShowDialog();
        }

        private void Frm_Mant_Ingresos_Load(object sender, EventArgs e)
        {
            dg.AutoGenerateColumns = false;

            if (Funciones.Utilitario.Datos_Usuarios.USUARIO == "")
            {
                this.Context.Redirect("Frm_Login.wgx");
            }
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
