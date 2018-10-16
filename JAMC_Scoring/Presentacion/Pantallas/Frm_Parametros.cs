using System;
using Negocio;
using Gizmox.WebGUI.Forms;
using Entidades;

namespace Presentacion.Pantallas
{
	public partial class Frm_Parametros : Frm_Plantilla
	{
		public Frm_Parametros()
		{
			InitializeComponent();
            this.txt_capacidad_menor_a.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_capacidad_puntos.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_monto_isr.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_porciento_afp.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_porciento_isr.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_porciento_sfs.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_puntos_para_calificar.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_referencia_buena.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_referencia_mala.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
            this.txt_referencia_regular.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
		}

        public void Consultar()
        {
            try
            {
                txt_capacidad_menor_a.Text = N_Parametro.Consultar_Datos().Rows[0]["CAPACIDAD_PAGO_ACTUAL"].ToString();
                txt_capacidad_puntos.Text = N_Parametro.Consultar_Datos().Rows[0]["CAPACIDAD_PAGO_PUNTOS"].ToString();
                txt_referencia_buena.Text = N_Parametro.Consultar_Datos().Rows[0]["REFERENCIA_BUENA"].ToString();
                txt_referencia_regular.Text = N_Parametro.Consultar_Datos().Rows[0]["REFERENCIA_REGULAR"].ToString();
                txt_referencia_mala.Text = N_Parametro.Consultar_Datos().Rows[0]["REFERENCIA_MALA"].ToString();
                txt_puntos_para_calificar.Text = N_Parametro.Consultar_Datos().Rows[0]["PUNTOS_PARA_CALIFICAR"].ToString();
                txt_porciento_afp.Text = N_Parametro.Consultar_Datos().Rows[0]["PORCIENTO_AFP"].ToString();
                txt_porciento_sfs.Text = N_Parametro.Consultar_Datos().Rows[0]["PORCIENTO_SFS"].ToString();
                double monto = Convert.ToDouble(N_Parametro.Consultar_Datos().Rows[0]["MONTO_ISR"].ToString());
                txt_monto_isr.Text = monto.ToString("N2");
                txt_porciento_isr.Text = N_Parametro.Consultar_Datos().Rows[0]["PORCIENTO_ISR"].ToString();

                groupBox1.Enabled = false;
                btn_editar.Enabled = true;
                btn_guardar.Enabled = false;
            }
            catch
            {

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_capacidad_menor_a.Text.Length != 0)
            {
               if( Funciones.Utilitario.Validar_Decimal(txt_capacidad_menor_a,"El Formato del valor de Capacidad de Pago Actual es Incorrecto")==false)
               {
                   return;
               }
            }

            if (txt_capacidad_puntos.Text.Length != 0)
            {
              if(  Funciones.Utilitario.Validar_Decimal(txt_capacidad_puntos, "El Formato de Puntos de Capacidad de Pago Actual es Incorrecto")==false)
              {
                  return;
              }
            }

            if (txt_monto_isr.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_monto_isr, "El Formato del Monto de ISR es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_porciento_afp.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_porciento_afp, "El Formato del Porciento de AFP es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_porciento_isr.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_porciento_isr, "El Formato del Porciento de ISR es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_porciento_sfs.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_porciento_sfs, "El Formato del Porciento de SFS es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_puntos_para_calificar.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_puntos_para_calificar, "El Formato de Puntos Para Calificar es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_referencia_buena.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_referencia_buena, "El Formato de Punto de Referencia Buena es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_referencia_mala.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_referencia_mala, "El Formato de Punto de Referencia Mala es Incorrecto") == false)
                {
                    return;
                }
            }

            if (txt_referencia_regular.Text.Length != 0)
            {
                if (Funciones.Utilitario.Validar_Decimal(txt_referencia_regular, "El Formato de Punto de Referencia Regular es Incorrecto") == false)
                {
                    return;                   
                }
            }

            E_Parametro campo = new E_Parametro();
            string Mensaje = "";

            campo._CAPACIDAD_PAGO_ACTUAL = Convert.ToDouble(txt_capacidad_menor_a.Text);
            campo._CAPACIDAD_PAGO_PUNTOS = Convert.ToDouble(txt_capacidad_puntos.Text);
            campo._REFERENCIA_BUENA = Convert.ToDouble(txt_referencia_buena.Text);
            campo._REFERENCIA_REGULAR = Convert.ToDouble(txt_referencia_regular.Text);
            campo._REFERENCIA_MALA = Convert.ToDouble(txt_referencia_mala.Text);
            campo._PUNTOS_PARA_CALIFICAR = Convert.ToDouble(txt_puntos_para_calificar.Text);
            campo._PORCIENTO_AFP = Convert.ToDouble(txt_porciento_afp.Text);
            campo._PORCIENTO_SFS = Convert.ToDouble(txt_porciento_sfs.Text);
            campo._PORCIENTO_ISR = Convert.ToDouble(txt_porciento_isr.Text);
            campo._MONTO_ISR = Convert.ToDouble(txt_monto_isr.Text);
            campo._PORCIENTO_ISR = Convert.ToDouble(txt_porciento_isr.Text);

            try
            {

                N_Parametro.Actualizar_Datos(campo);
                Mensaje = "Datos Actualizados Con Exito";

                Funciones.Utilitario.Mensaje_Informacion(Mensaje);
                Consultar();
            }

            catch (Exception ex)
            {
                Funciones.Utilitario.Mensaje_Error(ex.Message);
            }
        }



        private void Frm_Parametros_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_guardar.Enabled = true;
            btn_editar.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
		
	}
}
