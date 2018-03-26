using System;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace Librerias
{
    public partial class BuscarReg : MainForm
    {
        /*
         * Este Formulario se utilizará solo para los formularios que solo manejen una tabla,
         * para los que manejen mas de 1 tabla se creara otro form.
         */
        string nameTable, nameClassToInvoke, idPkColumn, columnToSearch;
        int idO;
        Form fparent;
        int idPermUsuario;
        int idPerfilAdministrador = 10001;
        public BuscarReg(string nameTableToOpen,string nameClass,Form parent)
        {
            InitializeComponent();
            nameTable = nameTableToOpen;
            nameClassToInvoke = nameClass;
            fparent = parent;
        }


        new public void Save() { }

        private void BuscarReg_Load(object sender, EventArgs e)
        {
           New();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DataTable dtOpen = new DataTable(nameTable);
            columnToSearch = "nom" + nameTable;
            idPkColumn = "id" + nameTable;
            string regToSearch = txtBusReg.Text;
            string sqlS = "SELECT " + idPkColumn + "," + columnToSearch + " FROM " + nameTable + " WHERE " + columnToSearch + " LIKE '%" + regToSearch + "%'";
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
            idO = TryInt(dr[idPkColumn]);
            MainForm f = (MainForm)fparent;
            f.Open(idO);
            Close();
            
        }

        
    }
}
