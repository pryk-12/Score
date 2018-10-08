using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class D_Usuario
    {

        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos(string condicion)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_USUARIOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", condicion);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "USUARIOS");
            cn.Close();

            return ds.Tables["USUARIOS"];
        }

        public void Insertar_Datos(E_Usuario obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_USUARIOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@ACCION", "I");
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE", obj._NOMBRE);
            da.InsertCommand.Parameters.AddWithValue("@USUARIO", obj._USUARIO);
            da.InsertCommand.Parameters.AddWithValue("@CLAVE", obj._CLAVE);
            da.InsertCommand.Parameters.AddWithValue("@SEXO", obj._SEXO == "Masculino" ? "M" : "F");
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@CREADO_POR", obj._CREADO_POR);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_CREADO", obj._FECHA_CREADO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Actualizar_Datos(E_Usuario obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_USUARIOS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "U");
            da.UpdateCommand.Parameters.AddWithValue("@ID_USUARIO", obj._ID_USUARIO);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE", obj._NOMBRE);
            da.UpdateCommand.Parameters.AddWithValue("@USUARIO", obj._USUARIO);
            da.UpdateCommand.Parameters.AddWithValue("@CLAVE", obj._CLAVE);
            da.UpdateCommand.Parameters.AddWithValue("@SEXO", obj._SEXO == "Masculino" ? "M" : "F");
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Cambiar_Clave(E_Usuario obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_USUARIOS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "C");
            da.UpdateCommand.Parameters.AddWithValue("@USUARIO", obj._USUARIO);
            da.UpdateCommand.Parameters.AddWithValue("@CLAVE", obj._CLAVE);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
