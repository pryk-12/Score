using System;
using Entidades;
using Gizmox.WebGUI.Forms;
using Negocio;

namespace Presentacion.Pantallas
{
	public partial class Frm_Ingreso : Frm_Plantilla
	{
		public Frm_Ingreso()
		{
			InitializeComponent();
		}

        public void Recibir_Datos(E_Ingreso obj)
        {
            txt_id.Text = obj._ID_INGRESO.ToString();
            txt_descripcion.Text = obj._DESCRIPCION;
            cb_tipo.Text = obj._TIPO;
            cb_estado.Text = obj._ESTADO;
        }

        public bool Validar()
        {
            bool opcion = true;
            ErrorProvider error = new ErrorProvider();

            if (txt_descripcion.Text == string.Empty)
            {
                error.SetError(txt_descripcion, "La Descripción es Obligatoria");
                opcion = false;
            }
            else
            {
                error.SetError(txt_descripcion, "");
            }

            if (cb_tipo.Text == string.Empty)
            {
                error.SetError(cb_tipo, "Se debe seleccionar el Tipo");
                opcion = false;
            }
            else
            {
                error.SetError(cb_tipo, "");
            }

            if (cb_estado.Text == string.Empty)
            {
                error.SetError(cb_estado, "El Estado es Obligatorio");
                opcion = false;
            }
            else
            {
                error.SetError(cb_estado, "");
            }

            return opcion;
        }

        public void Insertar_Actualizar()
        {
            try
            {
                if (Validar() == false)
                {
                    return;
                }

                E_Ingreso obj = new E_Ingreso();
                string mensaje = "";

                obj._CREADO_POR = Funciones.Utilitario.Datos_Usuarios.USUARIO;
                obj._ESTADO = cb_estado.Text;
                obj._FECHA_CREADO = DateTime.Now;
                obj._DESCRIPCION = txt_descripcion.Text.Trim();
                obj._TIPO = cb_tipo.Text;

                if (txt_id.Text.Equals(""))
                {
                    N_Ingreso.Insertar_Datos(obj);
                    mensaje = "Datos Insertados Con Exito";
                }
                else
                {
                    obj._ID_INGRESO = Convert.ToInt32(txt_id.Text);
                    N_Ingreso.Actualizar_Datos(obj);
                    mensaje = "Datos Actualizados Con Exito";
                }

                Frm_Mant_Ingresos frm = this.Owner as Frm_Mant_Ingresos;
                if (frm != null)
                {
                    frm.Consultar();
                }
                this.Close();
                Funciones.Utilitario.Mensaje_Informacion(mensaje);
            }
            catch (Exception ex)
            {
                Funciones.Utilitario.Mensaje_Error(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Insertar_Actualizar();
        }

        private void Frm_Ingreso_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Tipo Ingreso";
                cb_estado.Enabled = false;
                cb_estado.Text = "Activo";
            }
            else
            {
                this.Text = "Actualizar Tipo Ingreso";
            }
        }		
	}
}
