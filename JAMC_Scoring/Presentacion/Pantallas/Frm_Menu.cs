using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Presentacion.Pantallas;
using Gizmox.WebGUI.Forms;

namespace Presentacion.Pantallas
{
	public partial class Frm_Menu : Frm_Plantilla
	{

		public Frm_Menu()
		{
			InitializeComponent();
		}

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            pnl_izquierdo.Width = 189;
            btn_usuario.Text = "     " + Funciones.Utilitario.Datos_Usuarios.USUARIO;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnl_izquierdo.Width == 189)
            {
                pnl_izquierdo.Width = 80;
                btn_mantenimiento.Text = "";
                btn_proceso.Text = "";
                btn_usuario.Text = "";
            }
            else
            {
                pnl_izquierdo.Width = 189;
                btn_mantenimiento.Text = "  Mantenimientos";
                btn_proceso.Text = "  Procesos";
                btn_usuario.Text = "  ";
            }
        }

        private void mn_usuarios_Click(object sender, EventArgs e)
        {
            Funciones.Utilitario.Abrir_Formulario(typeof(Frm_Mant_Usuarios));
        }

        public void Confirmar_Cerrar_Sesion(object sender, EventArgs e)
        {
            Form msgForm = sender as Form;
            if (msgForm != null)
            {
                if (msgForm.DialogResult == DialogResult.Yes)
                {
                    Cerrar_Sesion();
                }
            }
        }

        public void Cerrar_Sesion()
        {
            this.Context.Redirect("Frm_Login.wgx");
            Funciones.Utilitario.Datos_Usuarios.USUARIO = "";
        }

        private void mn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Segur@ de Cerrar Sesión", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Confirmar_Cerrar_Sesion);
        }

        private void mn_calificacion_cliente_Click(object sender, EventArgs e)
        {
            Funciones.Utilitario.Abrir_Formulario(typeof(Frm_Mant_Tipos_Calificaciones));
        }


	}
}
