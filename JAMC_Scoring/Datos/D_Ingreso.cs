using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Ingreso
    {
        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos(string condicion)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_INGRESOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", condicion);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "INGRESOS");
            cn.Close();

            return ds.Tables["INGRESOS"];
        }

        public void Insertar_Datos(E_Ingreso obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_INGRESOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@ACCION", "I");
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj._DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@TIPO", obj._TIPO);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@CREADO_POR", obj._CREADO_POR);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_CREADO", obj._FECHA_CREADO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Actualizar_Datos(E_Ingreso obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_INGRESOS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "U");
            da.UpdateCommand.Parameters.AddWithValue("@ID_INGRESO", obj._ID_INGRESO);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj._DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@TIPO", obj._TIPO);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
