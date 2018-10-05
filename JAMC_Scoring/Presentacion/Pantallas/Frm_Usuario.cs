using System;
using Entidades;
using Negocio;
using Gizmox.WebGUI.Forms;

namespace Presentacion.Pantallas
{
	public partial class Frm_Usuario : Frm_Plantilla
	{
        
		public Frm_Usuario()
		{
			InitializeComponent();            
		}	
	
        public void Recibir_Datos(E_Usuario obj)
        {
            txt_clave.Text = obj._CLAVE;
            txt_id.Text = obj._ID_USUARIO.ToString();
            txt_nombre.Text = obj._NOMBRE;
            txt_usuario.Text = obj._USUARIO;
            cb_estado.Text = obj._ESTADO;
            cb_sexo.Text = obj._SEXO;
        }

        public bool Validar()
        {
            bool opcion = true;
            ErrorProvider error = new ErrorProvider();
            
            if (txt_nombre.Text == string.Empty)
            {
                error.SetError(txt_nombre, "El Nombre es Obligatorio");
                opcion = false;
            }
            else
            {
                error.SetError(txt_nombre, "");
            }

            if (txt_usuario.Text == string.Empty)
            {
                error.SetError(txt_usuario, "El Usuario es Obligatorio");
                opcion = false;
            }
            else
            {
                error.SetError(txt_usuario, "");
            }

            if (txt_clave.Text == string.Empty)
            {
                error.SetError(txt_clave, "La Clave es Obligatoria");
                opcion = false;
            }
            else
            {
                error.SetError(txt_clave, "");
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

            if (cb_sexo.Text == string.Empty)
            {
                error.SetError(cb_sexo, "El Sexo es Obligatorio");
                opcion = false;
            }
            else
            {
                error.SetError(cb_sexo, "");
            }

            return opcion;
        }

        public void Insertar_Actualizar()
        {
            try
            {
                if(Validar()==false)
                {
                    return;
                }

                E_Usuario obj = new E_Usuario();
                string mensaje = "";

                obj._CLAVE = Funciones.Utilitario.Encriptar_Clave(txt_clave.Text.Trim());
                obj._CREADO_POR = Funciones.Utilitario.Datos_Usuarios.USUARIO;
                obj._ESTADO = cb_estado.Text;
                obj._FECHA_CREADO = DateTime.Now;
                obj._NOMBRE = txt_nombre.Text.Trim();
                obj._SEXO = cb_sexo.Text;
                obj._USUARIO = txt_usuario.Text.Trim();

                if(txt_id.Text.Equals(""))
                {
                    N_Usuario.Insertar_Datos(obj);
                    mensaje = "Datos Insertados Con Exito";
                }
                else
                {
                    obj._ID_USUARIO = Convert.ToInt32(txt_id.Text);
                    N_Usuario.Actualizar_Datos(obj);
                    mensaje = "Datos Actualizados Con Exito";
                }

                Frm_Mant_Usuarios frm = this.Owner as Frm_Mant_Usuarios;
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

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            if(txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Usuario";
                cb_estado.Enabled = false;
                cb_estado.Text = "Activo";
            }
            else
            {
                this.Text = "Actualizar Usuario";
            }
        }

        private void Frm_Usuario_Activated(object sender, EventArgs e)
        {
            txt_nombre.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Insertar_Actualizar();
        }
	}
}
