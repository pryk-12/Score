using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Parametro
    {
        public static DataTable Consultar_Datos()
        {
            D_Parametro metodo = new D_Parametro();
            return metodo.Consultar_Datos();
        }

        public static void Actualizar_Datos(E_Parametro obj)
        {
            D_Parametro metodo = new D_Parametro();
            metodo.Actualizar_Datos(obj);
        }
    }
}
