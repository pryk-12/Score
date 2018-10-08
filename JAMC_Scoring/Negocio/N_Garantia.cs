using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Garantia
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Garantia obj = new D_Garantia();
            return obj.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Garantia obj_)
        {
            D_Garantia obj = new D_Garantia();
            obj.Insertar_Datos(obj_);
        }

        public static void Actualizar_Datos(E_Garantia obj_)
        {
            D_Garantia obj = new D_Garantia();
            obj.Actualizar_Datos(obj_);
        }
    }
}
