using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Librerias
{
    public class afgCon
    {

        SqlConnection cn = new SqlConnection();
        public string cadCon;
        //SqlDataReader dread = new SqlDataReader();
                
        public afgCon(string strCon)
        {
            cadCon = strCon;
        }

        public void Open()
        {
            if (cn.State == ConnectionState.Closed)
            { 
            cn.ConnectionString = cadCon;
            cn.Open();
            }
        }

        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        


        public int ExecuteNonQuery(string query)
        {

            SqlCommand cmd = new SqlCommand(query, cn);
            int registros = cmd.ExecuteNonQuery();
            return registros;
        }


        public void dtFill(DataTable dt, string query)
        {
            dt.Clear();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt.AcceptChanges();
            
        }

        public object ExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query,cn);
            var rta = cmd.ExecuteScalar();
            return rta;
        }

        public void Update(DataTable dt)
        {
            string nomTable = dt.TableName;

            foreach (DataRow dr in dt.Rows)
            {
                string nomColumn = "", dataColumn = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    string cName = dc.ColumnName;
                    nomColumn += "," + cName;
                    dataColumn += "," + fun.gsql(dr[cName]);
                }

            }

        }

        public void Update(DataSet ds)
        {
            string query = "";
            foreach (DataTable dt       in ds.Tables)
            {
                if (dt.TableName.StartsWith("_")) continue; //si tabla empieza por _ la ignora
                foreach (DataRow dr in dt.Rows)
                {

                    switch (dr.RowState)
                    {
                        case DataRowState.Added:
                            query += getCmdInsertingRow(dr);
                            break;
                        case DataRowState.Modified:
                            query += getUpdatingRow(dr);
                            break;
                        case DataRowState.Deleted:
                            query += getDeletingRow(dr);
                            break;
                    }
                }
            }
            ExecuteNonQuery(query);
        }


        public string getCmdInsertingRow(DataRow dr)
        {
            DataTable dt = dr.Table;

            string nomTable = dt.TableName, nomColumn = "", dataColumn = "",cmd="";
            
            foreach (DataColumn dc in dt.Columns)
            {
                
                string cName = dc.ColumnName;
                if (cName.StartsWith("_")) continue; // si columna empieza por _ la ignora.
                nomColumn += "," + cName;
                dataColumn += "," + fun.gsql(dr[cName]);
            }
            if (dt.Columns.Contains("id" + nomTable) && nomTable != "Usuario")
            {
                cmd = "SET IDENTITY_INSERT " + nomTable + " ON;INSERT INTO " + nomTable + " (" + nomColumn.Substring(1) + ",uStamp) " + "VALUES (" + dataColumn.Substring(1) + "," + Variables.idUsuarioActual + ");SET IDENTITY_INSERT " + nomTable + " OFF; ";
            }
            else
            {
                cmd = "INSERT INTO " + nomTable + "(" + nomColumn.Substring(1) + ",uStamp) " + "VALUES(" + dataColumn.Substring(1) + "," + Variables.idUsuarioActual + ");";
          
             }
            return cmd;
        }


        private string getUpdatingRow(DataRow dr, string filter = "")
        {
            DataTable dt = dr.Table;
            object Original, Current;
            string nomTable = dt.TableName, nomColumn = "", dataColumn = "", finalCmd = "",dtPK= "id" + nomTable, where = ""; 

            foreach (DataColumn dc in dt.Columns)
            {
                string cName = dc.ColumnName;
                
                if (cName.StartsWith("_")) continue;
                Original = dr[cName, DataRowVersion.Original];
                Current = dr[cName, DataRowVersion.Current];
                if (!Original.Equals(Current))
                {
                    nomColumn = cName;
                    dataColumn = fun.gsql(dr[cName]);
                    finalCmd += "," + nomColumn + " = " + dataColumn;
                }
                else if(cName == dtPK)
                {
                    where = dtPK + "=" + fun.gsql(dr[cName]);
                }
                
            }

            if (finalCmd == "") return "";
            if (where == "") where = dtPK + "=" + fun.TryStr(Variables.idAbierto);


            return "UPDATE " + dt.TableName + " SET " + finalCmd.Substring(1) + ",tStamp = GETDATE(),uStamp = " + Variables.idUsuarioActual + " WHERE " + where;

        }

        private string getDeletingRow(DataRow dr, string filter = "")
        {
            DataTable dt = dr.Table;
            string nomTable = dt.TableName, dtPK = "id" + nomTable,where;
            where = dtPK + "=" + fun.gsql(dr[dtPK]);
            return "DELETE FROM " + dt.TableName + " WHERE " + where;//No debe ser con idAbierto si no con los registros que se borraran.
        }
    }
}
