using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Ponderacion
    {
        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos(string condicion)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PONDERACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", condicion);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PONDERACIONES");
            cn.Close();

            return ds.Tables["PONDERACIONES"];
        }

        public void Insertar_Datos(E_Ponderacion obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_PONDERACIONES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@ACCION", "I");
            da.InsertCommand.Parameters.AddWithValue("@PORCIENTO", obj._PORCIENTO);
            da.InsertCommand.Parameters.AddWithValue("@ID_PONDERACION", obj._ID_PONDERACION);
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj._DESCRIPCION);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Eliminar_Datos()
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_PONDERACIONES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "D");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
