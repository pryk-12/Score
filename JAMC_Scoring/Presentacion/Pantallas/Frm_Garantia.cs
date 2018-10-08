using System;
using Gizmox.WebGUI.Forms;
using Entidades;
using Negocio;

namespace Presentacion.Pantallas
{
	public partial class Frm_Garantia : Frm_Plantilla
	{
		public Frm_Garantia()
		{
			InitializeComponent();
            this.txt_puntos.Validator = new TextBoxValidation("", "", string.Concat("0-9\\."));
		}

        public void Recibir_Datos(E_Garantia obj)
        {
            txt_id.Text = obj._ID_GARANTIA.ToString();
            txt_descripcion.Text = obj._DESCRIPCION;
            txt_puntos.Text = obj._PUNTOS.ToString();
            cb_estado.Text = obj._ESTADO;
        }

        public bool Validar()
        {
            bool opcion = true;
            ErrorProvider error = new ErrorProvider();

            if (txt_descripcion.Text == string.Empty)
            {
                error.SetError(txt_descripcion, "La Descripci�n es Obligatoria");
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
                    double puntos = 0;
                    if (double.TryParse(txt_puntos.Text, out puntos))
                    {

                        txt_puntos.Text = puntos.ToString("N2");
                    }
                    else
                    {
                        Funciones.Utilitario.Mensaje_Informacion("Formato de los Puntos es incorrecto");
                        txt_puntos.Focus();
                        return;
                    }
                }

                E_Garantia obj = new E_Garantia();
                string mensaje = "";

                obj._CREADO_POR = Funciones.Utilitario.Datos_Usuarios.USUARIO;
                obj._ESTADO = cb_estado.Text;
                obj._FECHA_CREADO = DateTime.Now;
                obj._DESCRIPCION = txt_descripcion.Text.Trim();
                obj._PUNTOS = txt_puntos.Text.Length == 0 ? 0 : Convert.ToDouble(txt_puntos.Text);

                if (txt_id.Text.Equals(""))
                {
                    N_Garantia.Insertar_Datos(obj);
                    mensaje = "Datos Insertados Con Exito";
                }
                else
                {
                    obj._ID_GARANTIA = Convert.ToInt32(txt_id.Text);
                    N_Garantia.Actualizar_Datos(obj);
                    mensaje = "Datos Actualizados Con Exito";
                }

                Frm_Mant_Garantias frm = this.Owner as Frm_Mant_Garantias;
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

        private void Frm_Garantia_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Tipo de Garant�a";
                cb_estado.Enabled = false;
                cb_estado.Text = "Activo";
            }
            else
            {
                this.Text = "Actualizar Tipo de Garant�a";
            }
        }

        private void Frm_Garantia_Activated(object sender, EventArgs e)
        {
            txt_descripcion.Focus();
        }		
	}
}