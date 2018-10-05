using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Tipo_Calificacion
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Tipo_Calificacion obj = new D_Tipo_Calificacion();
            return obj.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Tipo_Calificacion obj_)
        {
            D_Tipo_Calificacion obj = new D_Tipo_Calificacion();
            obj.Insertar_Datos(obj_);
        }

        public static void Actualizar_Datos(E_Tipo_Calificacion obj_)
        {
            D_Tipo_Calificacion obj = new D_Tipo_Calificacion();
            obj.Actualizar_Datos(obj_);
        }
    }
}
