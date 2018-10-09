using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Cliente
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Cliente metodo = new D_Cliente();
            return metodo.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Cliente obj)
        {
            D_Cliente metodo = new D_Cliente();
            metodo.Insertar_Datos(obj);
        }

        public static void Actualizar_Datos(E_Cliente obj)
        {
            D_Cliente metodo = new D_Cliente();
            metodo.Actualizar_Datos(obj);
        }
    }
}
