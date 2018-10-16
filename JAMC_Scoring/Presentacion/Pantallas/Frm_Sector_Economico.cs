using System;
using Entidades;
using Gizmox.WebGUI.Forms;
using Negocio;

namespace Presentacion.Pantallas
{
	public partial class Frm_Sector_Economico : Frm_Plantilla
	{
		public Frm_Sector_Economico()
		{
			InitializeComponent();
		}

        public void Recibir_Datos(E_Sector_Economico obj)
        {
            txt_id.Text = obj._ID_SECTOR_ECONOMICO.ToString();
            txt_descripcion.Text = obj._DESCRIPCION;
            cb_estado.Text = obj._ESTADO;
            txt_puntos.Text = obj._PUNTOS.ToString();
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

                if (txt_puntos.Text.Length != 0)
                {
                    if (Funciones.Utilitario.Validar_Decimal(txt_puntos, "El Formato de los Puntos es Incorrecto") == false)
                    {
                        return;
                    }
                }

                E_Sector_Economico obj = new E_Sector_Economico();
                string mensaje = "";

                obj._CREADO_POR = Funciones.Utilitario.Datos_Usuarios.USUARIO;
                obj._ESTADO = cb_estado.Text;
                obj._FECHA_CREADO = DateTime.Now;
                obj._DESCRIPCION = txt_descripcion.Text.Trim();
                obj._PUNTOS = Convert.ToDouble(txt_puntos.Text);

                if (txt_id.Text.Equals(""))
                {
                    N_Sector_Economico.Insertar_Datos(obj);
                    mensaje = "Datos Insertados Con Exito";
                }
                else
                {
                    obj._ID_SECTOR_ECONOMICO = Convert.ToInt32(txt_id.Text);
                    N_Sector_Economico.Actualizar_Datos(obj);
                    mensaje = "Datos Actualizados Con Exito";
                }

                Frm_Mant_Sectores_Economicos frm = this.Owner as Frm_Mant_Sectores_Economicos;
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

        private void Frm_Sector_Economico_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Sector Económico";
                cb_estado.Enabled = false;
                cb_estado.Text = "Activo";
            }
            else
            {
                this.Text = "Actualizar Sector Económico";
            }
        }		
	}
}
