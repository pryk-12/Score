using System;
using System.Linq;
using Negocio;
using Gizmox.WebGUI.Forms;
using Entidades;

namespace Presentacion.Pantallas
{
	public partial class Frm_Porciento_Ponderaciones : Frm_Plantilla
	{
		public Frm_Porciento_Ponderaciones()
		{
			InitializeComponent();
		}

        public void Consultar()
        {
            string condicion = "DESCRIPCION LIKE'%"+ "" +"%'";
            dg.DataSource = N_Ponderacion.Consultar_Datos(condicion);
            Sumar_Porciento();           
        }

        public void Sumar_Porciento()
        {
            try
            {
                lbl_total.Text = "Porciento Total = " + Convert.ToDecimal(dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["PORCIENTO"].Value.ToString()))) + " %";
            }
            catch (Exception ex)
            {
                Funciones.Utilitario.Mensaje_Error(ex.Message);
            }          
        }

        private void Frm_Porciento_Ponderaciones_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(dg.Rows.Count == 0)
            {
                return;
            }

            double porciento = Convert.ToDouble(dg.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["PORCIENTO"].Value.ToString())));

            if( porciento != 100)
            {
                Funciones.Utilitario.Mensaje_Informacion("El Porciento Total debe ser Igual a 100");
                return;
            }
            try
            {
                N_Ponderacion.Eliminar_Datos();

                foreach(DataGridViewRow fila in dg.Rows)
                {
                    E_Ponderacion obj = new E_Ponderacion();
                    obj._ID_PONDERACION = Convert.ToInt32(fila.Cells[0].Value.ToString());
                    obj._DESCRIPCION = fila.Cells[1].Value.ToString();
                    obj._PORCIENTO = Convert.ToDouble(fila.Cells[2].Value.ToString());

                    N_Ponderacion.Insertar_Datos(obj);
                }
                Funciones.Utilitario.Mensaje_Informacion("Datos Actualizados Con Exito");
            }
            catch (Exception ex)
            {
                Funciones.Utilitario.Mensaje_Error(ex.Message);
            }
        }

        private void dg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    Sumar_Porciento();
                }
                catch (Exception ex)
                {
                    Funciones.Utilitario.Mensaje_Error(ex.Message);
                }                
            }
        }

	}
}
