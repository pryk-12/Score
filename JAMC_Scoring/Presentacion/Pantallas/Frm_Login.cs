using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Presentacion.Pantallas;
using Gizmox.WebGUI.Forms;
using Negocio;


namespace Presentacion.Pantallas
{
	public partial class Frm_Login : Frm_Plantilla
	{
		public Frm_Login()
		{
			InitializeComponent();
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
            return opcion;
        }

        public void Acceso_Sistema()
        {
            if(Validar()==false)
            {
                return;
            }

            string condicion = "(USUARIO='" + txt_usuario.Text.Trim() + "' AND CLAVE='" + Funciones.Utilitario.Encriptar_Clave(txt_clave.Text).Trim() + "')";
            if (N_Usuario.Consultar_Datos(condicion).Rows.Count == 1 && N_Usuario.Consultar_Datos(condicion).Rows[0]["ESTADO"].ToString()=="Activo")
            {
                this.Context.Redirect("Frm_Menu.wgx");
                Funciones.Utilitario.Datos_Usuarios.USUARIO = txt_usuario.Text.Trim();
            }
            else
            {
                Funciones.Utilitario.Mensaje_Informacion("Este Usuario no Existe o Esta Inactivo");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Acceso_Sistema();
        }
	}

    
}
