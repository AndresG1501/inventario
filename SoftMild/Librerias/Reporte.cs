using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Librerias
{
    public partial class Reporte : Librerias.MainForm
    {
        public Reporte()
        {
            InitializeComponent();
        }
        string sql = "";
        DataTable dtTempReporte = new DataTable();

        new public void Save() { } //para deshabilitar el metodo save del mainform.

        private void Reporte_Load(object sender, EventArgs e)
        {
            dtFill(dtReporte, "SELECT " + getTableColumns(dtReporte) + " FROM Reporte");
            cboReporte.DataSource = dtReporte;
            cboReporte.SelectedIndex = -1;

        }

        private void cboReporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtTempReporte.Clear();
            if(dgvReporte.Visible) dgvReporte.Visible = false;
            DataRow drRep = dtReporte.Rows.Find(cboReporte.SelectedValue);
            sql = TryStr(drRep["SQL"]);
            bool parametroFecha = sql.Contains("[fecha]");
            if (parametroFecha)
            {
                dtpHasta.Visible = parametroFecha;
                lblFecha.Visible = parametroFecha;
            }
            else
            {
                dtpHasta.Visible = parametroFecha;
                lblFecha.Visible = parametroFecha;
            }
        }

        private void Reporte_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.A))
            {
                dtTempReporte.Clear();
                sql = sql.Replace("[fecha]", gsql(dtpHasta.Value));
                dtFill(dtTempReporte, sql);
                dgvReporte.DataSource = dtTempReporte;
                dgvReporte.Visible = true;
            }
        }

        
       
    }
}
