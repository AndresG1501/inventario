using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;
using System.Reflection;
using static Librerias.fun;

namespace Librerias
{
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();
            Nueva += MainForm_Nueva;
            
        }

        private void MainForm_Nueva(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region "Constantes, Variables e instancias"
        public string c = Variables.strCon;
        public afgCon cnn;
        public string nameCurrentClass;
        public int idOpen = 0;
        public int idUsuarioActual = Variables.idUsuarioActual;
        public int idPerfilUsuarioActual = Variables.idPerfilUsuarioActual;
        public int idPerfilAdmin = Variables.idPerfilAdministrador;
        public int idPerfilNoAdmin = Variables.idPerfilNoAdministrador;


        #endregion
        #region "Declaración Eventos Personalizados"

        protected event EventHandler Nueva;

        #endregion
        #region "Métodos Eventos Personalizados"

        protected virtual void OnNueva(EventArgs e)
        {
            if (Nueva != null)
                Nueva(this, e);
        }
        #endregion
        #region "Eventos"
        private void MainForm_Load(object sender, EventArgs e)
        {
            cnn = new afgCon(c);
            nameCurrentClass = Name;
            
                
            
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Save();
            }
        }

        #endregion
        #region "Métodos"
        public virtual void Save()
        {
            
            bs.EndEdit();
           //ds. 
           
            try
            {
            Variables.idAbierto = idOpen;
           
            Update(ds);
            MessageBox.Show("Grabación Exitosa", "Información", MessageBoxButtons.OK);
            ds.Clear();
            
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            New();


        }

        public virtual void New()
        {
            foreach (DataTable dt in ds.Tables)
            {

                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                dt.Rows.Add(dr);
            }
        }

        public virtual void Open(int id)
        {
                idOpen = id;           
                DataTable dt = ds.Tables[0];
                string nameT = getNameMainRow();
                string sql = "SELECT " + getTableColumns(dt) + " FROM " + nameT + " WHERE id" + nameT + " = " + TryStr(idOpen);
                dtFill(dt, sql);           
        }

        #endregion
        #region "funciones"

        public int ExecuteNonQuery(string Sql)
        {
           
            cnn.Open();
            int reg = cnn.ExecuteNonQuery(Sql);
            cnn.Close();
            return reg;
            
        }

        public void dtFill(DataTable dt,string query)
        {
            cnn.Open();
            cnn.dtFill(dt, query);
            cnn.Close();
        }

        public object ExecuteScalar(string Sql)
        {
            
            cnn.Open();
            object rto = cnn.ExecuteScalar(Sql);
            cnn.Close();
            return rto;
            
        }

        
        public void Update(DataSet dsT)
        {
            cnn.Open();
            cnn.Update(dsT);
            cnn.Close();
        }

        public static object versionOriginal(DataRow dr,string columna)
        {
            if (dr.HasVersion(DataRowVersion.Original))
            {
                return dr[columna, DataRowVersion.Original];
            }
            else
            {
                return null;
            }
        }

        public static string TryStr(object txt)
        {
            return fun.TryStr(txt);
        }


        public static int TryInt(object valor)
        {
            return fun.TryInt(valor);

        }

        public static decimal TryDec(object valor)
        {
            return fun.TryDec(valor);
        }

        public static bool TryBool(object valor)
        {
            return fun.TryBool(valor);
        }



        public static bool TryBool(int valor)
        {
            return fun.TryBool(valor);
        }

        public static bool TryBool(string str)
        {
            return fun.TryBool(str);
        }


        public static string gsql(object valor)
        {
            return fun.gsql(valor);
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


        public static string Sha256(string text)
        {
            return fun.Sha256(text);
        }


        public static void Showfrm(string project, string frm, Form parent)
        {
            fun.Showfrm(frm,parent);
        }

        public static void ShowfrmDialog(string project, string frm, Form parent)
        {
            fun.ShowfrmDialog(frm, parent);
        }

        public static string getMaxString(string nomTable, string column, string filter = ";")
        {
            return fun.getMaxString(nomTable, column, filter);
        }

        public string get_eClave(string id, string psw)
        {
            return gsql(Sha256(Sha256(psw) + Sha256(id)));
        }

        public string get_Clave(string psw)
        {
            return gsql(Sha256(psw));
        }


        public string getNameMainRow()
        {
            return ds.Tables[0].TableName;
        }

        public string getTableColumns(DataTable dt)
        {
            return fun.getTableColumns(dt);
        }

        public string createList(DataTable dt,string Column)
        {
            return fun.createList(dt, Column);
        }

        #endregion

       
    }
}
