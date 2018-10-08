using System.Configuration;

namespace Datos
{
   public class D_Conexion
    {
       public static string cadena_conexion = ConfigurationManager.ConnectionStrings["BD_SCORING"].ConnectionString;
    }
}
