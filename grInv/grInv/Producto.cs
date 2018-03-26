using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace grInv
{
    public partial class Producto : Librerias.MainForm
    {
        public Producto()
        {
            InitializeComponent();
            
        }
        DataTable dtFamilia = new DataTable();
        DataTable dtCualidad = new DataTable();

        private void Item_Load(object sender, EventArgs e)
        {
            dtFill(dtFamilia,"SELECT idFamilia,nomFamilia FROM Familia");
            dtFill(dtCualidad,"SELECT idCualidad,nomCualidad FROM Cualidad WHERE esActivo = 1");
            if (dtFamilia.Rows.Count > 0) cboFam.DataSource = dtFamilia;
            if (dtCualidad.Rows.Count > 0) cboColor.DataSource = dtCualidad;
            New();
        }
    }
}
