using Librerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace grInv
{
    public partial class regFamilia : Librerias.MainForm
    {
        public regFamilia()
        {
            InitializeComponent();
        }

        public override void New()
        {
            foreach (DataTable dt in ds.Tables)
            {

                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                dt.Rows.Add(dr);
            }
        }

        private void regFamilia_Load(object sender, EventArgs e)
        {
            New();
        }
    }
}
