using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.Xml;
using System.IO;
using System.Data;


namespace Librerias
{
    public static class fun
    {
        
        public static string Sha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

               
        public static void Showfrm(string frm, Form parent)
        {
            Form f = (Form)getObject(frm);
            f.MdiParent = parent;
            f.Show();

        }

        public static void ShowfrmDialog(string frm, Form parent)
        {
            Form f = (Form)getObject(frm);
            f.ShowDialog(parent);
        }


        public static object getObject(string typeObj)
        {
            
            object f = Activator.CreateInstance(getType(typeObj));
            return f;
        }

        

        public static Type getType(string Class)
        {
            
            Type type = null;
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] assemblyTypes = a.GetTypes();
                for (int j = 0; j < assemblyTypes.Length; j++)
                {
                    if (assemblyTypes[j].Name == Class)
                    {
                        type = assemblyTypes[j];
                    }
                }
            }
            return type;
        }



        public static string getPath()
        {
            return Directory.GetCurrentDirectory();

        }

       
        public static Assembly[] getAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
            
        }


        public static string gsql(object valor)
        {
            
            var t = valor.GetType().ToString();
            switch (t)
            {
                case "System.Int32":
                    return gsql((int)valor);
                    
                case "System.Decimal":
                    return  gsql((decimal)valor);
                    
                case "System.String":
                    return gsql((string)valor);
                    
                case "System.DateTime":
                    return gsql(Convert.ToDateTime(valor));
                    
                case "System.Boolean":
                    return gsql((bool)valor);
                    
                default:
                    return "NULL";
                    
            }
            
        }

        public static string gsql(int valor)
        {
            return valor.ToString();
        }

        public static string gsql(string valor)
        {
            return "'"+valor+"'";
        }

        public static string gsql(bool valor)
        {
            if (valor)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public static string gsql(DateTime valor)
        {
            return "CONVERT(DATETIME,'" + valor.ToString("yyyy-MM-d HH:mm:ss.fff", CultureInfo.InvariantCulture) + "',21)";
        }

        public static string gsql(decimal valor)
        {
            return valor.ToString("G",CultureInfo.InvariantCulture);
        }

        public static string TryStr(object txt)
        {
            if (txt is null)
            {
                return "";
            }
            else if (txt.GetType() == typeof(int))
            {
                return txt.ToString();
            }
            else
            {
                return (string)txt;
            }

        }


        public static int TryInt(object valor)
        {
            if (valor == null || valor.ToString() == "")
            {
                return 0;
            }
            else if (valor.GetType() == typeof(string))
            {
                return Convert.ToInt32(valor);
            }
            else
            {
                return (int)valor;
            }

        }

        public static decimal TryDec(object valor)
        {
            if (valor == null || valor.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(valor);
            }

        }

        public static bool TryBool(object valor)
        {
            if (valor is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool TryBool(int valor)
        {
            if (valor != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool TryBool(string valor)
        {
            if (valor != "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static DataTable GetXml(string TagPapa,string TagHijo,string atributos,string file = "/StrCon.xml") // atributos separados por comas
        {
            string path = Directory.GetCurrentDirectory() + file;
            DataTable dt = new DataTable();
            string[] atr = atributos.Split(','); // caracteres se definen con comilla simple.

            foreach(string at in atr)
            {
                dt.Columns.Add(at,typeof(string));
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNodeList t1 = xDoc.GetElementsByTagName(TagPapa);
            XmlNodeList t2 = ((XmlElement)t1[0]).GetElementsByTagName(TagHijo);

            //for (int i = 0; i <= t2.Count - 1;i++)
            foreach(XmlElement n in t2)
            {
                DataRow dr = dt.NewRow();
                foreach (string at in atr)
                {                           
                    dr[at] = n.GetAttribute(at);
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static string getMaxString(string nomTable,string column,string filter = ";")
        {
            DataTable dt = new DataTable();
            int max = 0,num = 0;
            afgCon cn = new afgCon(Variables.strCon);
            cn.Open();
            string cmd = "SELECT " + column + " FROM " + nomTable + " " + filter;
            cn.dtFill(dt, cmd);
            foreach(DataRow dr in dt.Rows)
            {
                num = TryInt(dr[column]);
                if (num > max) max = num;
            }
            max++;
            return max.ToString();
        }

        public static string getTableColumns(DataTable dt)
        {
            string Columns = "";
            foreach(DataColumn dc in dt.Columns)
            {
                if (dc.ColumnName.StartsWith("_")) continue;
                Columns += "," + dc.ColumnName;
            }
            return Columns.Substring(1);
        }

        public static string createList(DataTable dt,string Column)
        {
            string list = "";
            foreach(DataRow dr in dt.Rows)
            {
                list += "," + TryStr(dr[Column]);
            }
            return list.Substring(1);
        }

        public static void ShowMsg(string msg,string titulo, string type)
        {
            switch (type.ToLower())
            {
                case "ok":
                    MessageBox.Show(msg, titulo, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case "error":
                    MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                
            }
            
        }
    }

}

