using System;
using Gizmox.WebGUI.Forms;
using Negocio;
using Entidades;

namespace Presentacion.Pantallas
{
	public partial class Frm_Cambiar_Clave : Frm_Plantilla
	{
		public Frm_Cambiar_Clave()
		{
			InitializeComponent();
		}

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cambiar_Clave();
        }

        public bool Validar()
        {
            bool opcion = true;
            ErrorProvider error = new ErrorProvider();

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

            if (txt_repetir_clave.Text == string.Empty)
            {
                error.SetError(txt_repetir_clave, "Repetir Clave es Obligatorio");
                opcion = false;
            }
            else
            {
                error.SetError(txt_repetir_clave, "");
            }

            return opcion;
        }

        public void Cambiar_Clave()
        {
            if (Validar() == false)
            {
                return;
            }

            if(txt_clave.Text.Trim() != txt_repetir_clave.Text.Trim())
            {
                Funciones.Utilitario.Mensaje_Informacion("Las Claves no son Iguales");
                txt_clave.Clear();
                txt_repetir_clave.Clear();
                return;
            }

            E_Usuario obj = new E_Usuario();
            obj._CLAVE = Funciones.Utilitario.Encriptar_Clave(txt_clave.Text).Trim();
            obj._USUARIO = txt_usuario.Text.Trim();
            N_Usuario.Cambiar_Clave(obj);
            this.Close();
            Funciones.Utilitario.Mensaje_Informacion("Clave Cambiada Con Exito");
          
        }

        private void Frm_Cambiar_Clave_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = Funciones.Utilitario.Datos_Usuarios.USUARIO;
        }		
	}
}
