using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Ingreso
    {
        public static DataTable Consultar_Datos(string condicion)
        {
            D_Ingreso metodo = new D_Ingreso();
            return metodo.Consultar_Datos(condicion);
        }

        public static void Insertar_Datos(E_Ingreso obj)
        {
            D_Ingreso metodo = new D_Ingreso();
            metodo.Insertar_Datos(obj);
        }

        public static void Actualizar_Datos(E_Ingreso obj)
        {
            D_Ingreso metodo = new D_Ingreso();
            metodo.Actualizar_Datos(obj);
        }
    }
}
