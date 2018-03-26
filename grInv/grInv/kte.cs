using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;
namespace grInv
{
    public static class kte
    {
        public static string GetConStr()
        {
            return "Data Source=www.softmild.com;Initial Catalog=ZaharaStore;User ID=dbCli;" + fun.Sha256("1A.2vc0,");
        }
    }
}
