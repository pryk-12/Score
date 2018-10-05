using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
   public class N_Usuario
    {

       public static DataTable Consultar_Datos(string condicion)
       {
           D_Usuario obj = new D_Usuario();
           return obj.Consultar_Datos(condicion);
       }

       public static void Insertar_Datos(E_Usuario obj_usuario)
       {
           D_Usuario obj = new D_Usuario();
           obj.Insertar_Datos(obj_usuario);
       }

       public static void Actualizar_Datos(E_Usuario obj_usuario)
       {
           D_Usuario obj = new D_Usuario();
           obj.Actualizar_Datos(obj_usuario);
       }

       public static void Cambiar_Clave(E_Usuario obj_usuario)
       {
           D_Usuario obj = new D_Usuario();
           obj.Cambiar_Clave(obj_usuario);
       }
    }
}
