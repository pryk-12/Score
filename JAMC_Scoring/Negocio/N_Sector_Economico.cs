using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Sector_Economico
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Sector_Economico metodo = new D_Sector_Economico();
            return metodo.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Sector_Economico obj)
        {
            D_Sector_Economico metodo = new D_Sector_Economico();
            metodo.Insertar_Datos(obj);
        }

        public static void Actualizar_Datos(E_Sector_Economico obj)
        {
            D_Sector_Economico metodo = new D_Sector_Economico();
            metodo.Actualizar_Datos(obj);
        }
    }
}
