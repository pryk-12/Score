using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Parametro
    {
        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos()
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PARAMETROS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PARAMETROS");
            cn.Close();

            return ds.Tables["PARAMETROS"];
        }

        public void Actualizar_Datos(E_Parametro obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_PARAMETROS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "U");
            da.UpdateCommand.Parameters.AddWithValue("@CAPACIDAD_PAGO_ACTUAL", obj._CAPACIDAD_PAGO_ACTUAL);
            da.UpdateCommand.Parameters.AddWithValue("@CAPACIDAD_PAGO_PUNTOS", obj._CAPACIDAD_PAGO_PUNTOS);
            da.UpdateCommand.Parameters.AddWithValue("@REFERENCIA_BUENA", obj._REFERENCIA_BUENA);
            da.UpdateCommand.Parameters.AddWithValue("@REFERENCIA_REGULAR", obj._REFERENCIA_REGULAR);
            da.UpdateCommand.Parameters.AddWithValue("@REFERENCIA_MALA", obj._REFERENCIA_MALA);
            da.UpdateCommand.Parameters.AddWithValue("@PUNTOS_PARA_CALIFICAR", obj._PUNTOS_PARA_CALIFICAR);
            da.UpdateCommand.Parameters.AddWithValue("@PORCIENTO_AFP", obj._PORCIENTO_AFP);
            da.UpdateCommand.Parameters.AddWithValue("@PORCIENTO_SFS", obj._PORCIENTO_SFS);
            da.UpdateCommand.Parameters.AddWithValue("@MONTO_ISR", obj._MONTO_ISR);
            da.UpdateCommand.Parameters.AddWithValue("@PORCIENTO_ISR", obj._PORCIENTO_ISR);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
