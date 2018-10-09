using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class D_Cliente
    {
        SqlConnection cn = new SqlConnection(D_Conexion.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Consultar_Datos(string condicion)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ACCION", "S");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", condicion);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CLIENTES");
            cn.Close();

            return ds.Tables["CLIENTES"];
        }

        public void Insertar_Datos(E_Cliente obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@ACCION", "I");
            da.InsertCommand.Parameters.AddWithValue("@NOMBRES", obj._NOMBRES);
            da.InsertCommand.Parameters.AddWithValue("@APELLIDOS", obj._APELLIDOS);
            da.InsertCommand.Parameters.AddWithValue("@CEDULA", obj._CEDULA);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION", obj._DIRECCION);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO", obj._TELEFONO);
            da.InsertCommand.Parameters.AddWithValue("@CELULAR", obj._CELULAR);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@SEXO", obj._SEXO== "Masculino" ? "M" : "F");
            da.InsertCommand.Parameters.AddWithValue("@CREADO_POR", obj._CREADO_POR);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_CREADO", obj._FECHA_CREADO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void Actualizar_Datos(E_Cliente obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_CLIENTES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@ACCION", "U");
            da.UpdateCommand.Parameters.AddWithValue("@ID_CLIENTE", obj._ID_CLIENTE);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRES", obj._NOMBRES);
            da.UpdateCommand.Parameters.AddWithValue("@APELLIDOS", obj._APELLIDOS);
            da.UpdateCommand.Parameters.AddWithValue("@CEDULA", obj._CEDULA);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION", obj._DIRECCION);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO", obj._TELEFONO);
            da.UpdateCommand.Parameters.AddWithValue("@CELULAR", obj._CELULAR);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj._ESTADO == "Activo" ? "A" : "I");
            da.UpdateCommand.Parameters.AddWithValue("@SEXO", obj._SEXO == "Masculino" ? "M" : "F");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
