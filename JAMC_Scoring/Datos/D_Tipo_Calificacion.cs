using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Tipo_Calificacion
    {
        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos(string condicion)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CALIFICACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", condicion);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CALIFICACIONES");
            cn.Close();

            return ds.Tables["CALIFICACIONES"];
        }

        public void Insertar_Datos(E_Tipo_Calificacion obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CALIFICACIONES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@ACCION", "I");
            da.InsertCommand.Parameters.AddWithValue("@CREADO_POR", obj._CREADO_POR);
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj._DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_CREADO", obj._FECHA_CREADO);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@PUNTOS", obj._PUNTOS);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Actualizar_Datos(E_Tipo_Calificacion obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_CALIFICACIONES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "U");
            da.UpdateCommand.Parameters.AddWithValue("@ID_CALIFICACION", obj._ID_TIPO_CALIFICACION);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj._DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.UpdateCommand.Parameters.AddWithValue("@PUNTOS", obj._PUNTOS);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
