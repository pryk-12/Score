using System;
using Entidades;
using Gizmox.WebGUI.Forms;
using Negocio;

namespace Presentacion.Pantallas
{
	public partial class Frm_Cliente : Frm_Plantilla
	{
		public Frm_Cliente()
		{
			InitializeComponent();
		}

        public void Recibir_Datos(E_Cliente obj)
        {
            txt_apellidos.Text = obj._APELLIDOS;
            txt_id.Text = obj._ID_CLIENTE.ToString();
            txt_nombres.Text = obj._NOMBRES;
            txt_direccion.Text = obj._DIRECCION;
            txt_cedula.Text = obj._CEDULA;
            cb_estado.Text = obj._ESTADO;
            cb_sexo.Text = obj._SEXO;
            txt_telefono.Text = obj._TELEFONO;
            txt_celular.Text = obj._CELULAR;
        }

        public bool Validar()
        {
            bool opcion = true;
            ErrorProvider error = new ErrorProvider();

            if (txt_nombres.Text == string.Empty)
            {
                error.SetError(txt_nombres, "Los Nombres son Obligatorios");
                opcion = false;
            }
            else
            {
                error.SetError(txt_nombres, "");
            }

            if (txt_apellidos.Text == string.Empty)
            {
                error.SetError(txt_apellidos, "Los Apellidos son Obligatorios");
                opcion = false;
            }
            else
            {
                error.SetError(txt_apellidos, "");
            }

            if (txt_direccion.Text == string.Empty)
            {
                error.SetError(txt_direccion, "La Dirección es Obligatoria");
                opcion = false;
            }
            else
            {
                error.SetError(txt_direccion, "");
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
                if (Validar() == false)
                {
                    return;
                }

                E_Cliente obj = new E_Cliente();
                string mensaje = "";

                obj._APELLIDOS = txt_apellidos.Text.Trim();
                obj._CEDULA = txt_cedula.Text.Trim();
                obj._CELULAR = txt_celular.Text.Trim();
                obj._CREADO_POR = Funciones.Utilitario.Datos_Usuarios.USUARIO;
                obj._DIRECCION = txt_direccion.Text.Trim();
                obj._ESTADO = cb_estado.Text;
                obj._FECHA_CREADO = DateTime.Now;
                obj._NOMBRES = txt_nombres.Text.Trim();
                obj._SEXO = cb_sexo.Text;
                obj._TELEFONO = txt_telefono.Text.Trim();

                if (txt_id.Text.Equals(""))
                {
                    N_Cliente.Insertar_Datos(obj);
                    mensaje = "Datos Insertados Con Exito";
                }
                else
                {
                    obj._ID_CLIENTE = Convert.ToInt32(txt_id.Text);
                    N_Cliente.Actualizar_Datos(obj);
                    mensaje = "Datos Actualizados Con Exito";
                }

                Frm_Mant_Clientes frm = this.Owner as Frm_Mant_Clientes;
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
            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    Funciones.Utilitario.Mensaje_Informacion("El Número de Telefono Esta Incompleto");
                    txt_telefono.Focus();
                    return;
                }
            }

            if (!txt_celular.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    Funciones.Utilitario.Mensaje_Informacion("El Número de Celular Esta Incompleto");
                    txt_celular.Focus();
                    return;
                }
            }

            Insertar_Actualizar();
        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Cliente";
                cb_estado.Enabled = false;
                cb_estado.Text = "Activo";
            }
            else
            {
                this.Text = "Actualizar Cliente";
            }
        }		
	}
}
