using System;

namespace Entidades
{
   public class E_Ingreso
    {
        public int _ID_INGRESO { get; set; }
        public string _DESCRIPCION { get; set; }
        public string _TIPO { get; set; }
        public string _ESTADO { get; set; }
        public string _CREADO_POR { get; set; }
        public DateTime _FECHA_CREADO { get; set; }
    }
}
