using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public static class Variables
    {
        public static string strCon { get; set; }
        public static int idAbierto { get; set; }
        public static string nomEmpresa { get; set; }
        public static string nameTableToOpen { get; set; }
        public static int idUsuarioActual { get; set; }
        public static int idPerfilUsuarioActual { get; set; }
        public static int idPerfilAdministrador = 10001;
        public static int idPerfilNoAdministrador = 10002;
    }
}
