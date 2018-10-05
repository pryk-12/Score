using Gizmox.WebGUI.Forms;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Presentacion.Funciones
{
    public static class Utilitario
    {
        public static class Datos_Usuarios
        {
            public static string USUARIO { get; set; }
        }

        //Permite detectar si el formulario esta abierto y solo se abre una vez
        public static void Abrir_Formulario(Type frmType)
        {
            bool opcion = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.Show();
                    opcion = true;
                    break;
                }
            }

            if (!opcion)
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                frm.Show();
            }
        }

        public static void Validar_ComboBox_Vacios(ComboBox cbo, string mensaje)
        {
            ErrorProvider error = new ErrorProvider();
            if (cbo.Text.Equals(""))
            {
                error.SetError(cbo, mensaje);
            }
            else
            {
                error.SetError(cbo, "");
            }
        }

        public static String Encriptar_Clave(string Clave)
        {
            TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider Hashmd5 = new MD5CryptoServiceProvider();
            string MyKey = "MyKey2012";
            String Encriptar = "";

            if ((Clave.Trim() == ""))
            {
                Encriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = Des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(Clave);
                Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));
            }
            return Encriptar;
        }

        public static String Desencriptar_Clave(string texto)
        {
            TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider Hashmd5 = new MD5CryptoServiceProvider();
            string MyKey = "MyKey2012";
            String Desencriptar = "";

            if ((texto.Trim() == ""))
            {
                Desencriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = Des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(texto);
                Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));
                buff.GetLength(0);
            }

            return Desencriptar;
        }

        public static void Mensaje_Informacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Mensaje_Error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Error Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Mensaje_Confirmacion(string Mensaje)
        {
            DialogResult Resultado = MessageBox.Show(Mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return Resultado;
        }

        public static bool Validar_Fecha(MaskedTextBox Masked)
        {
            DateTime fecha;
            if (DateTime.TryParse(Masked.Text, out fecha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Validar_Formato_Correo(String Correo)
        {
            String Expresion;
            Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Correo, Expresion))
            {
                if (Regex.Replace(Correo, Expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

       
    }
}