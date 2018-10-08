using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Gasto
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Gasto obj = new D_Gasto();
            return obj.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Gasto obj_)
        {
            D_Gasto obj = new D_Gasto();
            obj.Insertar_Datos(obj_);
        }

        public static void Actualizar_Datos(E_Gasto obj_)
        {
            D_Gasto obj = new D_Gasto();
            obj.Actualizar_Datos(obj_);
        }
    }
}
