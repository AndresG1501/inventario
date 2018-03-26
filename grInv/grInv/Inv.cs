using Librerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Librerias.fun;

namespace grInv
{
    public partial class Inv : Librerias.MainForm
    {
        public Inv()
        {
            InitializeComponent();
        }

        private void str()
        {
            
        }
        int idEstado_Anulado = 10009;
        int idEstado_E = 10001;

        private void Inv_Load(object sender, EventArgs e)
        {
            New();

        }

        #region "Open,New,Save"
        public override void Open(int id)
        {
            string sql;
            decimal total = 0;
            sql = "SELECT " + getTableColumns(dtDoc) + " FROM " + dtDoc.TableName + " WHERE idDoc = " + TryStr(id);
            dtFill(dtDoc, sql);
            sql = "SELECT  " + getTableColumns(dtDoc_Inv) + " FROM " + dtDoc_Inv.TableName + " WHERE idDoc = " + TryStr(id);
            dtFill(dtDoc_Inv, sql);
            string idsInv = createList(dtDoc_Inv, "idInv");
            sql = "SELECT  " + getTableColumns(dtInv) + " FROM " + dtInv.TableName + " WHERE idInv IN (" + idsInv + ")";
            dtFill(dtInv, sql);
            foreach(DataRow dr in dtDoc_Inv.Rows)
            {
                dr["_idProducto"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idProducto"];
                dr["_idTalla"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idTalla"];
                dr["_idCualidad"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idCualidad"];
                total += TryDec(dr["CostoT"]);
            }

            lblTotal.Text = total.ToString("N0");
            
        }
        public override void New()
        {
            DataTable dtTalla = new DataTable();
            DataTable dtProducto = new DataTable();
            DataTable dtCualidad = new DataTable();
            dcDI_idPK.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idDoc_Inv FROM Doc_Inv ORDER BY idDoc_Inv DESC")) + 1;
            dcDoc_idDoc.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idDoc FROM Doc ORDER BY idDoc DESC")) + 1;
            dcInv_idPK.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idInv FROM Inv ORDER BY idInv DESC")) + 1;
            txtNumDoc.Text = getMaxString("Doc", "numDoc","WHERE codDoc = 'Inv'");
            bs.Filter = "idEstado <> " + idEstado_Anulado;

            
            dtFill(dtTalla, "SELECT idTalla,nomTalla FROM Talla");
            dgvcDI_idTalla.ValueMember = "idTalla";
            dgvcDI_idTalla.DisplayMember = "nomTalla";
            dgvcDI_idTalla.DataSource = dtTalla;

            dtFill(dtProducto, "SELECT idProducto,nomProducto FROM Producto");
            dgvcDI_idProducto.ValueMember = "idProducto";
            dgvcDI_idProducto.DisplayMember = "nomProducto";
            dgvcDI_idProducto.DataSource = dtProducto;

            dtFill(dtCualidad, "SELECT idCualidad,nomCualidad FROM Cualidad");
            dgvcDI_idCualidad.ValueMember = "idCualidad";
            dgvcDI_idCualidad.DisplayMember = "nomCualidad";
            dgvcDI_idCualidad.DataSource = dtCualidad;

            DataRow drDoc = dtDoc.NewRow();
            drDoc["numDoc"] = txtNumDoc.Text;
            drDoc["fechaDoc"] = dateTimePicker1.Value;
            drDoc["idCreador"] = Variables.idUsuarioActual;
            dtDoc.Rows.Add(drDoc);

            dcDI_idDoc.DefaultValue = TryInt(dtDoc.Rows[0]["idDoc"]);
        }

        public override void Save()
        {
            bs.EndEdit();
            bsDoc.EndEdit();
            try
            {
                // Variables.idAbierto = idOpen;
                var drDI = dtDoc_Inv.Rows;
                


                foreach (DataRow drInv in dtInv.Rows)
                {
                    DataRow drDIT = dtDoc_Inv.Select("idInv = " + TryInt(drInv["idInv"]))[0];
                    decimal cantidad = TryDec(drDIT["Cantidad"]);

                    decimal dif = 0;
                    decimal ExistenciaOri = 0;
                    if (drInv.HasVersion(DataRowVersion.Original))
                    {
                        decimal cantidadOri = TryDec(drDIT["Cantidad", DataRowVersion.Original]);
                        ExistenciaOri = TryDec(drInv["Existencia", DataRowVersion.Original]);
                        dif = cantidad - cantidadOri;
                    }
                    else if (!drInv.HasVersion(DataRowVersion.Original))
                    {
                        dif = cantidad;
                    }
                    

                    drInv["Existencia"] = ExistenciaOri + dif;
                }

                foreach(DataRow drDIN in dtDoc_Inv.Rows)
                {
                    if (!drDIN.HasVersion(DataRowVersion.Original) && drDIN["idInv"] is null) dtDoc_Inv.Rows.Remove(drDIN);
                }
                

                Update(ds);
                MessageBox.Show("Grabación Exitosa", "Información", MessageBoxButtons.OK);
                ds.Clear();
                New();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion




        private void dgvInv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int flag = 0;
            if (!(dgvInv.CurrentCell is null))
            {
                flag++;
                if (flag == 0) dgvInv.BeginEdit(true);
            }

            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;
            DataRowView drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
            DataRow dr = drv.Row;
            bool esOriginal = dr.HasVersion(DataRowVersion.Original);
            string dpn = dgv.Columns[e.ColumnIndex].DataPropertyName; 
            DataTable dtTempInv = dtInv.Clone();
            switch (dpn)
            {
                case "_idProducto": 
                case "_idTalla":
                case "_idCualidad":

                    int idProducto = TryInt(dr["_idProducto"]), idTalla = TryInt(dr["_idTalla"]), idCualidad=TryInt(dr["_idCualidad"]);

                    dtFill(dtTempInv, "SELECT " + getTableColumns(dtInv) + " FROM Inv WHERE idProducto = " + idProducto + " AND idTalla = " + idTalla + " AND idCualidad = " + idCualidad);
                    if ( idProducto != 0 && idTalla != 0 && idCualidad != 0)
                    {
                        if(!esOriginal) { 
                        int idInv;
                        
                        
                        if (dtTempInv.Rows.Count == 0)
                        {
                            
                            DataRow drNInv = dtInv.NewRow();
                            drNInv["idProducto"] = idProducto;
                            drNInv["idTalla"] = idTalla;
                            drNInv["idCualidad"] = idCualidad;
                            dtInv.Rows.Add(drNInv);
                            idInv = TryInt(dtInv.Rows[e.RowIndex]["idInv"]);

                        }
                        else if(dtInv.Rows.Count == 0)
                        {
                            DataRow drInvTemp = dtTempInv.Rows[0];
                            idInv = TryInt(drInvTemp["idInv"]);
                            dtInv.ImportRow(drInvTemp);
                        }
                        else
                        {
                            dtInv.Merge(dtTempInv);
                            idInv = TryInt(dtTempInv.Rows[0]["idInv"]);
                        }
                        bs.EndEdit();
                        var dsTemp1 = ds;
                        dr["idInv"] = idInv;
                        }
                       
                    }
                    
                    break;

                case "Cantidad": case "CostoU": case "Descuento":
                    

                    int idPK = TryInt(dr["idInv"]);
                    //DataRow drInv = dtInv.Select("idInv = " + idPK)[0];
                    DataRow drInv = dtInv.Rows.Find(idPK); //no me funciono este metodo
                    decimal cantidad = TryDec(dr["Cantidad"]), CostoU = TryDec(dr["CostoU"]), Descuento = TryDec(dr["Descuento"]);
                    decimal totalR = (cantidad * CostoU) - Descuento;
                    dr["CostoT"] = totalR;
                    var dtdi = dtDoc_Inv;
                    decimal x = TryDec(dr["CostoT"]);//para DeBugg
                    var dsTemp = ds;//para DeBugg
                    bs.EndEdit();
                    decimal total = 0;

                    //DataGridViewRowCollection dgvrc = dgv.Rows; //Inicialmente lo hice asi por que dgv no me propagaba cambios al ds.
                    //for (int i = 0; i<=dgvrc.Count - 2; i++)
                    foreach(DataRow drT in dtDoc_Inv.Rows)
                    {
                        //DataRowView drT = (DataRowView)dgv.Rows[i].DataBoundItem;
                        total += TryDec(drT["CostoT"]);
                    }
                    lblTotal.Text = total.ToString("N0");
                    break;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataRow drDoc = dtDoc.Rows[0];
            drDoc["fechaDoc"] = dateTimePicker1.Value;
        }

        private void dgvInv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataRow dr = ((DataRowView)e.Row.DataBoundItem).Row;
            if (dr.HasVersion(DataRowVersion.Original))
            {
                dr.RejectChanges();
                dr.ClearErrors();
                dr["idEstado"] = idEstado_Anulado;
                dr["Cantidad"] = 0;
                dr["CostoT"] = 0;
                dr["CostoU"] = 0;
                decimal total = 0;

                foreach (DataRow drT in dtDoc_Inv.Rows)
                {
                    
                    total += TryDec(drT["CostoT"]);
                }
                lblTotal.Text = total.ToString("N0");
                e.Cancel = true;
            }
        }

        private void dgvInv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;
            DataRowView drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
            if (drv is null) return;
            DataRow dr = drv.Row;
            bool esOriginal = dr.HasVersion(DataRowVersion.Original);
            string dpn = dgv.Columns[e.ColumnIndex].DataPropertyName;
            
            switch (dpn)
            {
                case "_idProducto":
                case "_idTalla":
                case "_idCualidad":
                    if (esOriginal)
                    {
                        ShowMsg("Este registro ya ha sido guardado,para editar el producto, color o talla debe borrar la linea y crear una nueva.","Denegado","error");
                        e.Cancel = true;
                        return;
                    }
                    break;
            }
        }
    }
}
