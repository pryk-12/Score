using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Ponderacion
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Ponderacion obj = new D_Ponderacion();
            return obj.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Ponderacion obj_)
        {
            D_Ponderacion obj = new D_Ponderacion();
            obj.Insertar_Datos(obj_);
        }

        public static void Eliminar_Datos()
        {
            D_Ponderacion obj = new D_Ponderacion();
            obj.Eliminar_Datos();
        }
    }
}
