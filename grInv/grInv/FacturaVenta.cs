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
    public partial class FacturaVenta : Librerias.MainForm
    {
        public FacturaVenta()
        {
            InitializeComponent();
        }

        int idEstado_Anulado = 11009;
        int idEstado_E = 11001;
        DataTable dtProducto = new DataTable("_Producto");
        DataTable dtCualidad = new DataTable("_Cualidad");
        DataTable dtTalla = new DataTable("_Talla");

        private void FacturaVenta_Load(object sender, EventArgs e)
        {
            New();
            
            var dst = ds;
        }

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
            sql = "SELECT  " + getTableColumns(dtDNI) + " FROM " + dtDNI.TableName + " WHERE idDoc = " + TryStr(id);
            dtFill(dtDNI, sql);
            foreach (DataRow dr in dtDoc_Inv.Rows)
            {
                dr["_idProducto"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idProducto"];
                dr["_idTalla"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idTalla"];
                dr["_idCualidad"] = dtInv.Rows.Find(TryInt(dr["idInv"]))["idCualidad"];
                total += TryDec(dr["CostoT"]);
            }
            dcDoc_Inv_idDoc.DefaultValue = TryInt(dtDoc.Rows[0]["idDoc"]);
            dcDNI_idDoc.DefaultValue = TryInt(dtDoc.Rows[0]["idDoc"]);
            lblTotal.Text = total.ToString("N0");

        }

        public override void New()
        {
            dtFill(dtInv, "SELECT " + getTableColumns(dtInv) + " FROM Inv WHERE Existencia <> 0");
            
            
            dcDoc_idPK.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idDoc FROM Doc ORDER BY idDoc DESC")) + 1;
            dcDNI_idPK.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idDoc_NoInv FROM Doc_NoInv ORDER BY idDoc_NoInv DESC")) + 1;
            dcDoc_Inv_idPK.AutoIncrementSeed = TryInt(ExecuteScalar("SELECT TOP 1 idDoc_Inv FROM Doc_Inv ORDER BY idDoc_Inv DESC")) + 1;
            txtNumDoc.Text = getMaxString("Doc", "numDoc","WHERE codDoc = 'FV'");
            bs.Filter = "idEstado <> " + idEstado_Anulado;

            
            dtFill(dtTalla, "SELECT idTalla,nomTalla FROM Talla");
            dgvcDI_idTalla.ValueMember = "idTalla";
            dgvcDI_idTalla.DisplayMember = "nomTalla";
            dgvcDI_idTalla.DataSource = dtTalla;

            dtFill(dtCualidad, "SELECT idCualidad,nomCualidad FROM Cualidad");
            dgvcDI_idCualidad.ValueMember = "idCualidad";
            dgvcDI_idCualidad.DisplayMember = "nomCualidad";
            dgvcDI_idCualidad.DataSource = dtCualidad;

            string idsProducto = createList(dtInv, "idProducto");
            dtFill(dtProducto, "SELECT idProducto,nomProducto FROM Producto WHERE idProducto IN (" + idsProducto + ")");
            dgvcDI_idProducto.ValueMember = "idProducto";
            dgvcDI_idProducto.DisplayMember = "nomProducto";
            dgvcDI_idProducto.DataSource = dtProducto;
            dcDoc_Inv_idEstado.DefaultValue = idEstado_E;

            DataRow drDoc = dtDoc.NewRow();
            drDoc["numDoc"] = txtNumDoc.Text;
            drDoc["fechaDoc"] = dtpFechaDoc.Value;
            drDoc["idCreador"] = Variables.idUsuarioActual;
            dtDoc.Rows.Add(drDoc);

            dcDoc_Inv_idDoc.DefaultValue = TryInt(dtDoc.Rows[0]["idDoc"]);
            dcDNI_idDoc.DefaultValue = TryInt(dtDoc.Rows[0]["idDoc"]);
            dcDNI_idEstado.DefaultValue = idEstado_E;
            dtInv.Clear();


            

        }

        public override void Save()
        {
            bs.EndEdit();
            bsDoc.EndEdit();
            try
            {
                decimal total = 0;
                for (int i = 0; i <= dtDoc_Inv.Rows.Count - 1; i++) //no se puede con foreach por que al remover algunas filas daña las colas.
                {
                    DataRow drDIN = dtDoc_Inv.Rows[i];
                    if (!drDIN.HasVersion(DataRowVersion.Original) && drDIN["idInv"].Equals(DBNull.Value))
                    {
                        dtDoc_Inv.Rows.Remove(drDIN);
                        continue;
                    }
                    int idInv = TryInt(drDIN["idInv"]);
                    DataRow drInv = dtInv.Rows.Find(idInv);
                    decimal cantidad = TryDec(drDIN["Cantidad"]);
                                      
                    decimal ExistenciaOri = TryDec(ExecuteScalar("SELECT Existencia FROM Inv WHERE idInv = " + gsql(idInv)));
                    decimal existenciaFut = ExistenciaOri - (cantidad - (drDIN.HasVersion(DataRowVersion.Original) ? TryDec(drDIN["Cantidad", DataRowVersion.Original]) : 0));
                    if(existenciaFut < 0)
                    {
                        ShowMsg("Uno o varios productos alcanzará un saldo negativo... corrígelo.", "Existencia Negativa", "error");
                        return;
                    }
                    else
                    {
                        drInv["Existencia"] = existenciaFut;
                    }
                    total += TryDec(drDIN["CostoT"]); ;
                }

                dtDoc.Rows[0]["Total"] = total;

                if (chkPS.Checked)
                {
                    DataRow drDNI = null;
                    if (dtDNI.Rows.Count == 0)
                    {
                        drDNI = dtDNI.NewRow();
                        drDNI["Cantidad"] = total;
                        drDNI["Saldo"] = total - TryDec(txtAbono.Text);
                        dtDNI.Rows.Add(drDNI);
                    } 
                    else
                    {
                        drDNI = dtDNI.Rows[0];
                        drDNI["Cantidad"] = total;
                        drDNI["Saldo"] = TryDec(versionOriginal(drDNI, "Saldo")) - TryDec(txtAbono.Text);
                    }
                }

                Update(ds);
                MessageBox.Show("Grabación Exitosa", "Información", MessageBoxButtons.OK);



                CrearTicket impresion = new CrearTicket();
                impresion.TextoIzquierda(" ");
                impresion.TextoCentro("Factura de Venta");
                impresion.TextoIzquierda(" ");
                impresion.TextoExtremos("FECHA : " + dtpFechaDoc.Text, "HORA : " + DateTime.Now.Hour.ToString());
                impresion.TextoIzquierda(" ");
                impresion.EncabezadoVenta();
                impresion.lineasGuio();
              
                foreach (DataRow dr in dtDoc_Inv.Rows)
                {
                    string articulo = TryStr(dtProducto.Select("idProducto = " +gsql(dr["_idProducto"]))[0]["nomProducto"]) + " " + TryStr(dtCualidad.Select("idCualidad = " + gsql(dr["_idCualidad"]))[0]["nomCualidad"]) + " " + TryStr(dtTalla.Select("idTalla = " + gsql(dr["_idTalla"]))[0]["nomTalla"]);
                    int cantidad = TryInt(dr["Cantidad"]);
                    decimal precio = TryDec(dr["CostoT"]), importe = 0;
                    impresion.AgregaArticulo(articulo,cantidad, precio,importe);
                }

                impresion.lineasIgual();
                impresion.AgregarTotales("          TOTAL         : $ ", total);
                //impresion.CortaTicket();
                
                impresion.ImprimirTicket("Enviar a OneNote 16");
                //impresion.ImprimirTicket("Microsoft Print to PDF");
                ds.Clear();
                New();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpFechaDoc_ValueChanged(object sender, EventArgs e)
        {
            DataRow drDoc = dtDoc.Rows[0];
            drDoc["fechaDoc"] = dtpFechaDoc.Value;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                int idProducto = TryInt(dr["_idProducto"]), idTalla = TryInt(dr["_idTalla"]), idCualidad = TryInt(dr["_idCualidad"]);

                    
                    if (idProducto != 0 && idTalla != 0 && idCualidad != 0)
                    {
                        int idInv;
                        dtFill(dtTempInv, "SELECT " + getTableColumns(dtInv) + " FROM Inv WHERE Existencia <> 0 AND idProducto = " + gsql(idProducto) + " AND idTalla = " + gsql(idTalla) + " AND idCualidad = " + gsql(idCualidad));
                        if (!esOriginal)
                        {
                            if (dtTempInv.Rows.Count == 0)
                            {

                                ShowMsg("El producto con las especificaciones escogidas no tiene inventario.", "Sin Inventario", "error");
                                dr[dpn] = DBNull.Value;
                                return;

                            }
                            else if (dtInv.Rows.Count == 0)
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

                case "Cantidad":
                case "CostoU":
                case "Descuento":

                    
                    int idPK = TryInt(dr["idInv"]);
                    DataRow drInv = dtInv.Rows.Find(idPK); //no me funcionó este método.
                    decimal saldoActual = TryDec(drInv["Existencia", DataRowVersion.Original]);



                    decimal cantidad = TryDec(dr["Cantidad"]), CostoU = TryDec(dr["CostoU"]), Descuento = TryDec(dr["Descuento"]);
                    decimal totalR = (cantidad * CostoU) - Descuento;

                    decimal saldoFut = saldoActual - (cantidad - (esOriginal ? TryDec(dr["Cantidad",DataRowVersion.Original]) : 0)); //Saldo con el q quedaría.
                    if (saldoFut < 0)
                    {
                        MessageBox.Show("La existencia quedará con saldo negativo. Actualmente hay " + saldoActual.ToString("N0") + " Unidades.");
                        dr.RejectChanges();
                        return;
                    }


                    drInv["Existencia"] = saldoFut;
                    dr["CostoT"] = totalR;
                    var dtdi = dtDoc_Inv;
                    decimal x = TryDec(dr["CostoT"]);//para DeBugg
                    var dsTemp = ds;//para DeBugg
                    bs.EndEdit();
                    decimal total = 0;
                                        
                    foreach (DataRow drT in dtDoc_Inv.Rows)
                    {
                        //DataRowView drT = (DataRowView)dgv.Rows[i].DataBoundItem;
                        total += TryDec(drT["CostoT"]);
                    }
                    lblTotal.Text = total.ToString("N0");
                    break;
            }


        }

        private void calculatotales()
        {

        }

        private void chkPS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPS.Checked)
            {
                lblAbono.Visible = true;
                txtAbono.Visible = true;
            }
            else
            {
                lblAbono.Visible = false;
                txtAbono.Visible = false;
            }
        }

        private void dgvInv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;
            DataRowView drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
            if (drv is null) return;
            bool esOriginal = drv.Row.HasVersion(DataRowVersion.Original);
            string dpn = dgv.Columns[e.ColumnIndex].DataPropertyName;

            switch (dpn)
            {
                case "_idProducto":
                case "_idTalla":
                case "_idCualidad":
                    if (esOriginal)
                    {
                        ShowMsg("Este registro ya ha sido guardado,para editar el producto, color o talla debe borrar la linea y crear una nueva.", "Denegado", "error");
                        e.Cancel = true;
                        return;
                    }
                    break;
            }
        }
    }
}
