using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Librerias
{
    public partial class BuscarDoc : Librerias.MainForm
    {
        Form fparent;
        public BuscarDoc(Form parent)
        {
            InitializeComponent();
            fparent = parent;
        }

        int idO;

        new public void Save() { }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DataTable dtOpen = new DataTable("Doc");
            string codDoc = TryStr(fparent.Tag);
            string where = " WHERE codDoc = " + gsql(TryStr(codDoc)) + (txtSearch.Text == "" ? "" : " AND numDoc=" + gsql(txtSearch.Text)) ;
            string sqlS = "SELECT idDoc,codDoc + ' - ' + numDoc As Documento FROM Doc " + where;
            dtFill(dtOpen, sqlS);
            dgvSearch.DataSource = dtOpen;
            dgvSearch.Columns[0].Visible = false;
            dgvSearch.Visible = true;
        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = (DataGridView)sender;
            DataRowView drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
            DataRow dr = drv.Row;
            idO = TryInt(dr["idDoc"]);
            MainForm f = (MainForm)fparent;
            f.Open(idO);
            Close();
        }
    }
}
