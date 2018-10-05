using System;
using Entidades;
using Negocio;

namespace Presentacion.Pantallas
{
	public partial class Frm_Mant_Usuarios : Frm_Plantilla
    {
        public Frm_Mant_Usuarios()
		{
			InitializeComponent();
		}

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Usuario frm = new Frm_Usuario();
            frm.ShowDialog();
        }

        public void Consultar()
        {
            string condicion = "";
            
            if(cb_buscar.Text =="ID")
            {
                condicion = "ID_USUARIO =" + txt_buscar.Text + "";
            }
            else if (cb_buscar.Text == "NOMBRE")
            {
                condicion = "(NOMBRE LIKE'%" + txt_buscar.Text + "%')";
            }
            else if (cb_buscar.Text == "USUARIO" || cb_buscar.Text == "")
            {
                condicion = "(USUARIO LIKE'%" + txt_buscar.Text + "%')";
            }

            dg.DataSource = N_Usuario.Consultar_Datos(condicion);
            lbl_total.Text = "Total de Regist.:  " + dg.Rows.Count.ToString();
        }

        private void Frm_Mant_Usuarios_Load(object sender, EventArgs e)
        {
            dg.AutoGenerateColumns = false;          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        public void Editar()
        {
            if(dg.Rows.Count == 0)
            {
                return;
            }
            E_Usuario obj = new E_Usuario();
            obj._CLAVE = Funciones.Utilitario.Desencriptar_Clave(dg.CurrentRow.Cells["CLAVE"].Value.ToString());
            obj._ESTADO = dg.CurrentRow.Cells["ESTADO"].Value.ToString();
            obj._ID_USUARIO = Convert.ToInt32(dg.CurrentRow.Cells["ID"].Value.ToString());
            obj._NOMBRE = dg.CurrentRow.Cells["NOMBRE"].Value.ToString();
            obj._SEXO = dg.CurrentRow.Cells["SEXO"].Value.ToString();
            obj._USUARIO = dg.CurrentRow.Cells["USUARIO"].Value.ToString();
            Frm_Usuario frm = new Frm_Usuario();
            frm.Recibir_Datos(obj);
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dg_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }		
	}
}
