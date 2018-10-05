using System.Configuration;

namespace Datos
{
   public class D_Conexion
    {
       //public static string cadena_conexion = ConfigurationManager.ConnectionStrings["BD_SCORING"].ConnectionString;
       public static string cadena_conexion = @"Data Source=FILESERVER3\SQLEXPRESS;Initial Catalog=BD_SCORING;Persist Security Info=True;User ID=sa;Password=R3g1na1207";
    }
}
